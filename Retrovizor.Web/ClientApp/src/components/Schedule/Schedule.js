import React, { Component } from "react";
import "../Common.css";
import "./Schedule.css";

export default class Schedule extends Component {
  render() {
    return (
      <React.Fragment>
        <header class="header">
          <h1 class="header__title">Raspored</h1>
          <button>
            <img
              src="./assets/images/calendar.png"
              alt="Calendar icon"
              class="header__icon"
            />
          </button>
        </header>

        <main class="main">
          <button class="main__button main__button--schedule">
            <div>
              <span class="button__date">23</span>
              <br />
              <span class="button__month">STU</span>
            </div>
            <p class="button__info">14. sat prometnih propisa</p>
          </button>

          <button class="main__button main__button--schedule">
            <div>
              <span class="button__date">24</span>
              <br />
              <span class="button__month">STU</span>
            </div>
            <p class="button__info">15. sat prometnih propisa</p>
          </button>

          <button class="main__button main__button--schedule main__button--green">
            <div>
              <span class="button__date">04</span>
              <br />
              <span class="button__month">PRO</span>
            </div>
            <p class="button__info">Ispit iz prometnih propisa!</p>
          </button>
        </main>
      </React.Fragment>
    );
  }
}
