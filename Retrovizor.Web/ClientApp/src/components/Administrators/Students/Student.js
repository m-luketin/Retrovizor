import React, { Component } from "react";
import { Link } from "react-router-dom";
import instructorImg from "../../../assets/instructor.gif";
import instructorCar from "../../../assets/instructor-car.png";

export default class Student extends Component {
  render() {
    return (
      <React.Fragment>
        <header className="header--instructors">
          <Link to="/administrator/kandidati">
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
            <h1 className="header__title header__title--blue">Kandidat</h1>
          </Link>
          <svg
            className="header__icon--pencil"
            xmlns="http://www.w3.org/2000/svg"
            width="19px"
            height="18px"
            viewBox="0 0 19 18"
            version="1.1"
          >
            <g
              id="Administrator"
              stroke="none"
              strokeWidth="1"
              fill="none"
              fillRule="evenodd"
            >
              <g
                id="Instruktor(3)"
                transform="translate(-364.000000, -63.000000)"
                fill="#1488CC"
                fillRule="nonzero"
              >
                <g
                  id="Budicon-Solid/Writing/pen"
                  transform="translate(363.000000, 62.000000)"
                >
                  <path
                    d="M18.9514971,5.91096753 L18.0600051,6.75976753 L13.902005,2.79976753 L14.793245,1.95096753 C15.2855912,1.48301082 16.0827908,1.48301082 16.575137,1.95096753 L18.9509931,4.21384753 C19.4426816,4.68257078 19.4429071,5.44197947 18.9514971,5.91096753 Z M2.048765,14.0894476 C1.81183806,14.3140475 1.6790598,14.6195571 1.68,14.9379276 L1.68,17.6004076 C1.68032932,18.0421074 2.05622021,18.4000988 2.52000498,18.4004131 L5.31552488,18.4004131 C5.6498523,18.4013738 5.97068905,18.2749099 6.20651284,18.0492076 L17.4662924,7.32544762 L13.3082926,3.36544762 L2.048765,14.0894476 Z"
                    id="Shape"
                  />
                </g>
              </g>
            </g>
          </svg>
        </header>
        <main className="main__drive main__instructor">
          <section className="main__next--lesson--wrapper">
            <div className="main__driving mb-20px">
              <img
                className="main__driving--instructor"
                src={instructorImg}
                alt="Instruktor"
              />

              <button className="main__button main__button--schedule main__button--driving main__button--name">
                <span className="button__info">
                  <h3 className="instructor__name">Luka Nola</h3>
                  <span className="profile__category">
                    <span className="profile__category--type">B</span>kategorija
                  </span>
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
                  Kontakt
                </figcaption>
                <p className="instructor__item--text c-blue">+385 123123123</p>
              </div>
            </figure>

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
                  Instruktor
                </figcaption>
                <p className="instructor__item--text">15/15</p>
              </div>
            </figure>

            <section className="instructor__item--wrapper">
              <figure className="instructor__item">
                <svg
                  className="instructor__item--clock"
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
                      id="Budicon-Solid/Time/wall-clock"
                      fill="#8B959E"
                      fillRule="nonzero"
                    >
                      <path
                        d="M12.5,0 C5.59644063,0 0,5.59644063 0,12.5 C0,19.4035594 5.59644063,25 12.5,25 C19.4035594,25 25,19.4035594 25,12.5 C25,9.18479388 23.6830395,6.00536997 21.3388348,3.66116524 C18.99463,1.3169605 15.8152061,0 12.5,0 Z M16.8532,16.8531 C16.6579386,17.0483576 16.3413614,17.0483576 16.1461,16.8531 L12.1461,12.8531 L12.1423,12.8475 C12.0516326,12.7551706 12.0005773,12.6311024 12,12.5017 L12,12.5 L12,6.5 C12,6.22385763 12.2238576,6 12.5,6 C12.7761424,6 13,6.22385763 13,6.5 L13,12.2928 L16.8532,16.1459 C16.9469967,16.239672 16.9996932,16.3668689 16.9996932,16.4995 C16.9996932,16.6321311 16.9469967,16.759328 16.8532,16.8531 Z"
                        id="Shape"
                      />
                    </g>
                  </g>
                </svg>
                <div>
                  <figcaption className="instructor__item--title">
                    Sat
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
          </section>

          <section className="main__timeline main__student--timeline">
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
            <figure className="timeline__item timeline__item--smaller timeline__item--passed">
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
            <figure className="timeline__item timeline__item--smaller timeline__item--passed">
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
            <figure className="timeline__item timeline__item--smaller timeline__item--passed">
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
            <figure className="timeline__item timeline__item--smaller timeline__item--warning">
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
            <figure className="timeline__item timeline__item--smaller timeline__item--waiting">
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
