import React, { Component } from "react";
import { Link } from "react-router-dom";
import "./Navigation.css";
// SVG import
import SpeedyCarBlue from "../../assets/SpeedyCarBlue.svg";
import SpeedyCar from "../../assets/SpeedyCar.svg";
import Hamburger from "../../assets/Hamburger.svg";
import HamburgerBlue from "../../assets/HamburgerBlue.svg";
import Checklist from "../../assets/Checklist.svg";
import ChecklistBlue from "../../assets/ChecklistBlue.svg";
import Person from "../../assets/Person.svg";
import PersonBlue from "../../assets/PersonBlue.svg";

export default class StudentNav extends Component {
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

    if (stringToCheck.includes("materijali")) {
      isBlueArray = [true, false, false, false];
    } else if (stringToCheck.includes("raspored")) {
      isBlueArray = [false, true, false, false];
    } else if (stringToCheck.includes("voznja")) {
      isBlueArray = [false, false, true, false];
    } else if (stringToCheck.includes("profil")) {
      isBlueArray = [false, false, false, true];
    } else this.setState({ navClass: "d-none" });

    this.setState({ isBlueArray });
  };

  render() {
    const { isBlueArray, navClass } = this.state;

    return (
      <nav className={navClass}>
        <Link to="/kandidat/materijali">
          {isBlueArray[0] ? (
            <span className="nav__span--first">
              <img
                className="nav__hamburger"
                alt="Hamburger"
                src={HamburgerBlue}
              />
              <p className="nav__description c-blue">Materijali</p>
            </span>
          ) : (
            <span className="nav__span--first">
              <img className="nav__hamburger" alt="Hamburger" src={Hamburger} />
              <p className="nav__description">Materijali</p>
            </span>
          )}
        </Link>

        <Link to="/kandidat/raspored">
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

        <Link to="/kandidat/voznja">
          {isBlueArray[2] ? (
            <span>
              <img className="nav__car" alt="Auto" src={SpeedyCarBlue} />
              <p className="nav__description c-blue">Vožnja</p>
            </span>
          ) : (
            <span>
              <img className="nav__car" alt="Auto" src={SpeedyCar} />
              <p className="nav__description">Vožnja</p>
            </span>
          )}
        </Link>

        <Link to="/kandidat/profil">
          {isBlueArray[3] ? (
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
