import React, { Component } from "react";
// SVG import
import Profile from "../../../assets/Instructor.gif";

export default class DrivingWithLesson extends Component {
  render() {
    return (
      <main className="main__drive">
        <section className="main__map">{/* Map */}</section>
        <section className="main__next--lesson--wrapper">
          <h3 className="main__next--lesson">Sljedeći termin:</h3>
          <div className="main__driving">
            <img
              className="main__driving--instructor"
              src={Profile}
              alt="Instruktor"
            />

            <button className="main__button main__button--schedule main__button--driving">
              <div>
                <span className="button__date">24</span>
                <br />
                <span className="button__month">STU</span>
              </div>

              <span className="button__info">
                <h3>13:30</h3>
                <p>Požeška 12, Split</p>
              </span>
            </button>
          </div>
        </section>
      </main>
    );
  }
}
