import React, { Component } from "react";
import "../Common.css";
import "./Materials.css";

export default class Materials extends Component {
  render() {
    return (
      <React.Fragment>
        <header>
          <h1 class="header__title">Materijali</h1>
        </header>

        <main>
          <button class="main__button--big bc-blue">
            <div class="main__button--images">
              <img
                class="main__button--car"
                src="./assets/images/TEMP-ICON.jpg"
                alt="Vehicle"
              />
              <img
                class="main__button--bus"
                src="./assets/images/TEMP-ICON.jpg"
                alt="Vehicle"
              />
            </div>

            <div class="main__button--text">
              <h3>Prometni propisi</h3>
              <p>Pitanja i probni ispiti iz prometnih propisa</p>
            </div>

            <img
              class="main__button--arrow"
              src="./assets/images/ARROW-TEMP.png"
              alt="Arrow"
            />
          </button>

          <button class="main__button--big bc-red">
            <img
              class="main__button--images main__button--heart"
              src="./assets/images/HEART-TEMP.png"
              alt="Heart"
            />
            <div class="main__button--text">
              <h3>Prva pomoć</h3>
              <p>Pitanja i probni ispiti iz prve pomoći</p>
            </div>
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
