import React, { Component } from "react";
import "./Settings.css";

export default class Settings extends Component {
  returnToLastPage = () => {
    this.props.history.goBack();
  };

  render() {
    return (
      <React.Fragment>
        <header onClick={this.returnToLastPage}>
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
          <h1 className="header__title header__title--blue">Postavke</h1>
        </header>

        <main>
          <button className="main__button">
            <svg
              className="main__button--lock"
              xmlns="http://www.w3.org/2000/svg"
              width="17px"
              height="25px"
              viewBox="0 0 17 25"
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
                  id="Budicon-Solid/Interface/lock"
                  transform="translate(-4.000000, 0.000000)"
                  fill="#FFFFFF"
                  fillRule="nonzero"
                >
                  <path
                    d="M19.5,10 L18,10 L18,5.5 C18,2.46243388 15.5375661,0 12.5,0 C9.46243388,0 7,2.46243388 7,5.5 L7,10 L5.5,10 C4.67157288,10 4,10.6715729 4,11.5 L4,23.5 C4,24.3284271 4.67157288,25 5.5,25 L19.5,25 C20.3284271,25 21,24.3284271 21,23.5 L21,11.5 C21,10.6715729 20.3284271,10 19.5,10 Z M14.974,20.3419 C15.0248001,20.4943151 14.999267,20.6618569 14.9053718,20.7922207 C14.8114766,20.9225845 14.6606581,20.9998887 14.5,21 L10.5,21 C10.339289,21 10.1883812,20.9227208 10.0944159,20.7923423 C10.0004507,20.6619638 9.97488319,20.4943653 10.0257,20.3419 L10.872,18.3833 C10.1114094,17.7351722 9.81241245,16.6948661 10.1128,15.7418 C10.3596945,14.9370777 11.0010678,14.3145683 11.8128,14.0918 C12.9408068,13.766267 14.1431471,14.2712978 14.7003524,15.304687 C15.2575577,16.3380763 15.018821,17.6201384 14.127,18.3837 L14.974,20.3419 Z M17,10 L8,10 L8,5.5 C8,3.01471863 10.0147186,1 12.5,1 C14.9852814,1 17,3.01471863 17,5.5 L17,10 Z"
                    id="Shape"
                  />
                </g>
              </g>
            </svg>
            <h3 className="main__button--description">Privatnost</h3>
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

          <button className="main__button">
            <svg
              className="main__button--bell"
              xmlns="http://www.w3.org/2000/svg"
              width="20px"
              height="23px"
              viewBox="0 0 20 23"
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
                  id="Budicon-Solid/Interface/notification"
                  transform="translate(-3.000000, -1.000000)"
                  fill="#FFFFFF"
                  fillRule="nonzero"
                >
                  <path
                    d="M10,22 L16,22 C15.4953739,23.2111026 14.3120278,24 13,24 C11.6879722,24 10.5046261,23.2111026 10,22 L10,22 Z M22.5607,18.5605 L21.5858,17.5859 C21.2106521,17.2107593 20.9999276,16.7019342 21,16.1714 L21,9 C21,4.581722 17.418278,1 13,1 C8.581722,1 5,4.581722 5,9 L5,16.1714 C5.00009891,16.7019688 4.78937243,17.2108348 4.4142,17.586 L3.4393,18.5606 C3.15804928,18.8418718 3,19.2233365 3,19.6211 L3,21 L23,21 L23,19.6211 C23,19.2233018 22.8419752,18.8417963 22.5607,18.5605 L22.5607,18.5605 Z"
                    id="Shape"
                  />
                </g>
              </g>
            </svg>
            <h3 className="main__button--description">Obavijesti</h3>
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

          <button className="main__button">
            <svg
              className="main__button--shield"
              xmlns="http://www.w3.org/2000/svg"
              width="21px"
              height="23px"
              viewBox="0 0 21 23"
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
                  id="Budicon-Solid/Tech/security-guard"
                  transform="translate(-3.000000, -1.000000)"
                  fill="#FFFFFF"
                  fillRule="nonzero"
                >
                  <path
                    d="M3,1 L3,12 C3,16.625 8.4375,24 13.5,24 C18.5625,24 24,16.625 24,12 L24,1 L3,1 Z M13.5,21 C9.9507,21 6,15.9336 6,12.5 L6,4.5 C6,4.22385763 6.22385763,4 6.5,4 L11.5,4 C11.7761424,4 12,4.22385763 12,4.5 C12,4.77614237 11.7761424,5 11.5,5 L7,5 L7,12.5 C7,15.3936 10.5493,20 13.5,20 C13.7761424,20 14,20.2238576 14,20.5 C14,20.7761424 13.7761424,21 13.5,21 Z"
                    id="Shape"
                  />
                </g>
              </g>
            </svg>
            <h3 className="main__button--description">Sigurnosti</h3>
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

          <button className="main__button">
            <svg
              className="main__button--info"
              xmlns="http://www.w3.org/2000/svg"
              width="27px"
              height="27px"
              viewBox="0 0 27 27"
              version="1.1"
            >
              <g
                id="Instruktor"
                stroke="none"
                strokeWidth="1"
                fill="none"
                fillRule="evenodd"
              >
                <g
                  id="Postavke"
                  transform="translate(-37.000000, -419.000000)"
                  fill="#FFFFFF"
                  fillRule="nonzero"
                >
                  <g
                    id="Budicon-Solid/Interface/alert-sign"
                    transform="translate(50.500000, 432.500000) rotate(-180.000000) translate(-50.500000, -432.500000) translate(37.000000, 419.000000)"
                  >
                    <path
                      d="M13.5,0 C6.04415588,0 0,6.04415588 0,13.5 C0,20.9558441 6.04415588,27 13.5,27 C20.9558441,27 27,20.9558441 27,13.5 C27,9.91957739 25.5776827,6.48579956 23.0459415,3.95405845 C20.5142004,1.42231734 17.0804226,0 13.5,0 Z M14.04,18.36 L12.96,18.36 L12.96,17.28 L14.04,17.28 L14.04,18.36 Z M14.04,15.12 L12.96,15.12 L12.96,8.64 L14.04,8.64 L14.04,15.12 Z"
                      id="Shape"
                    />
                  </g>
                </g>
              </g>
            </svg>
            <h3 className="main__button--description">
              Uvijeti i pravila o zaštiti privatnosti
            </h3>
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

          <figure className="logout">
            <svg
              xmlns="http://www.w3.org/2000/svg"
              width="23px"
              height="25px"
              viewBox="0 0 23 25"
              version="1.1"
            >
              <g
                id="Instruktor"
                stroke="none"
                strokeWidth="1"
                fill="none"
                fillRule="evenodd"
              >
                <g
                  id="Postavke"
                  transform="translate(-18.000000, -632.000000)"
                  fill="#8B959E"
                  fillRule="nonzero"
                >
                  <g
                    id="Budicon-Outline/Interface/logout"
                    transform="translate(17.000000, 632.000000)"
                  >
                    <path
                      d="M24,12.5 C24,12.6326325 23.9474242,12.7598536 23.8535,12.8535 L18.8535,17.8535 C18.6573106,18.0429861 18.3454576,18.0402762 18.1525907,17.8474093 C17.9597238,17.6545424 17.9570139,17.3426894 18.1465,17.1465 L22.293,13 L6.5,13 C6.22385763,13 6,12.7761424 6,12.5 C6,12.2238576 6.22385763,12 6.5,12 L22.293,12 L18.1465,7.8535 C17.9570139,7.65731056 17.9597238,7.34545761 18.1525907,7.15259071 C18.3454576,6.95972381 18.6573106,6.9570139 18.8535,7.1465 L23.8535,12.1465 C23.9474242,12.2401464 24,12.3673675 24,12.5 Z M14.5,14.0193534 C14.2238576,14.0193534 13.7761424,14.0193534 13.5,14.0193534 L6.0043604,14.0193534 C4.97347416,14.0193534 4.97347416,13.0712347 4.97347416,12.5 C4.97347416,11.9287653 4.97347416,10.9912109 6.0043604,10.9912109 C6.69161789,10.9912109 9.19016442,10.9912109 13.5,10.9912109 C13.7761424,10.9912109 14.2238576,10.9912109 14.5,10.9912109 C14.7761424,10.9912109 15,10.7673533 15,10.4912109 L15,1.5 C15,0.671572875 14.3284271,0 13.5,0 L2.5,0 C1.67157288,0 1,0.671572875 1,1.5 L1,23.5 C1,24.3284271 1.67157288,25 2.5,25 L13.5,25 C14.3284271,25 15,24.3284271 15,23.5 L15,14.5193534 C15,14.243211 14.7761424,14.0193534 14.5,14.0193534 Z"
                      id="Shape"
                    />
                  </g>
                </g>
              </g>
            </svg>
            <figcaption>Logout</figcaption>
          </figure>
        </main>
      </React.Fragment>
    );
  }
}
