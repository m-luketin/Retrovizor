import React, { Component } from "react";
import { Redirect, Route } from "react-router-dom";
import { authorizedRequest } from "./utils";

export const PrivateRoute = ({ component: Component, ...rest }) => (
  <Route
    render={props =>
      localStorage.getItem("access") &&
      localStorage.getItem("user") === true ? (
        <Component {...props} />
      ) : (
        <Redirect to={{ pathname: "/", state: { from: props.location } }} />
      )
    }
  />
);

export const isUserValid = async () => {
  const url = window.location.href;
  window.localStorage.removeItem("user");
  let response = await authorizedRequest("api/Auth/get-role", "get");

  window.localStorage.setItem("user", url.includes(`/${response}/`));
};
