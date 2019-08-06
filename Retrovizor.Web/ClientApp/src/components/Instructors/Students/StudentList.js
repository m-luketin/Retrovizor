import React, { Component } from "react";
import { Link } from "react-router-dom";
import profileImg from "../../../assets/instructor.gif";

export default class StudentList extends Component {
  render() {
    return (
      <React.Fragment>
        <header className="header">
          <h1 className="header__title">Kandidati</h1>
        </header>
        <main className="main">
          <Link to="/instruktor/kandidati/kandidat">
            <figure className="main__candidate">
              <img
                className="candidate__icon"
                src={profileImg}
                alt="Kandidat"
              />
              <figcaption>
                <h2 className="candidate__name">Luka Bendić</h2>
                <p className="candidate__lessons">12/35 sati</p>
                <svg
                  className="main__button--arrow"
                  xmlns="http://www.w3.org/2000/svg"
                  width="14px"
                  height="26px"
                  viewBox="0 0 14 26"
                  version="1.1"
                >
                  <g
                    id="Polaznik"
                    stroke="none"
                    strokeWidth="1"
                    fill="none"
                    fillRule="evenodd"
                    strokeLinecap="round"
                    strokeLinejoin="round"
                  >
                    <g
                      id="Propisi"
                      transform="translate(-363.000000, -137.000000)"
                      stroke="#FFFFFF"
                      strokeWidth="3"
                    >
                      <g
                        transform="translate(17.000000, 113.000000)"
                        id="Group-5"
                      >
                        <g transform="translate(66.000000, 10.000000)">
                          <polyline
                            id="Path"
                            transform="translate(281.606602, 27.000000) rotate(-135.000000) translate(-281.606602, -27.000000) "
                            points="274.106602 19.5 274.106602 34.5 289.106602 34.5"
                          />
                        </g>
                      </g>
                    </g>
                  </g>
                </svg>
              </figcaption>
            </figure>
          </Link>

          <figure className="main__candidate">
            <img className="candidate__icon" src={profileImg} alt="Kandidat" />
            <figcaption>
              <h2 className="candidate__name">Luka Bendić</h2>
              <p className="candidate__lessons">12/35 sati</p>
              <svg
                className="main__button--arrow"
                xmlns="http://www.w3.org/2000/svg"
                width="14px"
                height="26px"
                viewBox="0 0 14 26"
                version="1.1"
              >
                <g
                  id="Polaznik"
                  stroke="none"
                  strokeWidth="1"
                  fill="none"
                  fillRule="evenodd"
                  strokeLinecap="round"
                  strokeLinejoin="round"
                >
                  <g
                    id="Propisi"
                    transform="translate(-363.000000, -137.000000)"
                    stroke="#FFFFFF"
                    strokeWidth="3"
                  >
                    <g
                      transform="translate(17.000000, 113.000000)"
                      id="Group-5"
                    >
                      <g transform="translate(66.000000, 10.000000)">
                        <polyline
                          id="Path"
                          transform="translate(281.606602, 27.000000) rotate(-135.000000) translate(-281.606602, -27.000000) "
                          points="274.106602 19.5 274.106602 34.5 289.106602 34.5"
                        />
                      </g>
                    </g>
                  </g>
                </g>
              </svg>
            </figcaption>
          </figure>

          <figure className="main__candidate">
            <img className="candidate__icon" src={profileImg} alt="Kandidat" />
            <figcaption>
              <h2 className="candidate__name">Luka Bendić</h2>
              <p className="candidate__lessons">12/35 sati</p>
              <svg
                className="main__button--arrow"
                xmlns="http://www.w3.org/2000/svg"
                width="14px"
                height="26px"
                viewBox="0 0 14 26"
                version="1.1"
              >
                <g
                  id="Polaznik"
                  stroke="none"
                  strokeWidth="1"
                  fill="none"
                  fillRule="evenodd"
                  strokeLinecap="round"
                  strokeLinejoin="round"
                >
                  <g
                    id="Propisi"
                    transform="translate(-363.000000, -137.000000)"
                    stroke="#FFFFFF"
                    strokeWidth="3"
                  >
                    <g
                      transform="translate(17.000000, 113.000000)"
                      id="Group-5"
                    >
                      <g transform="translate(66.000000, 10.000000)">
                        <polyline
                          id="Path"
                          transform="translate(281.606602, 27.000000) rotate(-135.000000) translate(-281.606602, -27.000000) "
                          points="274.106602 19.5 274.106602 34.5 289.106602 34.5"
                        />
                      </g>
                    </g>
                  </g>
                </g>
              </svg>
            </figcaption>
          </figure>

          <figure className="main__candidate">
            <img className="candidate__icon" src={profileImg} alt="Kandidat" />
            <figcaption>
              <h2 className="candidate__name">Luka Bendić</h2>
              <p className="candidate__lessons">12/35 sati</p>
              <svg
                className="main__button--arrow"
                xmlns="http://www.w3.org/2000/svg"
                width="14px"
                height="26px"
                viewBox="0 0 14 26"
                version="1.1"
              >
                <g
                  id="Polaznik"
                  stroke="none"
                  strokeWidth="1"
                  fill="none"
                  fillRule="evenodd"
                  strokeLinecap="round"
                  strokeLinejoin="round"
                >
                  <g
                    id="Propisi"
                    transform="translate(-363.000000, -137.000000)"
                    stroke="#FFFFFF"
                    strokeWidth="3"
                  >
                    <g
                      transform="translate(17.000000, 113.000000)"
                      id="Group-5"
                    >
                      <g transform="translate(66.000000, 10.000000)">
                        <polyline
                          id="Path"
                          transform="translate(281.606602, 27.000000) rotate(-135.000000) translate(-281.606602, -27.000000) "
                          points="274.106602 19.5 274.106602 34.5 289.106602 34.5"
                        />
                      </g>
                    </g>
                  </g>
                </g>
              </svg>
            </figcaption>
          </figure>

          <figure className="main__candidate">
            <img className="candidate__icon" src={profileImg} alt="Kandidat" />
            <figcaption>
              <h2 className="candidate__name">Luka Bendić</h2>
              <p className="candidate__lessons">12/35 sati</p>
              <svg
                className="main__button--arrow"
                xmlns="http://www.w3.org/2000/svg"
                width="14px"
                height="26px"
                viewBox="0 0 14 26"
                version="1.1"
              >
                <g
                  id="Polaznik"
                  stroke="none"
                  strokeWidth="1"
                  fill="none"
                  fillRule="evenodd"
                  strokeLinecap="round"
                  strokeLinejoin="round"
                >
                  <g
                    id="Propisi"
                    transform="translate(-363.000000, -137.000000)"
                    stroke="#FFFFFF"
                    strokeWidth="3"
                  >
                    <g
                      transform="translate(17.000000, 113.000000)"
                      id="Group-5"
                    >
                      <g transform="translate(66.000000, 10.000000)">
                        <polyline
                          id="Path"
                          transform="translate(281.606602, 27.000000) rotate(-135.000000) translate(-281.606602, -27.000000) "
                          points="274.106602 19.5 274.106602 34.5 289.106602 34.5"
                        />
                      </g>
                    </g>
                  </g>
                </g>
              </svg>
            </figcaption>
          </figure>

          <figure className="main__candidate">
            <img className="candidate__icon" src={profileImg} alt="Kandidat" />
            <figcaption>
              <h2 className="candidate__name">Luka Bendić</h2>
              <p className="candidate__lessons">12/35 sati</p>
              <svg
                className="main__button--arrow"
                xmlns="http://www.w3.org/2000/svg"
                width="14px"
                height="26px"
                viewBox="0 0 14 26"
                version="1.1"
              >
                <g
                  id="Polaznik"
                  stroke="none"
                  strokeWidth="1"
                  fill="none"
                  fillRule="evenodd"
                  strokeLinecap="round"
                  strokeLinejoin="round"
                >
                  <g
                    id="Propisi"
                    transform="translate(-363.000000, -137.000000)"
                    stroke="#FFFFFF"
                    strokeWidth="3"
                  >
                    <g
                      transform="translate(17.000000, 113.000000)"
                      id="Group-5"
                    >
                      <g transform="translate(66.000000, 10.000000)">
                        <polyline
                          id="Path"
                          transform="translate(281.606602, 27.000000) rotate(-135.000000) translate(-281.606602, -27.000000) "
                          points="274.106602 19.5 274.106602 34.5 289.106602 34.5"
                        />
                      </g>
                    </g>
                  </g>
                </g>
              </svg>
            </figcaption>
          </figure>
        </main>
      </React.Fragment>
    );
  }
}
