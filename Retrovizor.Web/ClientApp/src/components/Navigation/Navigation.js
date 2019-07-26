import React, { Component } from "react";
import { Link } from "react-router-dom";
import "./Navigation.css";

export default class Navigation extends Component {
  render() {
    return (
      <nav>
        <Link to="/materijali">
          <span>
            <img
              class="nav__hamburger"
              src="./assets/images/HAMBURGER-TEMP.png"
              alt="Hamburger"
            />
          </span>
        </Link>

        <Link to="/raspored">
          <span>
            <img
              class="nav__checklist"
              src="./assets/images/CHECKLIST-TEMP.png"
              alt="Checklist"
            />
          </span>
        </Link>

        <Link to="/voznja">
          <span>
            <img
              class="nav__car"
              src="./assets/images/CAR-TEMP.png"
              alt="Car"
            />
          </span>
        </Link>

        <Link to="/profil">
          <span>
            <img
              class="nav__profile"
              src="./assets/images/PROFILE-TEMP.png"
              alt="Profile"
            />
          </span>
        </Link>
      </nav>
    );
  }
}
