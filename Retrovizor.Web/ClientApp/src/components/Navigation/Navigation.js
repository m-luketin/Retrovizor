import React, { Component } from "react";
import "./Navigation.css";

export default class Navigation extends Component {
  render() {
    return (
      <nav>
        <span>
          <img
            class="nav__hamburger"
            src="./assets/images/HAMBURGER-TEMP.png"
            alt="Hamburger"
          />
        </span>
        <span>
          <img
            class="nav__checklist"
            src="./assets/images/CHECKLIST-TEMP.png"
            alt="Checklist"
          />
        </span>
        <span>
          <img class="nav__car" src="./assets/images/CAR-TEMP.png" alt="Car" />
        </span>
        <span>
          <img
            class="nav__profile"
            src="./assets/images/PROFILE-TEMP.png"
            alt="Profile"
          />
        </span>
      </nav>
    );
  }
}
