import React, { Component } from "react";

export default class EventAddStudentsModal extends Component {
  render() {
    return (
      <aside className="modal--wrapper modal--big">
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
        <div className="modal__input--wrapper modal__input--right">
          <span className="modal__instructor--student">
            <p>Matija Luketin</p>
            <svg
              className="modal__icon--delete"
              xmlns="http://www.w3.org/2000/svg"
              width="13px"
              height="14px"
              viewBox="0 0 13 14"
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
                  id="Raspored-uredi(3)"
                  transform="translate(-336.000000, -434.000000)"
                  fill="#EB3349"
                  fillRule="nonzero"
                >
                  <g id="Group-7">
                    <g
                      id="Group-6"
                      transform="translate(17.000000, 134.000000)"
                    >
                      <g
                        id="Group-2"
                        transform="translate(65.000000, 291.000000)"
                      >
                        <path
                          d="M266.690476,10.75 L263.75,10.75 L263.461586,9.66278333 C263.358245,9.27326431 262.986836,9 262.560748,9 L258.439252,9 C258.013164,9 257.641755,9.27326431 257.538414,9.66278333 L257.25,10.75 L254.309524,10.75 C254.138579,10.75 254,10.8805836 254,11.0416667 C254,11.2027497 254.138579,11.3333333 254.309524,11.3333333 L255.269048,11.3333333 L255.843833,22.1691583 C255.868795,22.6346527 256.276604,23 256.771229,23 L264.260219,23 C264.755047,23 265.16291,22.6342767 265.187552,22.168575 L265.7624,11.3333333 L266.690476,11.3333333 C266.861421,11.3333333 267,11.2027497 267,11.0416667 C267,10.8805836 266.861421,10.75 266.690476,10.75 Z M258.952381,19.2083333 C258.952381,19.3694164 258.813802,19.5 258.642857,19.5 C258.471912,19.5 258.333333,19.3694164 258.333333,19.2083333 L258.333333,14.5416667 C258.333333,14.3805836 258.471912,14.25 258.642857,14.25 C258.813802,14.25 258.952381,14.3805836 258.952381,14.5416667 L258.952381,19.2083333 Z M260.809524,19.7916667 C260.809524,19.9527497 260.670945,20.0833333 260.5,20.0833333 C260.329055,20.0833333 260.190476,19.9527497 260.190476,19.7916667 L260.190476,13.9583333 C260.190476,13.7972503 260.329055,13.6666667 260.5,13.6666667 C260.670945,13.6666667 260.809524,13.7972503 260.809524,13.9583333 L260.809524,19.7916667 Z M262.666667,19.2083333 C262.666667,19.3694164 262.528088,19.5 262.357143,19.5 C262.186198,19.5 262.047619,19.3694164 262.047619,19.2083333 L262.047619,14.5416667 C262.047619,14.3805836 262.186198,14.25 262.357143,14.25 C262.528088,14.25 262.666667,14.3805836 262.666667,14.5416667 L262.666667,19.2083333 Z M257.888114,10.75 L258.138952,9.80435833 C258.173223,9.67438853 258.297131,9.58319016 258.439252,9.58333316 L262.560686,9.58333316 C262.702807,9.58319016 262.826715,9.67438853 262.860986,9.80435833 L263.111886,10.75 L257.888114,10.75 Z"
                          id="Shape"
                        />
                      </g>
                    </g>
                  </g>
                </g>
              </g>
            </svg>
          </span>
          <span className="modal__instructor--student">
            <p>Matija Luketin</p>
            <svg
              className="modal__icon--delete"
              xmlns="http://www.w3.org/2000/svg"
              width="13px"
              height="14px"
              viewBox="0 0 13 14"
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
                  id="Raspored-uredi(3)"
                  transform="translate(-336.000000, -434.000000)"
                  fill="#EB3349"
                  fillRule="nonzero"
                >
                  <g id="Group-7">
                    <g
                      id="Group-6"
                      transform="translate(17.000000, 134.000000)"
                    >
                      <g
                        id="Group-2"
                        transform="translate(65.000000, 291.000000)"
                      >
                        <path
                          d="M266.690476,10.75 L263.75,10.75 L263.461586,9.66278333 C263.358245,9.27326431 262.986836,9 262.560748,9 L258.439252,9 C258.013164,9 257.641755,9.27326431 257.538414,9.66278333 L257.25,10.75 L254.309524,10.75 C254.138579,10.75 254,10.8805836 254,11.0416667 C254,11.2027497 254.138579,11.3333333 254.309524,11.3333333 L255.269048,11.3333333 L255.843833,22.1691583 C255.868795,22.6346527 256.276604,23 256.771229,23 L264.260219,23 C264.755047,23 265.16291,22.6342767 265.187552,22.168575 L265.7624,11.3333333 L266.690476,11.3333333 C266.861421,11.3333333 267,11.2027497 267,11.0416667 C267,10.8805836 266.861421,10.75 266.690476,10.75 Z M258.952381,19.2083333 C258.952381,19.3694164 258.813802,19.5 258.642857,19.5 C258.471912,19.5 258.333333,19.3694164 258.333333,19.2083333 L258.333333,14.5416667 C258.333333,14.3805836 258.471912,14.25 258.642857,14.25 C258.813802,14.25 258.952381,14.3805836 258.952381,14.5416667 L258.952381,19.2083333 Z M260.809524,19.7916667 C260.809524,19.9527497 260.670945,20.0833333 260.5,20.0833333 C260.329055,20.0833333 260.190476,19.9527497 260.190476,19.7916667 L260.190476,13.9583333 C260.190476,13.7972503 260.329055,13.6666667 260.5,13.6666667 C260.670945,13.6666667 260.809524,13.7972503 260.809524,13.9583333 L260.809524,19.7916667 Z M262.666667,19.2083333 C262.666667,19.3694164 262.528088,19.5 262.357143,19.5 C262.186198,19.5 262.047619,19.3694164 262.047619,19.2083333 L262.047619,14.5416667 C262.047619,14.3805836 262.186198,14.25 262.357143,14.25 C262.528088,14.25 262.666667,14.3805836 262.666667,14.5416667 L262.666667,19.2083333 Z M257.888114,10.75 L258.138952,9.80435833 C258.173223,9.67438853 258.297131,9.58319016 258.439252,9.58333316 L262.560686,9.58333316 C262.702807,9.58319016 262.826715,9.67438853 262.860986,9.80435833 L263.111886,10.75 L257.888114,10.75 Z"
                          id="Shape"
                        />
                      </g>
                    </g>
                  </g>
                </g>
              </g>
            </svg>
          </span>
          <span className="modal__instructor--student">
            <p>Matija Luketin</p>
            <svg
              className="modal__icon--delete"
              xmlns="http://www.w3.org/2000/svg"
              width="13px"
              height="14px"
              viewBox="0 0 13 14"
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
                  id="Raspored-uredi(3)"
                  transform="translate(-336.000000, -434.000000)"
                  fill="#EB3349"
                  fillRule="nonzero"
                >
                  <g id="Group-7">
                    <g
                      id="Group-6"
                      transform="translate(17.000000, 134.000000)"
                    >
                      <g
                        id="Group-2"
                        transform="translate(65.000000, 291.000000)"
                      >
                        <path
                          d="M266.690476,10.75 L263.75,10.75 L263.461586,9.66278333 C263.358245,9.27326431 262.986836,9 262.560748,9 L258.439252,9 C258.013164,9 257.641755,9.27326431 257.538414,9.66278333 L257.25,10.75 L254.309524,10.75 C254.138579,10.75 254,10.8805836 254,11.0416667 C254,11.2027497 254.138579,11.3333333 254.309524,11.3333333 L255.269048,11.3333333 L255.843833,22.1691583 C255.868795,22.6346527 256.276604,23 256.771229,23 L264.260219,23 C264.755047,23 265.16291,22.6342767 265.187552,22.168575 L265.7624,11.3333333 L266.690476,11.3333333 C266.861421,11.3333333 267,11.2027497 267,11.0416667 C267,10.8805836 266.861421,10.75 266.690476,10.75 Z M258.952381,19.2083333 C258.952381,19.3694164 258.813802,19.5 258.642857,19.5 C258.471912,19.5 258.333333,19.3694164 258.333333,19.2083333 L258.333333,14.5416667 C258.333333,14.3805836 258.471912,14.25 258.642857,14.25 C258.813802,14.25 258.952381,14.3805836 258.952381,14.5416667 L258.952381,19.2083333 Z M260.809524,19.7916667 C260.809524,19.9527497 260.670945,20.0833333 260.5,20.0833333 C260.329055,20.0833333 260.190476,19.9527497 260.190476,19.7916667 L260.190476,13.9583333 C260.190476,13.7972503 260.329055,13.6666667 260.5,13.6666667 C260.670945,13.6666667 260.809524,13.7972503 260.809524,13.9583333 L260.809524,19.7916667 Z M262.666667,19.2083333 C262.666667,19.3694164 262.528088,19.5 262.357143,19.5 C262.186198,19.5 262.047619,19.3694164 262.047619,19.2083333 L262.047619,14.5416667 C262.047619,14.3805836 262.186198,14.25 262.357143,14.25 C262.528088,14.25 262.666667,14.3805836 262.666667,14.5416667 L262.666667,19.2083333 Z M257.888114,10.75 L258.138952,9.80435833 C258.173223,9.67438853 258.297131,9.58319016 258.439252,9.58333316 L262.560686,9.58333316 C262.702807,9.58319016 262.826715,9.67438853 262.860986,9.80435833 L263.111886,10.75 L257.888114,10.75 Z"
                          id="Shape"
                        />
                      </g>
                    </g>
                  </g>
                </g>
              </g>
            </svg>
          </span>
          <span className="modal__instructor--student">
            <p>Matija Luketin</p>
            <svg
              className="modal__icon--delete"
              xmlns="http://www.w3.org/2000/svg"
              width="13px"
              height="14px"
              viewBox="0 0 13 14"
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
                  id="Raspored-uredi(3)"
                  transform="translate(-336.000000, -434.000000)"
                  fill="#EB3349"
                  fillRule="nonzero"
                >
                  <g id="Group-7">
                    <g
                      id="Group-6"
                      transform="translate(17.000000, 134.000000)"
                    >
                      <g
                        id="Group-2"
                        transform="translate(65.000000, 291.000000)"
                      >
                        <path
                          d="M266.690476,10.75 L263.75,10.75 L263.461586,9.66278333 C263.358245,9.27326431 262.986836,9 262.560748,9 L258.439252,9 C258.013164,9 257.641755,9.27326431 257.538414,9.66278333 L257.25,10.75 L254.309524,10.75 C254.138579,10.75 254,10.8805836 254,11.0416667 C254,11.2027497 254.138579,11.3333333 254.309524,11.3333333 L255.269048,11.3333333 L255.843833,22.1691583 C255.868795,22.6346527 256.276604,23 256.771229,23 L264.260219,23 C264.755047,23 265.16291,22.6342767 265.187552,22.168575 L265.7624,11.3333333 L266.690476,11.3333333 C266.861421,11.3333333 267,11.2027497 267,11.0416667 C267,10.8805836 266.861421,10.75 266.690476,10.75 Z M258.952381,19.2083333 C258.952381,19.3694164 258.813802,19.5 258.642857,19.5 C258.471912,19.5 258.333333,19.3694164 258.333333,19.2083333 L258.333333,14.5416667 C258.333333,14.3805836 258.471912,14.25 258.642857,14.25 C258.813802,14.25 258.952381,14.3805836 258.952381,14.5416667 L258.952381,19.2083333 Z M260.809524,19.7916667 C260.809524,19.9527497 260.670945,20.0833333 260.5,20.0833333 C260.329055,20.0833333 260.190476,19.9527497 260.190476,19.7916667 L260.190476,13.9583333 C260.190476,13.7972503 260.329055,13.6666667 260.5,13.6666667 C260.670945,13.6666667 260.809524,13.7972503 260.809524,13.9583333 L260.809524,19.7916667 Z M262.666667,19.2083333 C262.666667,19.3694164 262.528088,19.5 262.357143,19.5 C262.186198,19.5 262.047619,19.3694164 262.047619,19.2083333 L262.047619,14.5416667 C262.047619,14.3805836 262.186198,14.25 262.357143,14.25 C262.528088,14.25 262.666667,14.3805836 262.666667,14.5416667 L262.666667,19.2083333 Z M257.888114,10.75 L258.138952,9.80435833 C258.173223,9.67438853 258.297131,9.58319016 258.439252,9.58333316 L262.560686,9.58333316 C262.702807,9.58319016 262.826715,9.67438853 262.860986,9.80435833 L263.111886,10.75 L257.888114,10.75 Z"
                          id="Shape"
                        />
                      </g>
                    </g>
                  </g>
                </g>
              </g>
            </svg>
          </span>
          <span className="modal__instructor--student">
            <p>Matija Luketin</p>
            <svg
              className="modal__icon--delete"
              xmlns="http://www.w3.org/2000/svg"
              width="13px"
              height="14px"
              viewBox="0 0 13 14"
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
                  id="Raspored-uredi(3)"
                  transform="translate(-336.000000, -434.000000)"
                  fill="#EB3349"
                  fillRule="nonzero"
                >
                  <g id="Group-7">
                    <g
                      id="Group-6"
                      transform="translate(17.000000, 134.000000)"
                    >
                      <g
                        id="Group-2"
                        transform="translate(65.000000, 291.000000)"
                      >
                        <path
                          d="M266.690476,10.75 L263.75,10.75 L263.461586,9.66278333 C263.358245,9.27326431 262.986836,9 262.560748,9 L258.439252,9 C258.013164,9 257.641755,9.27326431 257.538414,9.66278333 L257.25,10.75 L254.309524,10.75 C254.138579,10.75 254,10.8805836 254,11.0416667 C254,11.2027497 254.138579,11.3333333 254.309524,11.3333333 L255.269048,11.3333333 L255.843833,22.1691583 C255.868795,22.6346527 256.276604,23 256.771229,23 L264.260219,23 C264.755047,23 265.16291,22.6342767 265.187552,22.168575 L265.7624,11.3333333 L266.690476,11.3333333 C266.861421,11.3333333 267,11.2027497 267,11.0416667 C267,10.8805836 266.861421,10.75 266.690476,10.75 Z M258.952381,19.2083333 C258.952381,19.3694164 258.813802,19.5 258.642857,19.5 C258.471912,19.5 258.333333,19.3694164 258.333333,19.2083333 L258.333333,14.5416667 C258.333333,14.3805836 258.471912,14.25 258.642857,14.25 C258.813802,14.25 258.952381,14.3805836 258.952381,14.5416667 L258.952381,19.2083333 Z M260.809524,19.7916667 C260.809524,19.9527497 260.670945,20.0833333 260.5,20.0833333 C260.329055,20.0833333 260.190476,19.9527497 260.190476,19.7916667 L260.190476,13.9583333 C260.190476,13.7972503 260.329055,13.6666667 260.5,13.6666667 C260.670945,13.6666667 260.809524,13.7972503 260.809524,13.9583333 L260.809524,19.7916667 Z M262.666667,19.2083333 C262.666667,19.3694164 262.528088,19.5 262.357143,19.5 C262.186198,19.5 262.047619,19.3694164 262.047619,19.2083333 L262.047619,14.5416667 C262.047619,14.3805836 262.186198,14.25 262.357143,14.25 C262.528088,14.25 262.666667,14.3805836 262.666667,14.5416667 L262.666667,19.2083333 Z M257.888114,10.75 L258.138952,9.80435833 C258.173223,9.67438853 258.297131,9.58319016 258.439252,9.58333316 L262.560686,9.58333316 C262.702807,9.58319016 262.826715,9.67438853 262.860986,9.80435833 L263.111886,10.75 L257.888114,10.75 Z"
                          id="Shape"
                        />
                      </g>
                    </g>
                  </g>
                </g>
              </g>
            </svg>
          </span>
        </div>

        <div className="modal__input--wrapper modal__input--wrapper--bottom">
          <button className="modal__button--empty">Poništi</button>
          <button className="modal__button--blue">Spremi</button>
        </div>
      </aside>
    );
  }
}