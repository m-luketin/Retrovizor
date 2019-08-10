import React, { Component } from "react";
import { Link } from "react-router-dom";
import "./AdministratorProfile.css";
// SVG import
import Profile from "../../../assets/Instructor.gif";
import Gear from "../../../assets/Gear.svg";
import GrayPencil from "../../../assets/GrayPencil.svg";
import Phone from "../../../assets/Phone.svg";
import SpeedyCar from "../../../assets/SpeedyCar.svg";
import People from "../../../assets/People.svg";
import Calendar from "../../../assets/Calendar.svg";
import { authorizedRequest } from "../../utils";

export default class AdministratorProfile extends Component {
  constructor(props) {
    super(props);
    this.state = {
      user: { admin: {} },
      studentCount: 0,
      instructorCount: 0,
      drivingSchool: {}
    };
  }

  componentDidMount() {
    authorizedRequest("/api/admin/get", "get").then(data => {
      this.setState({ ...this.state, user: data });
    });
    authorizedRequest("/api/drivingschool/get-student-count", "get").then(
      data => {
        this.setState({ ...this.state, studentCount: data });
      }
    );
    authorizedRequest("/api/drivingschool/get-instructor-count", "get").then(
      data => {
        this.setState({ ...this.state, instructorCount: data });
      }
    );
    authorizedRequest("/api/drivingschool/get", "get").then(data => {
      this.setState({ ...this.state, drivingSchool: data });
    });
  }

  render() {
    const { user, studentCount, instructorCount, drivingSchool } = this.state;

    return (
      <React.Fragment>
        <header className="header">
          <h1 className="header__title">Profil</h1>
          <button>
            <Link to="/administrator/profil/postavke">
              <img
                className="header__settings"
                alt="Settings button"
                src={Gear}
              />
            </Link>
          </button>
        </header>
        <main className="main__drive main__instructor">
          <section className="main__next--lesson--wrapper">
            <div className="main__driving mb-20px">
              <div className="profile__image--wrapper">
                <img
                  className="profile__user-icon"
                  src={Profile}
                  alt="User icon"
                />
                <span className="profile__user--edit--wrapper">
                  <img
                    className="profile__user--edit"
                    alt="Edit ikonica"
                    src={GrayPencil}
                  />
                </span>
              </div>

              <span className="button__info">
                <h3 className="instructor__name school--name">
                  {drivingSchool.name}
                </h3>
              </span>
            </div>

            <figure className="instructor__item">
              <img
                className="instructor__item--speedy"
                alt="Auto"
                src={SpeedyCar}
              />
              <div>
                <figcaption className="instructor__item--title">
                  Instruktori
                </figcaption>
                <p className="instructor__item--text">{instructorCount}</p>
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
                  Kandidati
                </figcaption>
                <p className="instructor__item--text">{studentCount}</p>
              </div>
            </figure>

            <figure className="instructor__item">
              <img
                className="instructor__item--calendar"
                alt="Auto"
                src={Calendar}
              />
              <div>
                <figcaption className="instructor__item--title">
                  Prolaznost
                </figcaption>
              </div>
            </figure>
          </section>

          <section>
            <button className="main__button--big main__button--admin bc-blue">
              <div className="main__button--text main__button--admin--text">
                <h3>Ispit iz prometnih propisa</h3>
                <p>498/531 (94%)</p>
              </div>
            </button>

            <button className="main__button--big main__button--admin bc-blue">
              <div className="main__button--text main__button--admin--text">
                <h3>Ispit iz prve pomoći</h3>
                <p>498/531 (94%)</p>
              </div>
            </button>

            <button className="main__button--big main__button--admin bc-blue">
              <div className="main__button--text main__button--admin--text">
                <h3>Ispit iz vožnje</h3>
                <p>498/531 (94%)</p>
              </div>
            </button>
          </section>
        </main>
      </React.Fragment>
    );
  }
}
