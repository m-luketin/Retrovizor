import React, { Component } from "react";
import "../Common.css";
import "./MaterialsContent.css";

export default class Regulations extends Component {
  render() {
    return (
      <React.Fragment>
        <header>
          <img
            class="header__arrow"
            src="./assets/images/ARROW-TEMP.png"
            alt="Arrow"
          />
          <h1 class="header__title">Prometni propisi</h1>
        </header>

        <main>
          <button class="main__button main__button--green">
            <img
              class="main__button--star"
              src="./assets/images/STAR-TEMP.png"
              alt="Star"
            />
            <h3 class="main__button--description">
              Probni ispit iz prometnih propisa
            </h3>
            <img
              class="main__button--arrow"
              src="./assets/images/ARROW-TEMP.png"
              alt="Arrow"
            />
          </button>

          <button class="main__button">
            <h1 class="main__button--number">1.</h1>
            <h3 class="main__button--description">
              Propisi u cestovnom prometu
            </h3>
            <img
              class="main__button--arrow"
              src="./assets/images/ARROW-TEMP.png"
              alt="Arrow"
            />
          </button>

          <button class="main__button">
            <h1 class="main__button--number">2.</h1>
            <h3 class="main__button--description">
              Ponašanje sudinika u prometu
            </h3>
            <img
              class="main__button--arrow"
              src="./assets/images/ARROW-TEMP.png"
              alt="Arrow"
            />
          </button>

          <button class="main__button">
            <h1 class="main__button--number">3.</h1>
            <h3 class="main__button--description">Cesta i njena obilježja</h3>
            <img
              class="main__button--arrow"
              src="./assets/images/ARROW-TEMP.png"
              alt="Arrow"
            />
          </button>

          <button class="main__button">
            <h1 class="main__button--number">4.</h1>
            <h3 class="main__button--description">Znakovi u prometu</h3>
            <img
              class="main__button--arrow"
              src="./assets/images/ARROW-TEMP.png"
              alt="Arrow"
            />
          </button>

          <button class="main__button">
            <h1 class="main__button--number">5.</h1>
            <h3 class="main__button--description">
              Ostali sudionici u cestovnom prometu
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
