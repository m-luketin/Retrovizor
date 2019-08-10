import React, { Component } from "react";
// SVG import
import Profile from "../../../assets/Instructor.gif";
import HeaderArrow from "../../../assets/HeaderArrow.svg";
import FullCheckmark from "../../../assets/FullCheckmark.svg";
import OutlineCheckmark from "../../../assets/OutlineCheckmark.svg";
import { isUserValid } from "../../PrivateRoute";

export default class EventStudentsToAdd extends Component {
  componentDidMount() {
    isUserValid();
  }

  render() {
    return (
      <React.Fragment>
        <header>
          <img className="header__arrow" alt="Strelica" src={HeaderArrow} />
          <h1 className="header__title header__title--blue">Kandidati</h1>
        </header>

        <main>
          <input
            className="student__list--search"
            type="text"
            placeholder="Traži"
          />
          <section>
            <div className="student__list--wrapper">
              <img
                className="student__list--checkmark"
                alt="Oznaka"
                src={FullCheckmark}
              />
              <img src={Profile} alt="Kandidat" />
              <span className="main__button">
                <p className="student__list--name">Luka Nola</p>
              </span>
            </div>

            <div className="student__list--wrapper">
              <img
                className="student__list--checkmark"
                alt="Oznaka"
                src={OutlineCheckmark}
              />
              <img src={Profile} alt="Kandidat" />
              <span className="main__button">
                <p className="student__list--name">Luka Nola</p>
              </span>
            </div>
          </section>
        </main>
      </React.Fragment>
    );
  }
}
