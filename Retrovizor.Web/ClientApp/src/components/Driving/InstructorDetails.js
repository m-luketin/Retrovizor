import React, { Component } from "react";
import { Link } from "react-router-dom";
import instructorImg from "../../assets/instructor.gif";
import instructorCar from "../../assets/instructor-car.png";
import "./Instructor.css";

export default class InstructorDetails extends Component {
  render() {
    return (
      <React.Fragment>
        <header>
          <Link to="/voznja">
            <svg
              className="header__arrow"
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
            <h1 className="header__title header__title--blue">Instruktor</h1>
          </Link>
        </header>
        <main className="main__drive main__instructor">
          <section className="main__next--lesson--wrapper">
            <div className="main__driving">
              <img
                className="main__driving--instructor"
                src={instructorImg}
                alt="Instruktor"
              />

              <button className="main__button main__button--schedule main__button--driving main__button--name">
                <span className="button__info">
                  <h3 className="instructor__name">Ivan Bartičević</h3>
                  <p className="instructor__school">Autoškola "Dalmacija"</p>
                </span>
              </button>
            </div>

            <figure className="instructor__item">
              <svg
                className="instructor__item--phone"
                xmlns="http://www.w3.org/2000/svg"
                width="23px"
                height="23px"
                viewBox="0 0 23 23"
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
                    id="Budicon-Solid/Communication/call"
                    transform="translate(-1.000000, -1.000000)"
                    fill="#8B959E"
                    fillRule="nonzero"
                  >
                    <path
                      d="M23.5545499,20.7935954 L21.8337499,22.5142954 C20.1084669,24.2426029 17.3952615,24.4928598 15.3829499,23.1092954 C12.7045902,21.3404908 10.1660866,19.3685211 7.78984992,17.2107954 C5.63193288,14.8342736 3.65979587,12.295469 1.89084992,9.61679542 C0.507455066,7.60450799 0.757614715,4.89148707 2.48564992,3.16609542 L4.20644992,1.44539542 C4.49152127,1.16021917 4.87822397,1 5.28144992,1 C5.68467588,1 6.07137857,1.16021917 6.35644992,1.44539542 L9.22264992,4.31159542 C9.50782617,4.59666677 9.66804534,4.98336947 9.66804534,5.38659542 C9.66804534,5.78982138 9.50782617,6.17652407 9.22264992,6.46159542 L7.98804992,7.69609542 C7.65612625,8.02766642 7.59534102,8.54378232 7.84114992,8.94339542 C8.84688981,10.6268651 10.0308,12.1972652 11.3724499,13.6274954 C12.8026677,14.969117 14.3730315,16.1530251 16.0564499,17.1587954 C16.456077,17.4046164 16.9722206,17.3437866 17.3037499,17.0117954 L18.5383499,15.7771954 C19.1321064,15.183611 20.0945934,15.183611 20.6883499,15.7771954 L23.5547499,18.6436954 C23.8398691,18.9287892 24,19.3154854 24,19.7186869 C24,20.1218883 23.8397221,20.5085547 23.5545499,20.7935954 L23.5545499,20.7935954 Z"
                      id="Shape"
                    />
                  </g>
                </g>
              </svg>
              <div>
                <figcaption className="instructor__item--title">
                  Kontakt:
                </figcaption>
                <p className="instructor__item--text c-blue">+385 123123123</p>
              </div>
            </figure>

            <figure className="instructor__item">
              <svg
                className="instructor__item--people"
                xmlns="http://www.w3.org/2000/svg"
                width="22px"
                height="20px"
                viewBox="0 0 22 20"
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
                    id="Budicon-Solid/User/shared-user"
                    transform="translate(-2.000000, -3.000000)"
                    fill="#8B959E"
                    fillRule="nonzero"
                  >
                    <path
                      d="M5,8 C5,5.23857625 7.23857625,3 10,3 C12.7614237,3 15,5.23857625 15,8 C15,10.7614237 12.7614237,13 10,13 C7.2398556,12.9969138 5.00308618,10.7601444 5,8 Z M10,14 C5.581722,14 2,17.581722 2,22 L2,22.5 C2,22.7761424 2.22385763,23 2.5,23 L17.5,23 C17.7761424,23 18,22.7761424 18,22.5 L18,22 C18,17.581722 14.418278,14 10,14 Z M19,11 C20.6568542,11 22,9.65685425 22,8 C22,6.34314575 20.6568542,5 19,5 C17.3431458,5 16,6.34314575 16,8 C16.0018187,9.65610033 17.3438997,10.9981813 19,11 Z M17.4783,17 L24.0000122,17 C24.0049189,14.7654342 22.5234118,12.8001308 20.3738376,12.1896893 C18.2242634,11.5792477 15.9309566,12.4725698 14.7607,14.3762 C15.8408598,15.050139 16.766851,15.9441689 17.4783,17 Z"
                      id="Shape"
                    />
                  </g>
                </g>
              </svg>
              <div>
                <figcaption className="instructor__item--title">
                  Kandidati:
                </figcaption>
                <p className="instructor__item--text">15/15</p>
              </div>
            </figure>

            <section className="instructor__item--wrapper">
              <figure className="instructor__item">
                <svg
                  className="intructor__item--car"
                  xmlns="http://www.w3.org/2000/svg"
                  width="25px"
                  height="22px"
                  viewBox="0 0 25 22"
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
                      id="Budicon-Solid/Travel/car-front"
                      transform="translate(0.000000, -1.000000)"
                      fill="#8B959E"
                      fillRule="nonzero"
                    >
                      <path
                        d="M10,3.50000073 C10,3.22385836 10.2238576,3.00000073 10.5,3.00000073 L14.5,3.00000073 C14.7761424,3.00000073 15,3.22385836 15,3.50000073 C15,3.77614311 14.7761424,4.00000073 14.5,4.00000073 L10.5,4.00000073 C10.2238576,4.00000073 10,3.77614311 10,3.50000073 Z M5.5,15.0000007 C4.67157288,15.0000007 4,15.6715736 4,16.5000007 C4,17.3284279 4.67157288,18.0000007 5.5,18.0000007 C6.32842712,18.0000007 7,17.3284279 7,16.5000007 C6.99911814,15.6719392 6.32806157,15.0008826 5.5,15.0000007 L5.5,15.0000007 Z M24.5,11 L23.6968,11 C24.3760641,12.2407353 24.8180172,13.5972519 25,15 L25,22 C25,22.5522855 24.5522847,23 24,23 L22,23 C21.4477153,23 21,22.5522855 21,22 L21,21 L4,21 L4,22 C4,22.5522855 3.55228475,23 3,23 L1,23 C0.44771525,23 0,22.5522855 0,22 L0,15 C0.181982806,13.5972519 0.623935929,12.2407353 1.3032,11 L0.5,11 C0.223857625,11 0,10.7761431 0,10.5 L0,8.5 C0,8.22385836 0.223857625,8 0.5,8 L2.67,8 L4.7607,3.12110073 C5.31195072,1.83364264 6.57799121,0.99909777 7.9785,1 L17.0215,1 C18.4220088,0.99909777 19.6880493,1.83364264 20.2393,3.12110073 L22.33,8 L24.5,8 C24.7761424,8 25,8.22385836 25,8.5 L25,10.5 C25,10.7761431 24.7761424,11 24.5,11 Z M2.86,10.0000007 L2.3743,9.00000073 L1,9.00000073 L1,10.0000007 L2.86,10.0000007 Z M3.3882,8.79930073 L3.9722,10.0000007 L4,10.0000007 L5.4142,11.4141007 C5.78925084,11.7892118 6.29795542,12.0000007 6.8284,12.0000007 L18.1716,12.0000007 C18.7020446,12.0000007 19.2107492,11.7892118 19.5858,11.4141007 L21,10.0000007 L21.0278,10.0000007 L21.6169,8.78810073 C21.5922,8.75610073 21.5569,8.73590073 21.54,8.69730073 L19.3191,3.51510073 C18.9251595,2.59601865 18.0214505,2.00000073 17.0215,2.00000073 L7.9785,2.00000073 C6.97854951,2.00000073 6.07484049,2.59601865 5.6809,3.51510073 L3.46,8.69730073 C3.44073353,8.73428348 3.41669476,8.76857654 3.3885,8.79930073 L3.3882,8.79930073 Z M8,16.5000007 C8,15.1192889 6.88071187,14.0000007 5.5,14.0000007 C4.11928813,14.0000007 3,15.1192889 3,16.5000007 C3,17.8807126 4.11928813,19.0000007 5.5,19.0000007 C6.88071187,19.0000007 8,17.8807126 8,16.5000007 Z M15,17.5000007 C15,17.2238584 14.7761424,17.0000007 14.5,17.0000007 L10.5,17.0000007 C10.2238576,17.0000007 10,17.2238584 10,17.5000007 C10,17.7761431 10.2238576,18.0000007 10.5,18.0000007 L14.5,18.0000007 C14.7761424,18.0000007 15,17.7761431 15,17.5000007 Z M15,15.5000007 C15,15.2238584 14.7761424,15.0000007 14.5,15.0000007 L10.5,15.0000007 C10.2238576,15.0000007 10,15.2238584 10,15.5000007 C10,15.7761431 10.2238576,16.0000007 10.5,16.0000007 L14.5,16.0000007 C14.7761424,16.0000007 15,15.7761431 15,15.5000007 Z M22,16.5000007 C22,15.1192889 20.8807119,14.0000007 19.5,14.0000007 C18.1192881,14.0000007 17,15.1192889 17,16.5000007 C17,17.8807126 18.1192881,19.0000007 19.5,19.0000007 C20.8807119,19.0000007 22,17.8807126 22,16.5000007 Z M24,9.00000073 L22.6257,9.00000073 L22.14,10.0000007 L24,10.0000007 L24,9.00000073 Z M19.5,15.0000007 C18.6715729,15.0000007 18,15.6715736 18,16.5000007 C18,17.3284279 18.6715729,18.0000007 19.5,18.0000007 C20.3284271,18.0000007 21,17.3284279 21,16.5000007 C20.9991181,15.6719392 20.3280616,15.0008826 19.5,15.0000007 L19.5,15.0000007 Z"
                        id="Shape"
                      />
                    </g>
                  </g>
                </svg>
                <div>
                  <figcaption className="instructor__item--title">
                    Auto:
                  </figcaption>
                  <p className="instructor__item--text">Golf VII GTI 2018</p>
                </div>
              </figure>
              <img
                className="instructor__item--preview"
                src={instructorCar}
                alt="car"
              />
            </section>

            <figure className="instructor__item instructor__item--itinerary">
              <svg
                className="instructor__item--calendar"
                xmlns="http://www.w3.org/2000/svg"
                width="25px"
                height="24px"
                viewBox="0 0 25 24"
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
                    id="Budicon-Solid/Time/events"
                    transform="translate(0.000000, -1.000000)"
                    fill="#8B959E"
                    fillRule="nonzero"
                  >
                    <path
                      d="M25,4 L25,8 L0,8 L0,4 C0,3.44771525 0.44771525,3 1,3 L6,3 L6,1.5 C6,1.22385763 6.22385763,1 6.5,1 C6.77614237,1 7,1.22385763 7,1.5 L7,3 L18,3 L18,1.5 C18,1.22385763 18.2238576,1 18.5,1 C18.7761424,1 19,1.22385763 19,1.5 L19,3 L24,3 C24.5522847,3 25,3.44771525 25,4 Z M0,9 L25,9 L25,24 C25,24.5522847 24.5522847,25 24,25 L1,25 C0.44771525,25 0,24.5522847 0,24 L0,9 Z M18,14 L20,14 L20,12 L18,12 L18,14 Z M13,14 L15,14 L15,12 L13,12 L13,14 Z M10,19 L12,19 L12,17 L10,17 L10,19 Z M5,19 L7,19 L7,17 L5,17 L5,19 Z"
                      id="Shape"
                    />
                  </g>
                </g>
              </svg>
              <div>
                <figcaption className="instructor__item--title">
                  Raspored:
                </figcaption>
              </div>
            </figure>
          </section>
        </main>
      </React.Fragment>
    );
  }
}
