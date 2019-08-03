import React, { Component } from "react";
import "./Schedule.css";

export default class Schedule extends Component {
  render() {
    return (
      <React.Fragment>
        <header className="header">
          <h1 className="header__title">Raspored</h1>
          <button>
            <svg
              className="header__icon header__icon--calendar"
              xmlns="http://www.w3.org/2000/svg"
              width="24px"
              height="23px"
              viewBox="0 0 24 23"
              version="1.1"
            >
              <g
                id="Polaznik"
                stroke="none"
                strokeWidth="1"
                fill="none"
                fillRule="evenodd"
              >
                <g
                  id="Raspored-određeni-dan(1)"
                  transform="translate(-373.000000, -63.000000)"
                  fill="#8B959E"
                  fillRule="nonzero"
                >
                  <g
                    id="Budicon-Outline/Writing/grid-view"
                    transform="translate(373.000000, 62.000000)"
                  >
                    <path
                      d="M24,3.84 L24,7.68 L0,7.68 L0,3.84 C0,3.30980664 0.42980664,2.88 0.96,2.88 L5.76,2.88 L5.76,1.44 C5.76,1.17490332 5.97490332,0.96 6.24,0.96 C6.50509668,0.96 6.72,1.17490332 6.72,1.44 L6.72,2.88 L17.28,2.88 L17.28,1.44 C17.28,1.17490332 17.4949033,0.96 17.76,0.96 C18.0250967,0.96 18.24,1.17490332 18.24,1.44 L18.24,2.88 L23.04,2.88 C23.5701934,2.88 24,3.30980664 24,3.84 Z M0,8.64 L24,8.64 L24,23.04 C24,23.5701934 23.5701934,24 23.04,24 L0.96,24 C0.42980664,24 0,23.5701934 0,23.04 L0,8.64 Z M17.28,13.44 L19.2,13.44 L19.2,11.52 L17.28,11.52 L17.28,13.44 Z M12.48,13.44 L14.4,13.44 L14.4,11.52 L12.48,11.52 L12.48,13.44 Z M9.6,18.24 L11.52,18.24 L11.52,16.32 L9.6,16.32 L9.6,18.24 Z M4.8,18.24 L6.72,18.24 L6.72,16.32 L4.8,16.32 L4.8,18.24 Z"
                      id="Shape"
                    />
                  </g>
                </g>
              </g>
            </svg>
          </button>
        </header>

        <main className="main">
          <button className="main__button main__button--schedule">
            <div>
              <span className="button__date">23</span>
              <br />
              <span className="button__month">STU</span>
            </div>
            <p className="button__info">14. sat prometnih propisa</p>
          </button>

          <button className="main__button main__button--schedule">
            <div>
              <span className="button__date">24</span>
              <br />
              <span className="button__month">STU</span>
            </div>
            <p className="button__info">15. sat prometnih propisa</p>
          </button>

          <button className="main__button main__button--schedule main__button--green">
            <div>
              <span className="button__date">04</span>
              <br />
              <span className="button__month">PRO</span>
            </div>
            <p className="button__info">Ispit iz prometnih propisa!</p>
          </button>
        </main>
      </React.Fragment>
    );
  }
}
