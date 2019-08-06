import React, { Component } from "react";
import { Link } from "react-router-dom";
import instructorImg from "../../../assets/instructor.gif";
import "./AdministratorProfile.css";

export default class AdministratorProfile extends Component {
  render() {
    return (
      <React.Fragment>
        <header className="header">
          <h1 className="header__title">Profil</h1>
          <button>
            <Link to="/administrator/profil/postavke">
              <img
                className="bi x0 y0 w1 h1 header__settings"
                alt="Settings button"
                src="data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAACYAAAAmCAIAAAAnX375AAAACXBIWXMAABYlAAAWJQFJUiTwAAADeElEQVRYw7WY3UtaYRzHj6KQb5gej2EqimZ1pMWMMViDhKEEJeGIEXXTdjd2uf9kl9HNKNhYY2wXazdRENamLrVjVq4Xk2RWcxVRnmMdO+3iDKfP8bzY9Hvnw/M8n+c8v9dH0c3NDSRYFEWFovHlcIz+qZDLxoZ9apUSqkXimmanM9kSD4KgPE68+fAZqlG1ITe2doGRPE6cnV80CklRVHI7xRxPpTM1ISXModja5s7ePk4Qnr5eo0FPD5JkMRCKVN0iGMH0Orh85gqWWE0kzUaDqwstjZckAtzn28pqubU6HTa71XxwlIvGN7jPjsCabmcHfYI8TpTGRx8PAtQKZGxtcz4QhOqtF89G5bKm6rbc2duHGiC87KNBJE4QjUBeXpGsSE9fb915CKwBbFmBNBr0nQ5bfZH+AQ9PXNqt5voimekQjMuDoxz3Fg/vu1oQHaxtJq/I3MlpOBrPHZ9y+Q5RKHdXEEmSRY74s5haB73u8vU6WIM6bJvbqdm5RbZV2Hrywb271S+Woii2/ELzngz1A+elhTpsT0f8bAuXwzEgCYuur6/TmezG1m7V/MkWzkwtLIU4bgiBNe12q7OjTa1Sir5+j5VnODb7AZfDFEkWX01Oc89RyGXjI34xLw+CoBZExztHKpUo5DLuOXmcCEYwQcUL1jYLmWY2GviTH1EQhCQrM9Z/Ssx7GxAE5U5OhezF7YClVCMeG/bxUsPROO9ev4/5j9XT7UQdtr/18uz8IpXOANW1XINeN8qefimKmpiaYVvb6bC5ulC9TiuVSv6lArVK6bqDDvU/Ytt0dm6R7TsoivoyH2DjIbDG53UbDXqaV6WSILCGjfr63aeFpRBJFoH7nJia4bAisyCCvY+QXkQhl9HxIMRfXj4fF4vFPB0er/I4IQQmqI8lyWIwgtW3XmLrP7iQK1iCzQturflAEDB/BXI1kWxEu5XJHrIihSTJWwhI0RVIVxdad57F1KpSyLmC5OfBr7cfZ0tR7B/wqFVKnChg60mOMofAGk9fr6FFR/tLKcwsptZhnxcIEhHzSYsTBRwnLq9IoP88O7+YnH5fNZ/5vG7A8zPZQ1jbrFLIAV71uJTLmqr2HGqVEoE1zH6OaQ6pVGKzmOrzpG23W5mDep22ga9oZ0cbUOl6up2lfC1Qopr+nqAtHYxgOFGg6y1a+4PiD8kGeYAymJKbAAAAAElFTkSuQmCC"
              />
            </Link>
          </button>
        </header>
        <main className="main__drive main__instructor">
          <section className="main__next--lesson--wrapper">
            <div className="main__driving mb-20px">
              <div className="profile__image--wrapper">
                <img
                  src={instructorImg}
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

              <span className="button__info">
                <h3 className="instructor__name school--name">
                  Autoškola Dalmacija
                </h3>
              </span>
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
                xmlns="http://www.w3.org/2000/svg"
                width="21px"
                height="15px"
                viewBox="0 0 21 15"
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
                    id="Profil(3)"
                    transform="translate(-33.000000, -314.000000)"
                    fill="#8B959E"
                    fillRule="nonzero"
                  >
                    <g
                      id="Group-3"
                      transform="translate(33.000000, 309.000000)"
                    >
                      <g
                        id="Budicon-Solid/Travel/car-front"
                        transform="translate(0.000000, 2.000000)"
                      >
                        <path
                          d="M20.58,6.72000354 L18.239172,6.72000354 C17.713584,5.71124756 17.1171,4.64772358 16.743972,3.99369959 C16.5203133,3.60111426 16.1028727,3.35907506 15.651048,3.36 L5.34895204,3.36 C4.89697726,3.35892366 4.47934081,3.60098339 4.25560805,3.99369959 C3.88290005,4.64772358 3.28650005,5.71124756 2.76082806,6.72000354 L0.420000068,6.72000354 C0.188040474,6.72000354 0,6.90804394 0,7.14000353 L0,8.40000351 C0,8.5928719 0.131150027,8.7610268 0.318276068,8.8077395 L1.69192806,9.15104749 C1.68610331,9.18042214 1.68211955,9.21013201 1.68000006,9.24000349 C1.68000006,9.91754748 2.22667206,14.9688034 2.43801606,16.8960154 C2.48490111,17.3209895 2.84500819,17.6420231 3.27255605,17.6400128 L5.36088004,17.6400128 C5.67902419,17.6400128 5.96987017,17.4602784 6.11217604,17.1757353 L6.60391204,16.1921794 C6.67505325,16.0498915 6.82047862,15.9600088 6.97956004,15.9600034 L14.02044,15.9600034 C14.1795214,15.9600088 14.3249468,16.0498915 14.396088,16.1921794 L14.887824,17.1757353 C15.0301299,17.4602784 15.3209759,17.6400128 15.63912,17.6400128 L17.727444,17.6400128 C18.1549919,17.6420231 18.5150989,17.3209895 18.561984,16.8960154 C18.773328,14.9688034 19.32,9.91754748 19.32,9.24000349 C19.317884,9.21010386 19.3139002,9.18036583 19.308072,9.15096349 L20.681724,8.8076555 C20.8688196,8.76095037 21,8.59284059 21,8.40000351 L21,7.14000353 C21,6.90804394 20.8119596,6.72000354 20.58,6.72000354 Z M1.96560008,8.3532156 L0.8400001,8.0718996 L0.8400001,7.5600036 L2.33520008,7.5600036 C2.19483608,7.8456036 2.06824808,8.1153276 1.96560008,8.3532156 Z M7.5600002,13.8600036 C7.5600002,14.0919632 7.37195979,14.2800036 7.14000019,14.2800036 L4.06560014,14.2800036 C3.85375991,14.2800036 3.67506032,14.1222889 3.64879213,13.9120836 L3.36319213,11.3929236 C3.34422999,11.2452922 3.40499725,11.0986807 3.5228377,11.007751 C3.64067814,10.9168213 3.79790716,10.8952195 3.93590414,10.9509995 L7.2959042,12.2608116 C7.45540971,12.3245758 7.5600002,12.479045 7.5600002,12.6508236 L7.5600002,13.8600036 Z M17.350872,13.9120834 C17.3246197,14.1221617 17.1461122,14.279859 16.9344,14.2800034 L13.86,14.2800034 C13.6280404,14.2800034 13.44,14.091963 13.44,13.8600034 L13.44,12.6508234 C13.4399438,12.4790349 13.5445111,12.3245297 13.704012,12.2607274 L17.064012,10.9509154 C17.2020089,10.8951354 17.359238,10.9167372 17.4770784,11.0076669 C17.5949188,11.0985966 17.6556861,11.2452081 17.636724,11.3928394 L17.350872,13.9120834 Z M10.5,9.24000376 C7.96596638,9.15900604 5.45062147,8.77623369 3.00720014,8.09978772 C3.38024413,7.3235437 3.99504011,6.14661967 4.98514809,4.40958362 C5.05920413,4.27868769 5.19856766,4.19840322 5.34895208,4.19998012 L15.6510479,4.19998012 C15.801421,4.19861664 15.9406701,4.27905165 16.0145999,4.41000362 C17.0046238,6.14703967 17.6194198,7.3239637 17.9924638,8.10020772 C15.5491341,8.77648534 13.0339038,9.15911641 10.5,9.24000376 L10.5,9.24000376 Z M20.1599994,8.07189972 L19.0343994,8.35329972 C18.9315834,8.11541172 18.8050794,7.84593972 18.6647994,7.56008772 L20.1599994,7.56008772 L20.1599994,8.07189972 Z M4.27560013,11.9849555 L6.7200002,12.9379355 L6.7200002,13.4400035 L4.44099613,13.4400035 L4.27560013,11.9849555 Z M14.28,12.9379355 L16.7244001,11.9849555 L16.5590041,13.4400035 L14.28,13.4400035 L14.28,12.9379355 Z"
                          id="Shape"
                        />
                      </g>
                    </g>
                  </g>
                </g>
              </svg>
              <div>
                <figcaption className="instructor__item--title">
                  Instruktori
                </figcaption>
                <p className="instructor__item--text">8</p>
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
                  Kandidati
                </figcaption>
                <p className="instructor__item--text">50</p>
              </div>
            </figure>

            <figure className="instructor__item">
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
                  Prolaznost
                </figcaption>
              </div>
            </figure>
          </section>

          <section>
            <button className="main__button--big main__button--admin bc-blue">
              <div className="main__button--text main__button--admin--text">
                <h3>Ispit iz prometnih propisa</h3>
                <p>498/531 (94%)</p>
              </div>
            </button>

            <button className="main__button--big main__button--admin bc-blue">
              <div className="main__button--text main__button--admin--text">
                <h3>Ispit iz prve pomoći</h3>
                <p>498/531 (94%)</p>
              </div>
            </button>

            <button className="main__button--big main__button--admin bc-blue">
              <div className="main__button--text main__button--admin--text">
                <h3>Ispit iz vožnje</h3>
                <p>498/531 (94%)</p>
              </div>
            </button>
          </section>
        </main>
      </React.Fragment>
    );
  }
}
