import React, { Component } from "react";
import { Link } from "react-router-dom";
import "./Navigation.css";
// SVG import
import Hamburger from "../../assets/Hamburger.svg";
import HamburgerBlue from "../../assets/HamburgerBlue.svg";
import Checklist from "../../assets/Checklist.svg";
import ChecklistBlue from "../../assets/ChecklistBlue.svg";
import Person from "../../assets/Person.svg";
import PersonBlue from "../../assets/PersonBlue.svg";

export default class InstructorNav extends Component {
  constructor(props) {
    super(props);
    this.state = {
      isBlueArray: [],
      navClass: ""
    };
  }

  componentDidMount() {
    this.isBlueArraySetup(window.location.href);
  }

  componentWillReceiveProps(nextProps) {
    this.isBlueArraySetup(nextProps.location);
  }

  isBlueArraySetup = stringToCheck => {
    let { isBlueArray } = this.state;
    stringToCheck = window.location.href;

    if (stringToCheck.includes("kandidati")) {
      isBlueArray = [true, false, false];
    } else if (stringToCheck.includes("raspored")) {
      isBlueArray = [false, true, false];
    } else if (stringToCheck.includes("profil")) {
      isBlueArray = [false, false, true];
    } else this.setState({ navClass: "d-none" });

    this.setState({ isBlueArray });
  };

  render() {
    const { isBlueArray, navClass } = this.state;

    return (
      <nav className={navClass}>
        <Link to="/instruktor/kandidati">
          {isBlueArray[0] ? (
            <span className="nav__span--first">
              <img
                className="nav__hamburger"
                alt="Hamburger"
                src={HamburgerBlue}
              />
              <p className="nav__description c-blue">Kandidati</p>
            </span>
          ) : (
            <span className="nav__span--first">
              <img className="nav__hamburger" alt="Hamburger" src={Hamburger} />
              <p className="nav__description">Kandidati</p>
            </span>
          )}
        </Link>

        <Link to="/instruktor/raspored">
          {isBlueArray[1] ? (
            <span>
              <img
                className="nav__checklist"
                alt="Checklista"
                src={ChecklistBlue}
              />
              <p className="nav__description c-blue">Raspored</p>
            </span>
          ) : (
            <span>
              <img
                className="nav__checklist"
                alt="Checklista"
                src={Checklist}
              />
              <p className="nav__description">Raspored</p>
            </span>
          )}
        </Link>

        <Link to="/instruktor/profil">
          {isBlueArray[2] ? (
            <span className="nav__span--last">
              <img className="nav__profile" alt="Osoba" src={PersonBlue} />
              <p className="nav__description c-blue">Profil</p>
            </span>
          ) : (
            <span className="nav__span--last">
              <img className="nav__profile" alt="Osoba" src={Person} />
              <p className="nav__description">Profil</p>
            </span>
          )}
        </Link>
      </nav>
    );
  }
}
1;
