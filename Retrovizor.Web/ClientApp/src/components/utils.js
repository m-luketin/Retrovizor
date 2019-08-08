import axios from "axios";

export const getInstructorsBySchoolId = id =>
  axios.get(`api/Instructor/get-by-driving-school/${id}`);
