import React, { Component } from "react";
import ProfileImg from "../../../assets/instructor.gif";

export default class EventStudentsToAdd extends Component {
  render() {
    return (
      <React.Fragment>
        <header>
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
          <h1 className="header__title header__title--blue">Kandidati</h1>
        </header>

        <main>
          <input
            className="student__list--search"
            type="text"
            placeholder="Traži"
          />
          <section>
            <div className="student__list--wrapper">
              <svg
                className="student__list--checkmark"
                xmlns="http://www.w3.org/2000/svg"
                width="32px"
                height="32px"
                viewBox="0 0 32 32"
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
                    id="Dodaj-kandidata(3)"
                    transform="translate(-30.000000, -271.000000)"
                    fill="#A8E063"
                    fillRule="nonzero"
                  >
                    <g
                      id="Group-3"
                      transform="translate(30.000000, 250.000000)"
                    >
                      <g
                        id="Budicon-Solid/Interface/tick-sign"
                        transform="translate(0.000000, 21.000000)"
                      >
                        <path
                          d="M16,0 C7.163444,0 0,7.163444 0,16 C0,24.836556 7.163444,32 16,32 C24.836556,32 32,24.836556 32,16 C32,11.7565362 30.3142906,7.68687356 27.3137085,4.6862915 C24.3131264,1.68570945 20.2434638,0 16,0 Z M22.8663045,12.5987841 L15.6387843,20.2787843 C15.4000209,20.532389 15.0022862,20.5484872 14.7438082,20.3150083 L10.4512001,16.4431362 C10.2773513,16.291012 10.1989746,16.057006 10.2461277,15.8308605 C10.2932809,15.604715 10.4586451,15.4215309 10.6788025,15.3515602 C10.8989599,15.2815894 11.1397391,15.3356923 11.3088001,15.4931202 L15.1360002,18.9450243 L21.9340804,11.7212161 C22.09082,11.5546446 22.3245182,11.4843457 22.5471431,11.5368004 C22.7697681,11.5892551 22.9474978,11.7564942 23.0133832,11.9755204 C23.0792686,12.1945466 23.0233001,12.4320846 22.8665605,12.5986561 L22.8663045,12.5987841 Z"
                          id="Shape"
                        />
                      </g>
                    </g>
                  </g>
                </g>
              </svg>
              <img src={ProfileImg} alt="Kandidat" />
              <span className="main__button">
                <p className="student__list--name">Luka Nola</p>
              </span>
            </div>
          </section>
        </main>
      </React.Fragment>
    );
  }
}
