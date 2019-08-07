import React, { Component } from "react";
import "./Schedule.css";
// SVG import
import Calendar from "../../../assets/Calendar.svg";

export default class Schedule extends Component {
  render() {
    return (
      <React.Fragment>
        <header className="header">
          <h1 className="header__title">Raspored</h1>
          <button>
            <img
              className="header__icon header__icon--calendar"
              alt="Kalendar"
              src={Calendar}
            />
          </button>
        </header>

        <main className="main">
          <button className="main__button main__button--schedule">
            <div>
              <span className="button__date">23</span>
              <br />
              <span className="button__month">STU</span>
            </div>
            <p className="button__info">14. sat prometnih propisa</p>
          </button>

          <button className="main__button main__button--schedule">
            <div>
              <span className="button__date">24</span>
              <br />
              <span className="button__month">STU</span>
            </div>
            <p className="button__info">15. sat prometnih propisa</p>
          </button>

          <button className="main__button main__button--schedule main__button--green">
            <div>
              <span className="button__date">04</span>
              <br />
              <span className="button__month">PRO</span>
            </div>
            <p className="button__info">Ispit iz prometnih propisa!</p>
          </button>
        </main>
      </React.Fragment>
    );
  }
}
