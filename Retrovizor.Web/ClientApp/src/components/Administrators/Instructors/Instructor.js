import React, { Component } from "react";
import { Link } from "react-router-dom";
import InstructorEditModal from "./InstructorEditModal";
import "./Instructors.css";
// SVG import
import Profile from "../../../assets/Instructor.gif";
import DisplayCar from "../../../assets/DisplayCar.png";
import Phone from "../../../assets/Phone.svg";
import HeaderArrow from "../../../assets/HeaderArrow.svg";
import BluePencil from "../../../assets/BluePencil.svg";
import GrayPencil from "../../../assets/GrayPencil.svg";
import Calendar from "../../../assets/Calendar.svg";
import NormalCar from "../../../assets/NormalCar.svg";
import People from "../../../assets/People.svg";
import { isUserValid } from "../../PrivateRoute";

export default class Instructor extends Component {
  constructor(props) {
    super(props);
    this.state = {
      editModalVisibility: false
    };
  }

  componentDidMount() {
    isUserValid();
  }

  handleOpenEditModal = () => {
    document.getElementsByTagName("body")[0].classList.add("o-hidden");
    this.setState({ editModalVisibility: true });
  };

  handleCloseEditModal = () => {
    document.getElementsByTagName("body")[0].classList.remove("o-hidden");
    this.setState({ editModalVisibility: false });
  };

  render() {
    const { editModalVisibility } = this.state;

    return (
      <React.Fragment>
        <header className="header--instructors">
          <Link to="/administrator/instruktori">
            <img className="header__arrow" alt="Strelica" src={HeaderArrow} />
            <h1 className="header__title header__title--blue">Instruktor</h1>
          </Link>
          <img
            onClick={this.handleOpenEditModal}
            className="header__icon--pencil"
            alt="plava olovka"
            src={BluePencil}
          />
        </header>
        <main className="main__drive main__instructor">
          <section className="main__next--lesson--wrapper">
            <div className="main__driving mb-20px">
              <div className="profile__image--wrapper">
                <img
                  className="profile__user-icon"
                  alt="User icon"
                  src={Profile}
                />
                <span className="profile__user--edit--wrapper">
                  <img
                    className="profile__user--edit"
                    alt="GrayPencil"
                    src={GrayPencil}
                  />
                </span>
              </div>

              <button className="main__button main__button--schedule main__button--driving main__button--name">
                <span className="button__info">
                  <h3 className="instructor__name">Ivan Bartičević</h3>
                  <p className="instructor__school">Autoškola "Dalmacija"</p>
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
                <p className="instructor__item--text c-blue">+385 123123123</p>
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
                <p className="instructor__item--text">15/15</p>
              </div>
            </figure>

            <section className="instructor__item--wrapper">
              <figure className="instructor__item">
                <img
                  className="intructor__item--car"
                  alt="Auto"
                  src={NormalCar}
                />
                <div>
                  <figcaption className="instructor__item--title">
                    Auto:
                  </figcaption>
                  <p className="instructor__item--text">Golf VII GTI 2018</p>
                </div>
              </figure>
              <img
                className="instructor__item--preview"
                src={DisplayCar}
                alt="car"
              />
            </section>

            <figure className="instructor__item instructor__item--itinerary">
              <img
                className="instructor__item--calendar"
                alt="Kalendar"
                src={Calendar}
              />
              <div>
                <figcaption className="instructor__item--title">
                  Raspored:
                </figcaption>
              </div>
            </figure>
          </section>

          <section>
            <div className="instructor__item--schedule">
              <img
                className="intructor__item--arrow"
                alt="Strelica"
                src={HeaderArrow}
              />
              <h3 className="instructor__schedule--date">Srijeda,</h3>
              <p className="instructor__schedule--day">17. srpnja</p>
            </div>

            <button className="main__button main__button--schedule instructor__schedule--button">
              <div className="instructor__schedule--time">
                <h3>08:30</h3>
              </div>
              <span>
                <p className="button__info">Matija Luketin</p>
                <p className="button__info button__info--small">
                  Požeška 12, Split
                </p>
              </span>
            </button>

            <button className="main__button main__button--schedule instructor__schedule--button instructor__schedule--button--exam">
              <div className="instructor__schedule--time">
                <h3>10:15</h3>
              </div>
              <span>
                <p className="button__info">Nino Borović</p>
                <p className="button__info button__info--small">Ispit</p>
              </span>
            </button>

            <button className="main__button main__button--schedule instructor__schedule--button instructor__schedule--free">
              <div className="brc-blue instructor__schedule--time ">
                <h3>11:15</h3>
              </div>
              <p className="button__info">Slobodno</p>
              <img
                className="button__info--arrow button__garbage"
                alt="Strelica"
                src={HeaderArrow}
              />
            </button>
          </section>
        </main>

        {editModalVisibility ? (
          <InstructorEditModal onCloseEditModal={this.handleCloseEditModal} />
        ) : null}
      </React.Fragment>
    );
  }
}
