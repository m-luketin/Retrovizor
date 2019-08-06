import React, { Component } from "react";

export default class InstructorDetailsModal extends Component {
  render() {
    return (
      <aside className="modal--wrapper">
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
            <input type="text" placeholder="Vrijeme" />
          </div>
        </div>
        <div className="modal__input--wrapper">
          <svg
            className="instructor__item--person"
            xmlns="http://www.w3.org/2000/svg"
            width="16px"
            height="21px"
            viewBox="0 0 16 21"
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
                id="Termin-obični(2)"
                transform="translate(-49.000000, -366.000000)"
                fill="#8B959E"
                fillRule="nonzero"
              >
                <g id="Group-8">
                  <g id="Group-7" transform="translate(17.000000, 212.000000)">
                    <g
                      id="Group-4"
                      transform="translate(30.000000, 141.000000)"
                    >
                      <g
                        id="Budicon-Outline/User/user"
                        transform="translate(0.000000, 11.000000)"
                      >
                        <path
                          d="M5,7.04023012 C5,4.26293602 7.23857625,2.01149432 10,2.01149432 C12.7614237,2.01149432 15,4.26293602 15,7.04023012 C15,9.81752421 12.7614237,12.0689659 10,12.0689659 C7.2398556,12.065862 5.00308618,9.81623751 5,7.04023012 Z M10,13.0747131 C5.581722,13.0747131 2,16.6770198 2,21.1206903 L2,21.6235639 C2,21.9012933 2.22385763,22.1264375 2.5,22.1264375 L17.5,22.1264375 C17.7761424,22.1264375 18,21.9012933 18,21.6235639 L18,21.1206903 C18,16.6770198 14.418278,13.0747131 10,13.0747131 Z"
                          id="Shape"
                        />
                      </g>
                    </g>
                  </g>
                </g>
              </g>
            </g>
          </svg>
          <div className="modal__instructor--wrapper">
            <input type="text" placeholder="Kandidat" />
          </div>
        </div>
        <div className="modal__input--wrapper">
          <svg
            className="instructor__item--pointer"
            xmlns="http://www.w3.org/2000/svg"
            width="17px"
            height="24px"
            viewBox="0 0 17 24"
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
                id="Termin-obični(2)"
                transform="translate(-48.000000, -423.000000)"
                fill="#8B959E"
                fillRule="nonzero"
              >
                <g id="Group-8">
                  <g id="Group-7" transform="translate(17.000000, 212.000000)">
                    <g
                      id="Group-4"
                      transform="translate(28.000000, 200.000000)"
                    >
                      <g id="Group-2">
                        <g
                          id="Budicon-Solid/Time/wall-clock"
                          transform="translate(0.000000, 11.000000)"
                        >
                          <path
                            d="M11.5,0 C7.18113326,0 3.68,3.65335642 3.68,8.15999996 C3.68,12.9378239 8.264728,20.5407359 10.412928,23.4407039 C10.6728123,23.7930503 11.074647,23.9996466 11.5007428,23.9999854 C11.9268387,24.0003232 12.3289741,23.7943653 12.589372,23.4424319 C14.73886,20.5500479 19.32,12.9666239 19.32,8.15999996 C19.32,5.99583341 18.4961095,3.92030549 17.029575,2.39000865 C15.5630405,0.859711813 13.573993,0 11.5,0 L11.5,0 Z M11.5,10.56 C9.72164311,10.56 8.28,9.05567676 8.28,7.2 C8.28,5.34432324 9.72164311,3.84 11.5,3.84 C13.2783569,3.84 14.72,5.34432324 14.72,7.2 C14.72,9.05567676 13.2783569,10.56 11.5,10.56 L11.5,10.56 Z"
                            id="Shape"
                          />
                        </g>
                      </g>
                    </g>
                  </g>
                </g>
              </g>
            </g>
          </svg>
          <div className="modal__instructor--wrapper">
            <input type="text" placeholder="Lokacija" />
          </div>
        </div>
        <input className="modal__instructor--checkbox" type="checkbox" />
        <label className="modal__instructor--label">Ispit</label>
      </aside>
    );
  }
}
