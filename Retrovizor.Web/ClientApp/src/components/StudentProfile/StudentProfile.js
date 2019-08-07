import React, { Component } from "react";
import { Link } from "react-router-dom";
import "../Common.css";
import "./StudentProfile.css";

export default class StudentProfile extends Component {
  render() {
    return (
      <React.Fragment>
        <header class="header">
          <h1 class="header__title">Profil</h1>
          <button>
            <Link to="/profil/postavke">
              <img
                src="./assets/images/settings.png"
                alt="Settings button"
                class="header__settings"
              />
            </Link>
          </button>
        </header>
        <main>
          <section class="main__profile">
            <figure>
              <img
                src="./assets/images/user.png"
                alt="User icon"
                class="profile__user-icon"
              />
              <figcaption>
                <h2 class="profile__name">Bok, Ana!</h2>
                <span class="profile__category">
                  <span class="profile__category--type">B</span>kategorija
                </span>
              </figcaption>
            </figure>
          </section>

          <section class="main__timeline">
            <h3 class="timeline__title">Vremenska crta:</h3>
            <figure class="timeline__item timeline__item--passed">
              <img
                src="./assets/images/checked.png"
                alt="Check mark"
                class="item__icon"
              />
              <figcaption>
                <h3 class="item__title">Prometni propisi</h3>
                <p class="item__status">15/15 sati</p>
              </figcaption>
            </figure>
            <figure class="timeline__item timeline__item--passed">
              <img
                src="./assets/images/checked.png"
                alt="Check mark"
                class="item__icon"
              />
              <figcaption>
                <h3 class="item__title">Ispit iz prometnih propisa</h3>
                <p class="item__status">118/120 bodova</p>
              </figcaption>
            </figure>
            <figure class="timeline__item timeline__item--passed">
              <img
                src="./assets/images/checked.png"
                alt="Check mark"
                class="item__icon"
              />
              <figcaption>
                <h3 class="item__title">Prva pomoć</h3>
                <p class="item__status">5/5 sati</p>
              </figcaption>
            </figure>
            <figure class="timeline__item timeline__item--warning">
              <img
                src="./assets/images/exclamation-mark.png"
                alt="Exclamation mark"
                class="item__icon"
              />
              <figcaption>
                <h3 class="item__title item__title--warning">
                  Ispit iz prve pomoći
                </h3>
                <p class="item__status item__status--warning">Nije položeno</p>
              </figcaption>
            </figure>
            <figure class="timeline__item timeline__item--waiting">
              <img
                src="./assets/images/sand-watch.png"
                alt="Waiting icon"
                class="item__icon"
              />
              <figcaption>
                <h3 class="item__title item__title--waiting">Vožnja</h3>
                <p class="item__status item__title--waiting">18/35 sati</p>
              </figcaption>
            </figure>
            <figure class="timeline__item timeline__item--waiting">
              <img
                src="./assets/images/sand-watch.png"
                alt="Waiting icon"
                class="item__icon"
              />
              <figcaption>
                <h3 class="item__title item__title--waiting">
                  Ispit iz vožnje
                </h3>
                <p class="item__status item__title--waiting">Na čekanju</p>
              </figcaption>
            </figure>
          </section>
        </main>
      </React.Fragment>
    );
  }
}