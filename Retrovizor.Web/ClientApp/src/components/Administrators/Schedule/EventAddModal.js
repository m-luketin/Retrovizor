import React, { Component } from "react";
import "./EventModal.css";

export default class EventAddModal extends Component {
  render() {
    return (
      <aside className="modal--wrapper">
        <h3 className="modal__title">Dodaj događaj</h3>
        <div className="modal__input--wrapper">
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
            <input
              className="modal__event--type"
              type="text"
              placeholder="Tip"
            />
          </div>
          <input
            className="modal__event--number"
            type="number"
            placeholder="Sat"
          />
        </div>
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
            xmlns="http://www.w3.org/2000/svg"
            width="21px"
            height="19px"
            viewBox="0 0 21 19"
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
                transform="translate(-47.000000, -411.000000)"
                fill="#8B959E"
                fillRule="nonzero"
              >
                <g id="Group-7">
                  <g id="Group-6" transform="translate(17.000000, 219.000000)">
                    <g
                      id="Group-4"
                      transform="translate(29.000000, 185.000000)"
                    >
                      <g
                        id="Budicon-Solid/Time/wall-clock"
                        transform="translate(0.000000, 5.000000)"
                      >
                        <path
                          d="M4.4,7.04 C4.4,4.6099471 6.3699471,2.64 8.8,2.64 C11.2300529,2.64 13.2,4.6099471 13.2,7.04 C13.2,9.4700529 11.2300529,11.44 8.8,11.44 C6.37107293,11.4372842 4.40271584,9.46892707 4.4,7.04 Z M8.8,12.32 C4.91191536,12.32 1.76,15.4719154 1.76,19.36 L1.76,19.8 C1.76,20.0430053 1.95699471,20.24 2.2,20.24 L15.4,20.24 C15.6430053,20.24 15.84,20.0430053 15.84,19.8 L15.84,19.36 C15.84,15.4719154 12.6880846,12.32 8.8,12.32 Z M16.72,9.68 C18.1780317,9.68 19.36,8.49803174 19.36,7.04 C19.36,5.58196826 18.1780317,4.4 16.72,4.4 C15.2619683,4.4 14.08,5.58196826 14.08,7.04 C14.0816005,8.49736829 15.2626317,9.67839953 16.72,9.68 Z M15.3809042,14.96 L21.1200109,14.96 C21.1243288,12.9935821 19.8206026,11.2641151 17.9289773,10.7269265 C16.037352,10.1897379 14.019242,10.9758614 12.9894162,12.651056 C13.9399568,13.2441223 14.7548291,14.0308687 15.3809042,14.96 Z"
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
            <input type="text" placeholder="Kandidati" />
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