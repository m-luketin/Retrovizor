import React from "react";
import { Redirect, Route } from "react-router-dom";
import { authorizedRequest } from "./utils";

export const PrivateRoute = ({ component: Component, ...rest }) => (
  <Route
    {...rest}
    render={props =>
      localStorage.getItem("access") && isUserValid() ? (
        <Component {...props} />
      ) : (
        <Redirect to={{ pathname: "/", state: { from: props.location } }} />
      )
    }
  />
);

export const setUserToLocalStorage = async () => {
  window.localStorage.removeItem("user");
  let response = await authorizedRequest("api/Auth/get-role", "get");

  window.localStorage.setItem("user", response);
};

const isUserValid = () => {
  const url = window.location.href;
  const user = window.localStorage.getItem("user");

  return url.includes(`/${user}/`);
};
