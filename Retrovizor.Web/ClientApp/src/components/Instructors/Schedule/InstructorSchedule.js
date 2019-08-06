import React, { Component } from "react";
import InstructorAddEventModal from "./InstructorAddEventModal";
import InstructorDetailsModal from "./InstructorDetailsModal";

export default class InstructorSchedule extends Component {
  render() {
    return (
      <React.Fragment>
        <header className="header">
          <h1 className="header__title">Raspored</h1>
          <div>
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
          </div>
        </header>

        <main className="main main__admin--schedule">
          {/* for search by date */}
          <div className="instructor__item--schedule instructor__item--schedule--admin">
            <svg
              className="intructor__item--arrow"
              xmlns="http://www.w3.org/2000/svg"
              width="15px"
              height="27px"
              viewBox="0 0 15 27"
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
                  id="Instruktor"
                  transform="translate(-15.000000, -58.000000)"
                  stroke="#1488CC"
                  strokeWidth="4"
                >
                  <polyline
                    id="Path"
                    transform="translate(27.606602, 71.500000) rotate(-315.000000) translate(-27.606602, -71.500000) "
                    points="20.1066017 64 20.1066017 79 35.1066017 79"
                  />
                </g>
              </g>
            </svg>
            <h3 className="instructor__schedule--date">Srijeda,</h3>
            <p className="instructor__schedule--day">17. srpnja</p>
          </div>
          {/* main__button--schedule--admin is for search by date - remove if its not search by date */}
          <button className="main__button main__button--schedule main__button--schedule--admin">
            <div className="instructor__schedule--time">
              <h3>08:30</h3>
            </div>
            <span>
              <p className="button__info">Matija Luketin</p>
              <p className="button__info">Požeška 12, Split</p>
            </span>
            <svg
              class="main__button--arrow button__garbage"
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
                  <g transform="translate(17.000000, 113.000000)" id="Group-5">
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
          </button>

          <button className="main__button main__button--schedule instructor__schedule--exam">
            <div className="instructor__schedule--time">
              <h3>10:15</h3>
            </div>
            <span>
              <p className="button__info">Nino Borović</p>
              <p className="button__info">Ispit</p>
            </span>
            <svg
              class="main__button--arrow button__garbage"
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
                  <g transform="translate(17.000000, 113.000000)" id="Group-5">
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
          </button>

          <button className="main__button main__button--schedule instructor__schedule--free">
            <div className="brc-blue instructor__schedule--time ">
              <h3>11:15</h3>
            </div>
            <p className="button__info">Slobodno</p>
            <svg
              className="button__info--arrow button__garbage"
              xmlns="http://www.w3.org/2000/svg"
              width="15px"
              height="27px"
              viewBox="0 0 15 27"
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
                  id="Instruktor"
                  transform="translate(-15.000000, -58.000000)"
                  stroke="#1488CC"
                  strokeWidth="4"
                >
                  <polyline
                    id="Path"
                    transform="translate(27.606602, 71.500000) rotate(-315.000000) translate(-27.606602, -71.500000) "
                    points="20.1066017 64 20.1066017 79 35.1066017 79"
                  />
                </g>
              </g>
            </svg>
          </button>
        </main>

        <InstructorAddEventModal />
        <InstructorDetailsModal />
      </React.Fragment>
    );
  }
}
