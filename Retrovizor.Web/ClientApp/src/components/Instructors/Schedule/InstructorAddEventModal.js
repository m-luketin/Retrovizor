import React, { Component } from "react";

export default class InstructorAddEventModal extends Component {
  render() {
    return (
      <aside className="modal--wrapper">
        <h3 className="modal__title">Dodaj termin</h3>
        <div className="modal__input--wrapper">
          <svg
            className="modal__icon--calendar"
            xmlns="http://www.w3.org/2000/svg"
            width="24px"
            height="23px"
            viewBox="0 0 24 23"
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
                id="Raspored-dodaj(3)"
                transform="translate(-329.000000, -63.000000)"
                fill="#8B959E"
                fillRule="nonzero"
              >
                <g
                  id="Budicon-Outline/Writing/grid-view"
                  transform="translate(329.000000, 62.000000)"
                >
                  <path
                    d="M24,3.84 L24,7.68 L0,7.68 L0,3.84 C0,3.30980664 0.42980664,2.88 0.96,2.88 L5.76,2.88 L5.76,1.44 C5.76,1.17490332 5.97490332,0.96 6.24,0.96 C6.50509668,0.96 6.72,1.17490332 6.72,1.44 L6.72,2.88 L17.28,2.88 L17.28,1.44 C17.28,1.17490332 17.4949033,0.96 17.76,0.96 C18.0250967,0.96 18.24,1.17490332 18.24,1.44 L18.24,2.88 L23.04,2.88 C23.5701934,2.88 24,3.30980664 24,3.84 Z M0,8.64 L24,8.64 L24,23.04 C24,23.5701934 23.5701934,24 23.04,24 L0.96,24 C0.42980664,24 0,23.5701934 0,23.04 L0,8.64 Z M17.28,13.44 L19.2,13.44 L19.2,11.52 L17.28,11.52 L17.28,13.44 Z M12.48,13.44 L14.4,13.44 L14.4,11.52 L12.48,11.52 L12.48,13.44 Z M9.6,18.24 L11.52,18.24 L11.52,16.32 L9.6,16.32 L9.6,18.24 Z M4.8,18.24 L6.72,18.24 L6.72,16.32 L4.8,16.32 L4.8,18.24 Z"
                    id="Shape"
                  />
                </g>
              </g>
            </g>
          </svg>
          <div className="modal__instructor--wrapper">
            <svg
              className="modal__instructor--arrow"
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
                  stroke="#8B959E"
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
            <input type="text" placeholder="Datum" />
          </div>
        </div>
        <div className="modal__input--wrapper">
          <svg
            class="instructor__item--clock"
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
          <div className="modal__instructor--wrapper">
            <svg
              className="modal__instructor--arrow"
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
                  stroke="#8B959E"
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
            <input type="text" placeholder="Vrijeme" />
          </div>
        </div>

        <div className="modal__input--wrapper modal__input--wrapper--bottom">
          <button className="modal__button--empty">Poništi</button>
          <button className="modal__button--blue">Spremi</button>
        </div>
      </aside>
    );
  }
}
