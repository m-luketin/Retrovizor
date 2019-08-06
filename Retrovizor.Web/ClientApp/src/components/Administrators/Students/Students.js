import React, { Component } from "react";
import "./Students.css";
import "./StudentModals.css";
import profileImg from "../../../assets/instructor.gif";
import StudentAddModal from "./StudentAddModal";

export default class Students extends Component {
  render() {
    return (
      <React.Fragment>
        <header className="header">
          <h1 className="header__title">Kandidati</h1>
          <svg
            className="header__icon--plus"
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
                id="Budicon-Solid/Interface/plus-ui"
                fill="#8B959E"
                fillRule="nonzero"
              >
                <path
                  d="M25,12.5 C25,12.9060917 24.6707976,13.2352941 24.2647059,13.2352941 L13.2352941,13.2352941 L13.2352941,24.2647059 C13.2352941,24.6707976 12.9060917,25 12.5,25 C12.0939083,25 11.7647059,24.6707976 11.7647059,24.2647059 L11.7647059,13.2352941 L0.735294118,13.2352941 C0.32920239,13.2352941 0,12.9060917 0,12.5 C0,12.0939083 0.32920239,11.7647059 0.735294118,11.7647059 L11.7647059,11.7647059 L11.7647059,0.735294118 C11.7647059,0.32920239 12.0939083,0 12.5,0 C12.9060917,0 13.2352941,0.32920239 13.2352941,0.735294118 L13.2352941,11.7647059 L24.2647059,11.7647059 C24.6707976,11.7647059 25,12.0939083 25,12.5 Z"
                  id="Shape"
                />
              </g>
            </g>
          </svg>
        </header>
        <main className="main">
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

        <StudentAddModal />
      </React.Fragment>
    );
  }
}
