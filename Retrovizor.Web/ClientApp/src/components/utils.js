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
        response = await axios.post(url, payload);
        break;
      case "delete":
        response = await axios.delete(url, payload);
        break;

      default:
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

      default:
        break;
    }

    return response.data;
  }
};

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

export const getStudentCurrentLesson = student => {
  return student.studentClasses[student.studentClasses.length - 1]
    .currentLesson;
};

export const setupReviewStarsForMapping = reviewsArray => {
  let boolArray = [];

  let reviewNumber = getReviewStarsAverage(reviewsArray);

  // only because DB is no setup right - delete this newx line when setup
  reviewNumber = 4;

  for (let i = 0; i < 5; i++) {
    if (i < reviewNumber) boolArray.push(true);
    else boolArray.push(false);
  }

  return boolArray;
};

const getReviewStarsAverage = reviewsArray => {
  let summ = 0;
  reviewsArray.forEach(review => {
    summ += review.reviewText;
  });

  return summ / reviewsArray.length;
};

export const getInstructorsActiveStudentCount = instructorToDisplay => {
  let numberOfStudents = 0;

  instructorToDisplay.vehicleSessions.forEach(session => {
    if (session.isActive) numberOfStudents++;
  });

  return numberOfStudents;
};

export const formatTimeForDisplay = time => {
  let timeOnly = new Date(time).toLocaleTimeString();
  let shorterTime = timeOnly.substring(0, 5);

  if (shorterTime.slice(-1) === ":") return shorterTime.substring(0, 4);
  return shorterTime;
};

export const formatDate = date => {
  let dayOfTheWeek = date.substring(0, 3);
  switch (dayOfTheWeek) {
    case "Mon":
      dayOfTheWeek = "Ponedjeljak";
      break;
    case "Tue":
      dayOfTheWeek = "Utorak";
      break;
    case "Wed":
      dayOfTheWeek = "Srijeda";
      break;
    case "Thu":
      dayOfTheWeek = "Četvrtak";
      break;
    case "Fri":
      dayOfTheWeek = "Petak";
      break;
    case "Sat":
      dayOfTheWeek = "Subota";
      break;
    case "Sun":
      dayOfTheWeek = "Nedjelja";
      break;

    default:
      break;
  }

  let d = new Date(date),
    month = d.getMonth() + 1,
    day = d.getDate();

  switch (month) {
    case 1:
      month = "Siječnja";
      break;
    case 2:
      month = "Veljače";
      break;
    case 3:
      month = "Ožujka";
      break;
    case 4:
      month = "Travnja";
      break;
    case 5:
      month = "Svibnja";
      break;
    case 6:
      month = "Lipnja";
      break;
    case 7:
      month = "Srpnja";
      break;
    case 8:
      month = "Kolovoza";
      break;
    case 9:
      month = "Rujna";
      break;
    case 10:
      month = "Listopada";
      break;
    case 11:
      month = "Studenog";
      break;
    case 12:
      month = "Prosinca";
      break;

    default:
      break;
  }

  return [dayOfTheWeek, day, month];
};

export const formatDateNotForDisplay = date => {
  let d = new Date(date),
    month = "" + (d.getMonth() + 1),
    day = "" + d.getDate(),
    year = d.getFullYear();

  if (month.length < 2) month = "0" + month;
  if (day.length < 2) day = "0" + day;

  return [year, month, day].join("-");
};
