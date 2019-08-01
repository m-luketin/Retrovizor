import React, { Component } from "react";
import { Link } from "react-router-dom";
import "../Common.css";
import "./MaterialsContent.css";

export default class FirstAid extends Component {
  render() {
    return (
      <React.Fragment>
        <header>
          <Link to="/materijali">
            <img
              class="header__arrow"
              src="./assets/images/ARROW-TEMP.png"
              alt="Arrow"
            />
            <h1 class="header__title">Prva pomoć</h1>
          </Link>
        </header>

        <main>
          <button class="main__button main__button--green">
            <img
              class="main__button--star"
              src="./assets/images/STAR-TEMP.png"
              alt="Star"
            />
            <h3 class="main__button--description">
              Probni ispit iz prve pomoći
            </h3>
            <img
              class="main__button--arrow"
              src="./assets/images/ARROW-TEMP.png"
              alt="Arrow"
            />
          </button>

          <button class="main__button">
            <h1 class="main__button--number">1.</h1>
            <h3 class="main__button--description">Lanac spašavanja</h3>
            <img
              class="main__button--arrow"
              src="./assets/images/ARROW-TEMP.png"
              alt="Arrow"
            />
          </button>

          <button class="main__button">
            <h1 class="main__button--number">2.</h1>
            <h3 class="main__button--description">
              Uklanjanje odjeće i obuće s umesrećenog
            </h3>
            <img
              class="main__button--arrow"
              src="./assets/images/ARROW-TEMP.png"
              alt="Arrow"
            />
          </button>

          <button class="main__button">
            <h1 class="main__button--number">3.</h1>
            <h3 class="main__button--description">Pružanje umjetnog disanja</h3>
            <img
              class="main__button--arrow"
              src="./assets/images/ARROW-TEMP.png"
              alt="Arrow"
            />
          </button>

          <button class="main__button">
            <h1 class="main__button--number">4.</h1>
            <h3 class="main__button--description">Opekline</h3>
            <img
              class="main__button--arrow"
              src="./assets/images/ARROW-TEMP.png"
              alt="Arrow"
            />
          </button>

          <button class="main__button">
            <h1 class="main__button--number">5.</h1>
            <h3 class="main__button--description">
              Pomoć pri gniječenim ozljedama
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
