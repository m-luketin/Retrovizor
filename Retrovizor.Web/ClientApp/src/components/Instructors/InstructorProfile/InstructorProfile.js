import React, { Component } from "react";
import { Link } from "react-router-dom";
import {
  authorizedRequest,
  formatPhoneNumber,
  getInstructorsActiveStudentCount
} from "../../utils";
// SVG import
import Profile from "../../../assets/Instructor.gif";
import DisplayCar from "../../../assets/DisplayCar.png";
import Phone from "../../../assets/Phone.svg";
import NormalCar from "../../../assets/NormalCar.svg";
import People from "../../../assets/People.svg";
import Gear from "../../../assets/Gear.svg";
import GrayPencil from "../../../assets/GrayPencil.svg";


export default class InstructorProfile extends Component {
  constructor(props) {
    super(props);
    this.state = {
      instructorToDisplay: null
    };
  }

  componentDidMount() {
    authorizedRequest(`api/Instructor/get/0`, "get", "").then(data => {
      this.setState({ instructorToDisplay: data });
      // console.log(data);
    });
  }

  render() {
    const { instructorToDisplay } = this.state;

    if (instructorToDisplay === null) return null;

    return (
      <React.Fragment>
        <header className="header--instructors">
          <Link to="/administrator/instruktori">
            <h1 className="header__title">Profil</h1>
          </Link>
          <Link to="/instruktor/profil/postavke">
            <img
              className="header__settings"
              alt="Settings button"
              src={Gear}
            />
          </Link>
        </header>
        <main className="main__drive main__instructor">
          <section className="main__next--lesson--wrapper">
            <div className="main__driving mb-20px ">
              <div className="profile__image--wrapper">
                <img
                  src={Profile}
                  alt="User icon"
                  className="profile__user-icon profile__user-icon--instructor"
                />
                <span className="profile__user--edit--wrapper">
                  <img
                    className="profile__user--edit"
                    alt="Olovka"
                    src={GrayPencil}
                  />
                </span>
              </div>

              <button className="main__button main__button--schedule main__button--driving main__button--name">
                <span className="button__info">
                  <h3 className="instructor__name">
                    {instructorToDisplay.firstName}{" "}
                    {instructorToDisplay.lastName}
                  </h3>
                  <p className="instructor__school c-blue">
                    Autoškola "{instructorToDisplay.user.drivingSchool.name}"
                  </p>
                </span>
              </button>
            </div>

            <figure className="instructor__item">
              <img
                className="instructor__item--phone"
                alt="Phone"
                src={Phone}
              />
              <div>
                <figcaption className="instructor__item--title">
                  Kontakt:
                </figcaption>
                <p className="instructor__item--text c-blue">
                  {formatPhoneNumber(instructorToDisplay.user.phoneNumber)}
                </p>
              </div>
            </figure>

            <figure className="instructor__item">
              <img
                className="instructor__item--people"
                alt="Ljudi"
                src={People}
              />
              <div>
                <figcaption className="instructor__item--title">
                  Kandidati:
                </figcaption>
                <p className="instructor__item--text">
                  {getInstructorsActiveStudentCount(instructorToDisplay)}/15
                </p>
              </div>
            </figure>

            <section className="instructor__item--wrapper">
              <figure className="instructor__item">
                <img
                  className="intructor__item--car"
                  alt="Auto"
                  src={NormalCar}
                />
                <div className="instructor__item--car--wrapper">
                  <figcaption className="instructor__item--title">
                    Auto:
                  </figcaption>
                  <p className="instructor__item--text">
                    {instructorToDisplay.vehicle.manufacturer}{" "}
                    {instructorToDisplay.vehicle.model} 2018
                  </p>
                </div>
              </figure>
              <img
                className="instructor__item--preview"
                src={DisplayCar}
                alt="car"
              />
            </section>
          </section>
        </main>
      </React.Fragment>
    );
  }
}
