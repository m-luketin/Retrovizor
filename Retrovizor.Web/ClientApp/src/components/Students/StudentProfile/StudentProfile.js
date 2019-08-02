import React, { Component } from "react";
import { Link } from "react-router-dom";
import ProfileImg from "../../../assets/instructor.gif";
import "./StudentProfile.css";

export default class StudentProfile extends Component {
  render() {
    return (
      <React.Fragment>
        <header className="header">
          <h1 className="header__title">Profil</h1>
          <button>
            <Link to="/profil/postavke">
              <img
                className="bi x0 y0 w1 h1 header__settings"
                alt="Settings button"
                src="data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAACYAAAAmCAIAAAAnX375AAAACXBIWXMAABYlAAAWJQFJUiTwAAADeElEQVRYw7WY3UtaYRzHj6KQb5gej2EqimZ1pMWMMViDhKEEJeGIEXXTdjd2uf9kl9HNKNhYY2wXazdRENamLrVjVq4Xk2RWcxVRnmMdO+3iDKfP8bzY9Hvnw/M8n+c8v9dH0c3NDSRYFEWFovHlcIz+qZDLxoZ9apUSqkXimmanM9kSD4KgPE68+fAZqlG1ITe2doGRPE6cnV80CklRVHI7xRxPpTM1ISXModja5s7ePk4Qnr5eo0FPD5JkMRCKVN0iGMH0Orh85gqWWE0kzUaDqwstjZckAtzn28pqubU6HTa71XxwlIvGN7jPjsCabmcHfYI8TpTGRx8PAtQKZGxtcz4QhOqtF89G5bKm6rbc2duHGiC87KNBJE4QjUBeXpGsSE9fb915CKwBbFmBNBr0nQ5bfZH+AQ9PXNqt5voimekQjMuDoxz3Fg/vu1oQHaxtJq/I3MlpOBrPHZ9y+Q5RKHdXEEmSRY74s5haB73u8vU6WIM6bJvbqdm5RbZV2Hrywb271S+Woii2/ELzngz1A+elhTpsT0f8bAuXwzEgCYuur6/TmezG1m7V/MkWzkwtLIU4bgiBNe12q7OjTa1Sir5+j5VnODb7AZfDFEkWX01Oc89RyGXjI34xLw+CoBZExztHKpUo5DLuOXmcCEYwQcUL1jYLmWY2GviTH1EQhCQrM9Z/Ssx7GxAE5U5OhezF7YClVCMeG/bxUsPROO9ev4/5j9XT7UQdtr/18uz8IpXOANW1XINeN8qefimKmpiaYVvb6bC5ulC9TiuVSv6lArVK6bqDDvU/Ytt0dm6R7TsoivoyH2DjIbDG53UbDXqaV6WSILCGjfr63aeFpRBJFoH7nJia4bAisyCCvY+QXkQhl9HxIMRfXj4fF4vFPB0er/I4IQQmqI8lyWIwgtW3XmLrP7iQK1iCzQturflAEDB/BXI1kWxEu5XJHrIihSTJWwhI0RVIVxdad57F1KpSyLmC5OfBr7cfZ0tR7B/wqFVKnChg60mOMofAGk9fr6FFR/tLKcwsptZhnxcIEhHzSYsTBRwnLq9IoP88O7+YnH5fNZ/5vG7A8zPZQ1jbrFLIAV71uJTLmqr2HGqVEoE1zH6OaQ6pVGKzmOrzpG23W5mDep22ga9oZ0cbUOl6up2lfC1Qopr+nqAtHYxgOFGg6y1a+4PiD8kGeYAymJKbAAAAAElFTkSuQmCC"
              />
            </Link>
          </button>
        </header>
        <main>
          <section className="main__profile">
            <figure>
              <div className="profile__image--wrapper">
                <img
                  src={ProfileImg}
                  alt="User icon"
                  className="profile__user-icon"
                />
                <span className="profile__user--edit--wrapper">
                  <svg
                    className="profile__user--edit"
                    xmlns="http://www.w3.org/2000/svg"
                    width="21px"
                    height="21px"
                    viewBox="0 0 21 21"
                    version="1.1"
                  >
                    <g
                      id="Symbols"
                      stroke="none"
                      strokeWidth="1"
                      fill="none"
                      fillRule="evenodd"
                    >
                      <g
                        id="Budicon-Solid/Writing/pen"
                        transform="translate(-2.000000, -2.000000)"
                        fill="#8B959E"
                        fillRule="nonzero"
                      >
                        <path
                          d="M22.561306,7.38870942 L21.500006,8.44970942 L16.550006,3.49970942 L17.611006,2.43870942 C18.1971324,1.85376353 19.1461796,1.85376353 19.732306,2.43870942 L22.560706,5.26730942 C23.1460494,5.85321348 23.1463179,6.80247434 22.561306,7.38870942 Z M2.43900597,17.6118094 C2.15695008,17.8925593 1.99888072,18.2744462 2,18.6724094 L2,22.0005094 C2.00039205,22.5526342 2.44788122,23.0001233 3,23.0005163 L6.32800597,23.0005163 C6.72601482,23.0017172 7.10796335,22.8436372 7.38870597,22.5615094 L20.793206,9.15680942 L15.843206,4.20680942 L2.43900597,17.6118094 Z"
                          id="Shape"
                        />
                      </g>
                    </g>
                  </svg>
                </span>
              </div>
              <figcaption>
                <h2 className="profile__name">Bok, Ana!</h2>
                <span className="profile__category">
                  <span className="profile__category--type">B</span>kategorija
                </span>
              </figcaption>
            </figure>
          </section>

          <section className="main__timeline">
            <div className="main__timeline--title">
              <svg
                xmlns="http://www.w3.org/2000/svg"
                width="25px"
                height="21px"
                viewBox="0 0 25 21"
                version="1.1"
              >
                <g
                  id="Symbols"
                  stroke="none"
                  strokeWidth="1"
                  fill="none"
                  fillRule="evenodd"
                >
                  <g
                    id="Budicon-Solid/Interface/card-slides"
                    transform="translate(0.000000, -2.000000)"
                    fill="#8B959E"
                    fillRule="nonzero"
                  >
                    <path
                      d="M25,3.5 L25,12.5 C25,13.3284271 24.3284271,14 23.5,14 L1.5,14 C0.671572875,14 0,13.3284271 0,12.5 L0,3.5 C0,2.67157288 0.671572875,2 1.5,2 L23.5,2 C24.3284271,2 25,2.67157288 25,3.5 Z M22.5,16 L2.5,16 C2.22385763,16 2,16.2238576 2,16.5 C2,16.7761424 2.22385763,17 2.5,17 L22.5,17 C22.7761424,17 23,16.7761424 23,16.5 C23,16.2238576 22.7761424,16 22.5,16 Z M20.5,19 L4.5,19 C4.22385763,19 4,19.2238576 4,19.5 C4,19.7761424 4.22385763,20 4.5,20 L20.5,20 C20.7761424,20 21,19.7761424 21,19.5 C21,19.2238576 20.7761424,19 20.5,19 Z M18.5,22 L6.5,22 C6.22385763,22 6,22.2238576 6,22.5 C6,22.7761424 6.22385763,23 6.5,23 L18.5,23 C18.7761424,23 19,22.7761424 19,22.5 C19,22.2238576 18.7761424,22 18.5,22 Z"
                      id="Shape"
                    />
                  </g>
                </g>
              </svg>
              <h3 className="timeline__title">Vremenska crta:</h3>
            </div>
            <svg
              className="item__icon"
              xmlns="http://www.w3.org/2000/svg"
              width="25px"
              height="25px"
              viewBox="0 0 25 25"
              version="1.1"
            >
              <g
                id="Symbols"
                stroke="none"
                strokeWidth="1"
                fill="none"
                fillRule="evenodd"
              >
                <g
                  id="Budicon-Solid/Interface/tick-sign"
                  fill="#A8E063"
                  fillRule="nonzero"
                >
                  <path
                    d="M12.5,0 C5.59644063,0 0,5.59644063 0,12.5 C0,19.4035594 5.59644063,25 12.5,25 C19.4035594,25 25,19.4035594 25,12.5 C25,9.18479388 23.6830395,6.00536997 21.3388348,3.66116524 C18.99463,1.3169605 15.8152061,0 12.5,0 Z M17.8643,9.8428 L12.2178,15.8428 C12.0312661,16.0409287 11.7205359,16.0535054 11.5186,15.8711 L8.165,12.8462 C8.02918063,12.7273529 7.9679488,12.5445357 8.0047872,12.3678596 C8.04162559,12.1911835 8.1708164,12.0480709 8.34281436,11.9934062 C8.51481232,11.9387415 8.70292105,11.9810095 8.835,12.104 L11.825,14.8008 L17.136,9.1572 C17.2584528,9.027066 17.4410295,8.972145 17.6149552,9.01312522 C17.788881,9.05410544 17.9277323,9.18476101 17.9792052,9.35587523 C18.0306782,9.52698946 17.9869528,9.71256601 17.8645,9.8427 L17.8643,9.8428 Z"
                    id="Shape"
                  />
                </g>
              </g>
            </svg>
            <figure className="timeline__item timeline__item--passed">
              <figcaption>
                <h3 className="item__title">Prometni propisi</h3>
                <p className="item__status">15/15 sati</p>
              </figcaption>
            </figure>

            <svg
              className="item__icon"
              xmlns="http://www.w3.org/2000/svg"
              width="25px"
              height="25px"
              viewBox="0 0 25 25"
              version="1.1"
            >
              <g
                id="Symbols"
                stroke="none"
                strokeWidth="1"
                fill="none"
                fillRule="evenodd"
              >
                <g
                  id="Budicon-Solid/Interface/tick-sign"
                  fill="#A8E063"
                  fillRule="nonzero"
                >
                  <path
                    d="M12.5,0 C5.59644063,0 0,5.59644063 0,12.5 C0,19.4035594 5.59644063,25 12.5,25 C19.4035594,25 25,19.4035594 25,12.5 C25,9.18479388 23.6830395,6.00536997 21.3388348,3.66116524 C18.99463,1.3169605 15.8152061,0 12.5,0 Z M17.8643,9.8428 L12.2178,15.8428 C12.0312661,16.0409287 11.7205359,16.0535054 11.5186,15.8711 L8.165,12.8462 C8.02918063,12.7273529 7.9679488,12.5445357 8.0047872,12.3678596 C8.04162559,12.1911835 8.1708164,12.0480709 8.34281436,11.9934062 C8.51481232,11.9387415 8.70292105,11.9810095 8.835,12.104 L11.825,14.8008 L17.136,9.1572 C17.2584528,9.027066 17.4410295,8.972145 17.6149552,9.01312522 C17.788881,9.05410544 17.9277323,9.18476101 17.9792052,9.35587523 C18.0306782,9.52698946 17.9869528,9.71256601 17.8645,9.8427 L17.8643,9.8428 Z"
                    id="Shape"
                  />
                </g>
              </g>
            </svg>
            <figure className="timeline__item timeline__item--passed">
              <figcaption>
                <h3 className="item__title">Ispit iz prometnih propisa</h3>
                <p className="item__status">118/120 bodova</p>
              </figcaption>
            </figure>

            <svg
              className="item__icon"
              xmlns="http://www.w3.org/2000/svg"
              width="25px"
              height="25px"
              viewBox="0 0 25 25"
              version="1.1"
            >
              <g
                id="Symbols"
                stroke="none"
                strokeWidth="1"
                fill="none"
                fillRule="evenodd"
              >
                <g
                  id="Budicon-Solid/Interface/tick-sign"
                  fill="#A8E063"
                  fillRule="nonzero"
                >
                  <path
                    d="M12.5,0 C5.59644063,0 0,5.59644063 0,12.5 C0,19.4035594 5.59644063,25 12.5,25 C19.4035594,25 25,19.4035594 25,12.5 C25,9.18479388 23.6830395,6.00536997 21.3388348,3.66116524 C18.99463,1.3169605 15.8152061,0 12.5,0 Z M17.8643,9.8428 L12.2178,15.8428 C12.0312661,16.0409287 11.7205359,16.0535054 11.5186,15.8711 L8.165,12.8462 C8.02918063,12.7273529 7.9679488,12.5445357 8.0047872,12.3678596 C8.04162559,12.1911835 8.1708164,12.0480709 8.34281436,11.9934062 C8.51481232,11.9387415 8.70292105,11.9810095 8.835,12.104 L11.825,14.8008 L17.136,9.1572 C17.2584528,9.027066 17.4410295,8.972145 17.6149552,9.01312522 C17.788881,9.05410544 17.9277323,9.18476101 17.9792052,9.35587523 C18.0306782,9.52698946 17.9869528,9.71256601 17.8645,9.8427 L17.8643,9.8428 Z"
                    id="Shape"
                  />
                </g>
              </g>
            </svg>
            <figure className="timeline__item timeline__item--passed">
              <figcaption>
                <h3 className="item__title">Prva pomoć</h3>
                <p className="item__status">5/5 sati</p>
              </figcaption>
            </figure>

            <svg
              className="item__icon"
              xmlns="http://www.w3.org/2000/svg"
              width="25px"
              height="25px"
              viewBox="0 0 25 25"
              version="1.1"
            >
              <g
                id="Symbols"
                stroke="none"
                strokeWidth="1"
                fill="none"
                fillRule="evenodd"
              >
                <g
                  id="Budicon-Solid/Interface/alert-sign"
                  fill="#FF416C"
                  fillRule="nonzero"
                >
                  <path
                    d="M12.5,0 C5.59644063,0 0,5.59644063 0,12.5 C0,19.4035594 5.59644063,25 12.5,25 C19.4035594,25 25,19.4035594 25,12.5 C25,9.18479388 23.6830395,6.00536997 21.3388348,3.66116524 C18.99463,1.3169605 15.8152061,0 12.5,0 Z M13,17 L12,17 L12,16 L13,16 L13,17 Z M13,14 L12,14 L12,8 L13,8 L13,14 Z"
                    id="Shape"
                  />
                </g>
              </g>
            </svg>
            <figure className="timeline__item timeline__item--warning">
              <figcaption>
                <h3 className="item__title item__title--warning">
                  Ispit iz prve pomoći
                </h3>
                <p className="item__status item__status--warning">
                  Nije položeno
                </p>
              </figcaption>
            </figure>

            <svg
              className="item__icon"
              xmlns="http://www.w3.org/2000/svg"
              width="25px"
              height="25px"
              viewBox="0 0 25 25"
              version="1.1"
            >
              <g
                id="Symbols"
                stroke="none"
                strokeWidth="1"
                fill="none"
                fillRule="evenodd"
              >
                <g
                  id="Budicon-Outline/Interface/tick-sign"
                  fill="#1488CC"
                  fillRule="nonzero"
                >
                  <path
                    d="M25,12.5 C25,19.4035594 19.4035594,25 12.5,25 C5.59644063,25 0,19.4035594 0,12.5 C0,5.59644063 5.59644063,0 12.5,0 C15.8152061,0 18.99463,1.3169605 21.3388348,3.66116524 C23.6830395,6.00536997 25,9.18479388 25,12.5 Z M17.9,19.4 L17,19.4 L17,16.7 C16.9990091,14.8352189 15.8473823,13.1644649 14.105,12.5 C15.8473823,11.8355351 16.9990091,10.1647811 17,8.3 L17,5.6 L17.9,5.6 C18.0656854,5.6 18.2,5.46568542 18.2,5.3 C18.2,5.13431458 18.0656854,5 17.9,5 L7.1,5 C6.93431458,5 6.8,5.13431458 6.8,5.3 C6.8,5.46568542 6.93431458,5.6 7.1,5.6 L8,5.6 L8,8.3 C8.0009909,10.1647811 9.15261771,11.8355351 10.895,12.5 C9.15261771,13.1644649 8.0009909,14.8352189 8,16.7 L8,19.4 L7.1,19.4 C6.93431458,19.4 6.8,19.5343146 6.8,19.7 C6.8,19.8656854 6.93431458,20 7.1,20 L17.9,20 C18.0656854,20 18.2,19.8656854 18.2,19.7 C18.2,19.5343146 18.0656854,19.4 17.9,19.4 Z M8.6,8.3 L8.6,5.6 L16.4,5.6 L16.4,8.3 C16.4,10.4539105 14.6539105,12.2 12.5,12.2 C10.3460895,12.2 8.6,10.4539105 8.6,8.3 Z M12.5,12.8 C14.4200857,12.8033903 16.0524457,14.2029413 16.34894,16.1 L8.65106,16.1 C8.94755432,14.2029413 10.5799143,12.8033903 12.5,12.8 Z M16.4,19.4 L8.6,19.4 L8.6,16.7 L16.4,16.7 L16.4,19.4 Z"
                    id="Combined-Shape"
                  />
                </g>
              </g>
            </svg>
            <figure className="timeline__item timeline__item--waiting">
              <figcaption>
                <h3 className="item__title item__title--waiting">Vožnja</h3>
                <p className="item__status item__title--waiting">18/35 sati</p>
              </figcaption>
            </figure>
          </section>
        </main>
      </React.Fragment>
    );
  }
}
