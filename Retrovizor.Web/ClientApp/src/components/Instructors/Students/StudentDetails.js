import React, { Component } from "react";
import { Link } from "react-router-dom";
// SVG import
import Profile from "../../../assets/Instructor.gif";
import Phone from "../../../assets/Phone.svg";
import HeaderArrow from "../../../assets/HeaderArrow.svg";
import Clock from "../../../assets/Clock.svg";
import Timeline from "../../../assets/Timeline.svg";
import FullCheckmark from "../../../assets/FullCheckmark.svg";
import RedExclimation from "../../../assets/RedExclimation.svg";
import Pending from "../../../assets/Pending.svg";

export default class StudentDetails extends Component {
  render() {
    return (
      <React.Fragment>
        <header className="header--instructors">
          <Link to="/administrator/kandidati">
            <img className="header__arrow" alt="Strelica" src={HeaderArrow} />
            <h1 className="header__title header__title--blue">Kandidat</h1>
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
                  <h3 className="instructor__name">Luka Nola</h3>
                  <span className="profile__category">
                    <span className="profile__category--type">B</span>kategorija
                  </span>
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
                  Kontakt
                </figcaption>
                <p className="instructor__item--text c-blue">+385 123123123</p>
              </div>
            </figure>

            <figure className="instructor__item">
              <img className="instructor__item--clock" alt="Sat" src={Clock} />
              <div>
                <figcaption className="instructor__item--title">Sat</figcaption>
                <p className="instructor__item--text">Golf VII GTI 2018</p>
              </div>
            </figure>
          </section>

          <section className="main__timeline main__student--timeline pl-8px">
            <div className="main__timeline--title">
              <img
                className="timeline__icon"
                alt="Vremenska crta"
                src={Timeline}
              />
              <h3 className="timeline__title">Vremenska crta:</h3>
            </div>
            <img className="item__icon" alt="Checkmark" src={FullCheckmark} />
            <figure className="timeline__item timeline__item--smaller timeline__item--passed">
              <figcaption>
                <h3 className="item__title">Prometni propisi</h3>
                <p className="item__status">15/15 sati</p>
              </figcaption>
            </figure>

            <img className="item__icon" alt="Checkmark" src={FullCheckmark} />
            <figure className="timeline__item timeline__item--smaller timeline__item--passed">
              <figcaption>
                <h3 className="item__title">Ispit iz prometnih propisa</h3>
                <p className="item__status">118/120 bodova</p>
              </figcaption>
            </figure>

            <img className="item__icon" alt="Checkmark" src={FullCheckmark} />
            <figure className="timeline__item timeline__item--smaller timeline__item--passed">
              <figcaption>
                <h3 className="item__title">Prva pomoć</h3>
                <p className="item__status">5/5 sati</p>
              </figcaption>
            </figure>

            <img className="item__icon" alt="Usklicnik" src={RedExclimation} />
            <figure className="timeline__item timeline__item--smaller timeline__item--warning">
              <figcaption>
                <h3 className="item__title item__title--warning">
                  Ispit iz prve pomoći
                </h3>
                <p className="item__status item__status--warning">
                  Nije položeno
                </p>
              </figcaption>
            </figure>

            <img className="item__icon" alt="PjescaniSat" src={Pending} />
            <figure className="timeline__item timeline__item--smaller timeline__item--waiting">
              <figcaption>
                <h3 className="item__title item__title--waiting">Vožnja</h3>
                <p className="item__status item__title--waiting">18/35 sati</p>
              </figcaption>
            </figure>
          </section>
        </main>
      </React.Fragment>
    );
  }
}
