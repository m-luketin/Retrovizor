import React, { Component } from "react";
import { Link } from "react-router-dom";
import "../Common.css";
import "./Settings.css";

export default class Settings extends Component {
  render() {
    return (
      <React.Fragment>
        <header>
          <Link to="/profil">
            <img
              class="header__arrow"
              src="./assets/images/ARROW-TEMP.png"
              alt="Arrow"
            />
            <h1 class="header__title header__title--blue">Postavke</h1>
          </Link>
        </header>

        <main>
          <button class="main__button">
            <img
              class="main__button--lock"
              src="./assets/images/STAR-TEMP.png"
              alt="Lock"
            />
            <h3 class="main__button--description">Privatnost</h3>
            <img
              class="main__button--arrow"
              src="./assets/images/ARROW-TEMP.png"
              alt="Arrow"
            />
          </button>

          <button class="main__button">
            <img
              class="main__button--bell"
              src="./assets/images/STAR-TEMP.png"
              alt="Bell"
            />
            <h3 class="main__button--description">Obavijesti</h3>
            <img
              class="main__button--arrow"
              src="./assets/images/ARROW-TEMP.png"
              alt="Arrow"
            />
          </button>

          <button class="main__button">
            <h3 class="main__button--description">Sigurnosti</h3>
            <img
              class="main__button--arrow"
              src="./assets/images/ARROW-TEMP.png"
              alt="Arrow"
            />
          </button>

          <button class="main__button">
            <img
              class="main__button--info"
              src="./assets/images/STAR-TEMP.png"
              alt="Information"
            />
            <h3 class="main__button--description">
              Uvijeti i pravila o zaštiti privatnosti
            </h3>
            <img
              class="main__button--arrow"
              src="./assets/images/ARROW-TEMP.png"
              alt="Arrow"
            />
          </button>
        </main>
      </React.Fragment>
    );
  }
}
