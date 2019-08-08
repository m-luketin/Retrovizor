import React, { Component } from "react";
import { Link } from "react-router-dom";
// SVG import
import Profile from "../../../assets/instructor.gif";
import WhiteArrow from "../../../assets/WhiteArrow.svg";

export default class StudentList extends Component {
  render() {
    return (
      <React.Fragment>
        <header className="header">
          <h1 className="header__title">Kandidati</h1>
        </header>
        <main className="main">
          <Link to="/instruktor/kandidati/kandidat">
            <figure className="main__candidate">
              <img className="candidate__icon" src={Profile} alt="Kandidat" />
              <figcaption>
                <h2 className="candidate__name">Luka Bendić</h2>
                <p className="candidate__lessons">12/35 sati</p>
                <img
                  className="main__button--arrow"
                  alt="Strelica"
                  src={WhiteArrow}
                />
              </figcaption>
            </figure>
          </Link>

          <figure className="main__candidate">
            <img className="candidate__icon" src={Profile} alt="Kandidat" />
            <figcaption>
              <h2 className="candidate__name">Luka Bendić</h2>
              <p className="candidate__lessons">12/35 sati</p>
              <img
                className="main__button--arrow"
                alt="Strelica"
                src={WhiteArrow}
              />
            </figcaption>
          </figure>

          <figure className="main__candidate">
            <img className="candidate__icon" src={Profile} alt="Kandidat" />
            <figcaption>
              <h2 className="candidate__name">Luka Bendić</h2>
              <p className="candidate__lessons">12/35 sati</p>
              <img
                className="main__button--arrow"
                alt="Strelica"
                src={WhiteArrow}
              />
            </figcaption>
          </figure>

          <figure className="main__candidate">
            <img className="candidate__icon" src={Profile} alt="Kandidat" />
            <figcaption>
              <h2 className="candidate__name">Luka Bendić</h2>
              <p className="candidate__lessons">12/35 sati</p>
              <img
                className="main__button--arrow"
                alt="Strelica"
                src={WhiteArrow}
              />
            </figcaption>
          </figure>

          <figure className="main__candidate">
            <img className="candidate__icon" src={Profile} alt="Kandidat" />
            <figcaption>
              <h2 className="candidate__name">Luka Bendić</h2>
              <p className="candidate__lessons">12/35 sati</p>
              <img
                className="main__button--arrow"
                alt="Strelica"
                src={WhiteArrow}
              />
            </figcaption>
          </figure>

          <figure className="main__candidate">
            <img className="candidate__icon" src={Profile} alt="Kandidat" />
            <figcaption>
              <h2 className="candidate__name">Luka Bendić</h2>
              <p className="candidate__lessons">12/35 sati</p>
              <img
                className="main__button--arrow"
                alt="Strelica"
                src={WhiteArrow}
              />
            </figcaption>
          </figure>
        </main>
      </React.Fragment>
    );
  }
}
