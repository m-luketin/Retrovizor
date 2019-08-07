import React, { Component } from "react";
import { Link } from "react-router-dom";
import "./Instructor.css";
// SVG import
import Profile from "../../../assets/Instructor.gif";
import HeaderArrow from "../../../assets/HeaderArrow.svg";
import FullStar from "../../../assets/FullStar.svg";
import OutlineStar from "../../../assets/OutlineStar.svg";

export default class InstructorList extends Component {
  render() {
    return (
      <React.Fragment>
        <header>
          <Link to="/kandidat/voznja">
            <img className="header__arrow" alt="Strelica" src={HeaderArrow} />
            <h1 className="header__title header__title--blue">Instruktori</h1>
          </Link>
        </header>
        <main className="main__drive main__instructor--list">
          <section className="main__next--lesson--wrapper">
            <div className="main__driving">
              <img
                className="main__driving--instructor"
                src={Profile}
                alt="Instruktor"
              />

              <button className="main__button main__button--schedule main__button--driving main__button--instructor">
                <span className="button__info">
                  <h3 className="instructor__name">Ivan Bartičević</h3>
                  <p className="instructor__car">Golf VII</p>
                  <div className="instructor__stars">
                    <img
                      className="instructor__star"
                      alt="Zvijezda"
                      src={FullStar}
                    />
                    <img
                      className="instructor__star"
                      alt="Zvijezda"
                      src={FullStar}
                    />
                    <img
                      className="instructor__star"
                      alt="Zvijezda"
                      src={FullStar}
                    />
                    <img
                      className="instructor__star"
                      alt="Zvijezda"
                      src={FullStar}
                    />
                    <img
                      className="instructor__star"
                      alt="Zvijezda"
                      src={OutlineStar}
                    />
                  </div>
                </span>
              </button>
            </div>

            <div className="main__driving">
              <img
                className="main__driving--instructor"
                src={Profile}
                alt="Instruktor"
              />

              <button className="main__button main__button--schedule main__button--driving main__button--instructor">
                <span className="button__info">
                  <h3 className="instructor__name">Ivan Bartičević</h3>
                  <p className="instructor__car">Golf VII</p>
                  <div className="instructor__stars">
                    <img
                      className="instructor__star"
                      alt="Zvijezda"
                      src={FullStar}
                    />
                    <img
                      className="instructor__star"
                      alt="Zvijezda"
                      src={FullStar}
                    />
                    <img
                      className="instructor__star"
                      alt="Zvijezda"
                      src={FullStar}
                    />
                    <img
                      className="instructor__star"
                      alt="Zvijezda"
                      src={FullStar}
                    />
                    <img
                      className="instructor__star"
                      alt="Zvijezda"
                      src={OutlineStar}
                    />
                  </div>
                </span>
              </button>
            </div>

            <div className="main__driving">
              <img
                className="main__driving--instructor"
                src={Profile}
                alt="Instruktor"
              />

              <button className="main__button main__button--schedule main__button--driving main__button--instructor">
                <span className="button__info">
                  <h3 className="instructor__name">Ivan Bartičević</h3>
                  <p className="instructor__car">Golf VII</p>
                  <div className="instructor__stars">
                    <img
                      className="instructor__star"
                      alt="Zvijezda"
                      src={FullStar}
                    />
                    <img
                      className="instructor__star"
                      alt="Zvijezda"
                      src={FullStar}
                    />
                    <img
                      className="instructor__star"
                      alt="Zvijezda"
                      src={FullStar}
                    />
                    <img
                      className="instructor__star"
                      alt="Zvijezda"
                      src={FullStar}
                    />
                    <img
                      className="instructor__star"
                      alt="Zvijezda"
                      src={OutlineStar}
                    />
                  </div>
                </span>
              </button>
            </div>

            <div className="main__driving">
              <img
                className="main__driving--instructor"
                src={Profile}
                alt="Instruktor"
              />

              <button className="main__button main__button--schedule main__button--driving main__button--instructor">
                <span className="button__info">
                  <h3 className="instructor__name">Ivan Bartičević</h3>
                  <p className="instructor__car">Golf VII</p>
                  <div className="instructor__stars">
                    <img
                      className="instructor__star"
                      alt="Zvijezda"
                      src={FullStar}
                    />
                    <img
                      className="instructor__star"
                      alt="Zvijezda"
                      src={FullStar}
                    />
                    <img
                      className="instructor__star"
                      alt="Zvijezda"
                      src={FullStar}
                    />
                    <img
                      className="instructor__star"
                      alt="Zvijezda"
                      src={FullStar}
                    />
                    <img
                      className="instructor__star"
                      alt="Zvijezda"
                      src={OutlineStar}
                    />
                  </div>
                </span>
              </button>
            </div>
          </section>
        </main>
      </React.Fragment>
    );
  }
}
