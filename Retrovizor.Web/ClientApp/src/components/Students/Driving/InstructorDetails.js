import React, { Component } from "react";
import { Link } from "react-router-dom";
import "./Instructor.css";
// SVG import
import Profile from "../../../assets/Instructor.gif";
import DisplayCar from "../../../assets/DisplayCar.png";
import Phone from "../../../assets/Phone.svg";
import HeaderArrow from "../../../assets/HeaderArrow.svg";
import Calendar from "../../../assets/Calendar.svg";
import NormalCar from "../../../assets/NormalCar.svg";
import People from "../../../assets/People.svg";
import Garbage from "../../../assets/Garbage.svg";

export default class InstructorDetails extends Component {
  render() {
    return (
      <React.Fragment>
        <header>
          <Link to="/kandidat/voznja">
            <img className="header__arrow" alt="Strelica" src={HeaderArrow} />
            <h1 className="header__title header__title--blue">Instruktor</h1>
          </Link>
        </header>
        <main className="main__drive main__instructor">
          <section className="main__next--lesson--wrapper">
            <div className="main__driving mb-20px">
              <img
                className="main__driving--instructor"
                src={Profile}
                alt="Instruktor"
              />

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

            <button className="main__button main__button--schedule instructor__schedule--button instructor__schedule--taken">
              <div className="instructor__schedule--time">
                <h3>08:30</h3>
              </div>
              <p className="button__info">Zauzeto</p>
            </button>

            <button className="main__button main__button--schedule instructor__schedule--button ">
              <div className="instructor__schedule--time">
                <h3>10:15</h3>
              </div>
              <p className="button__info">Rezervirano</p>
              <img className="button__garbage" alt="Brisi" src={Garbage} />
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
      </React.Fragment>
    );
  }
}
