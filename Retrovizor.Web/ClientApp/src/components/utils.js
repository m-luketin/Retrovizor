import axios from "axios";

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
        console.log(payload);
        response = await axios.post(url, payload);
        break;
      case "delete":
        response = await axios.delete(url);
        break;
    }

    return response.data;
  } catch (error) {
    const refreshResponse = await axios.post("/api/auth/refresh", {
      access: "",
      refresh: token.refresh
    });

    const { access, refresh } = refreshResponse.data;
    setTokens(access, refresh);

    axios.defaults.headers.common["Authorization"] = `Bearer ${access}`;

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
    }

    return response.data;
  }
};

export const getFirstName = fullName =>
  fullName
    .split(" ")
    .slice(0, -1)
    .join(" ");

export const getLastName = fullName =>
  fullName
    .split("")
    .slice(-1)
    .join("");

export const formatPhoneNumber = number => {
  let addedPlus = "+" + number.substring(2);
  let addedSpace =
    addedPlus.substring(0, 4) +
    " " +
    addedPlus.substring(4, 7) +
    " " +
    addedPlus.substring(7, 10) +
    " " +
    addedPlus.substring(10, 13);

  return addedSpace;
};
