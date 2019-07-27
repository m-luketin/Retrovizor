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
                class="bi x0 y0 w1 h1 header__settings"
                alt="Settings button"
                src="data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAACYAAAAmCAIAAAAnX375AAAACXBIWXMAABYlAAAWJQFJUiTwAAADeElEQVRYw7WY3UtaYRzHj6KQb5gej2EqimZ1pMWMMViDhKEEJeGIEXXTdjd2uf9kl9HNKNhYY2wXazdRENamLrVjVq4Xk2RWcxVRnmMdO+3iDKfP8bzY9Hvnw/M8n+c8v9dH0c3NDSRYFEWFovHlcIz+qZDLxoZ9apUSqkXimmanM9kSD4KgPE68+fAZqlG1ITe2doGRPE6cnV80CklRVHI7xRxPpTM1ISXModja5s7ePk4Qnr5eo0FPD5JkMRCKVN0iGMH0Orh85gqWWE0kzUaDqwstjZckAtzn28pqubU6HTa71XxwlIvGN7jPjsCabmcHfYI8TpTGRx8PAtQKZGxtcz4QhOqtF89G5bKm6rbc2duHGiC87KNBJE4QjUBeXpGsSE9fb915CKwBbFmBNBr0nQ5bfZH+AQ9PXNqt5voimekQjMuDoxz3Fg/vu1oQHaxtJq/I3MlpOBrPHZ9y+Q5RKHdXEEmSRY74s5haB73u8vU6WIM6bJvbqdm5RbZV2Hrywb271S+Woii2/ELzngz1A+elhTpsT0f8bAuXwzEgCYuur6/TmezG1m7V/MkWzkwtLIU4bgiBNe12q7OjTa1Sir5+j5VnODb7AZfDFEkWX01Oc89RyGXjI34xLw+CoBZExztHKpUo5DLuOXmcCEYwQcUL1jYLmWY2GviTH1EQhCQrM9Z/Ssx7GxAE5U5OhezF7YClVCMeG/bxUsPROO9ev4/5j9XT7UQdtr/18uz8IpXOANW1XINeN8qefimKmpiaYVvb6bC5ulC9TiuVSv6lArVK6bqDDvU/Ytt0dm6R7TsoivoyH2DjIbDG53UbDXqaV6WSILCGjfr63aeFpRBJFoH7nJia4bAisyCCvY+QXkQhl9HxIMRfXj4fF4vFPB0er/I4IQQmqI8lyWIwgtW3XmLrP7iQK1iCzQturflAEDB/BXI1kWxEu5XJHrIihSTJWwhI0RVIVxdad57F1KpSyLmC5OfBr7cfZ0tR7B/wqFVKnChg60mOMofAGk9fr6FFR/tLKcwsptZhnxcIEhHzSYsTBRwnLq9IoP88O7+YnH5fNZ/5vG7A8zPZQ1jbrFLIAV71uJTLmqr2HGqVEoE1zH6OaQ6pVGKzmOrzpG23W5mDep22ga9oZ0cbUOl6up2lfC1Qopr+nqAtHYxgOFGg6y1a+4PiD8kGeYAymJKbAAAAAElFTkSuQmCC"
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
