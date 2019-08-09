import axios from "axios";

export const getInstructorsBySchoolId = id =>
  axios.get(`api/Instructor/get-by-driving-school/${id}`);

export const getTokens = () => {
  var access = localStorage.getItem("access");
  var refresh = localStorage.getItem("refresh");
  return { access, refresh };
};

export const setTokens = (token, refreshToken) => {
  localStorage.setItem("access", token);
  localStorage.setItem("refresh", refreshToken);
};

export const authorizedRequest = async (url, method, payload) => {
  const token = getTokens();
  axios.defaults.headers.common["Authorization"] = `Bearer ${token.access}`;

  try {
    let response = null;

    switch (method) {
      case "get":
        response = await axios.get(url);
        break;
      case "post":
        response = await axios.post(url, payload);
        break;
      case "delete":
        response = await axios.delete(url);
        break;
      default:
        break;
    }

    return response.data;
  } catch (error) {
    const response = await axios.post("/api/auth/refresh", {
      access: "",
      refresh: token.refresh
    });

    const { access, refresh } = response.data;
    setTokens(access, refresh);

    axios.defaults.headers.common["Authorization"] = `Bearer ${access}`;

    const { data } = await axios.get(url);
    return data;
  }
};
