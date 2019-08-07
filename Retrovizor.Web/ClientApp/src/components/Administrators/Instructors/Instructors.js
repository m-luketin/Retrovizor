import React, { Component } from "react";
import { Link } from "react-router-dom";
import "./Instructors.css";
// SVG import
import Profile from "../../../assets/Instructor.gif";
import InstructorAddModal from "./InstructorAddModal";
import GrayPlus from "../../../assets/GrayPlus.svg";
import FullStar from "../../../assets/FullStar.svg";
import OutlineStar from "../../../assets/OutlineStar.svg";

export default class Instructors extends Component {
  render() {
    return (
      <React.Fragment>
        <header className="header--instructors">
          <h1 className="header__title">Instruktori</h1>
          <img className="header__icon--plus" alt="Plus" src={GrayPlus} />
        </header>
        <main className="main__drive main__instructor--list">
          <section className="main__next--lesson--wrapper">
            <div className="main__driving">
              <img
                className="main__driving--instructor"
                src={Profile}
                alt="Instruktor"
              />

              <Link to="/administrator/instruktori/detalji">
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
              </Link>
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

          <InstructorAddModal />
        </main>
      </React.Fragment>
    );
  }
}
