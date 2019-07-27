import React, { Component } from "react";
import "../Common.css";
import "./Schedule.css";

export default class Schedule extends Component {
  render() {
    return (
      <React.Fragment>
        <header class="header">
          <h1 class="header__title">Raspored</h1>
          <button>
            <svg
              class="header__icon"
              xmlns="http://www.w3.org/2000/svg"
              width="32px"
              height="32px"
              viewBox="0 0 32 32"
              version="1.1"
            >
              <g
                id="Symbols"
                stroke="none"
                stroke-width="1"
                fill="none"
                fill-rule="evenodd"
              >
                <g
                  id="Budicon-Outline/Writing/grid-view"
                  fill="#8B959E"
                  fill-rule="nonzero"
                >
                  <path
                    d="M5.5,0 L1.5,0 C0.671572875,0 0,0.671572875 0,1.5 L0,6.5 C0,7.32842712 0.671572875,8 1.5,8 L5.5,8 C6.32842712,8 7,7.32842712 7,6.5 L7,1.5 C7,0.671572875 6.32842712,0 5.5,0 Z M14.5,0 L10.5,0 C9.67157288,0 9,0.671572875 9,1.5 L9,6.5 C9,7.32842712 9.67157288,8 10.5,8 L14.5,8 C15.3284271,8 16,7.32842712 16,6.5 L16,1.5 C16,0.671572875 15.3284271,0 14.5,0 Z M23.5,0 L19.5,0 C18.6715729,0 18,0.671572875 18,1.5 L18,6.5 C18,7.32842712 18.6715729,8 19.5,8 L23.5,8 C24.3284271,8 25,7.32842712 25,6.5 L25,1.5 C25,0.671572875 24.3284271,0 23.5,0 Z M5.5,11 L1.5,11 C0.671572875,11 0,11.6715729 0,12.5 L0,17.5 C0,18.3284271 0.671572875,19 1.5,19 L5.5,19 C6.32842712,19 7,18.3284271 7,17.5 L7,12.5 C7,11.6715729 6.32842712,11 5.5,11 Z M14.5,11 L10.5,11 C9.67157288,11 9,11.6715729 9,12.5 L9,17.5 C9,18.3284271 9.67157288,19 10.5,19 L14.5,19 C15.3284271,19 16,18.3284271 16,17.5 L16,12.5 C16,11.6715729 15.3284271,11 14.5,11 Z M23.5,11 L19.5,11 C18.6715729,11 18,11.6715729 18,12.5 L18,17.5 C18,18.3284271 18.6715729,19 19.5,19 L23.5,19 C24.3284271,19 25,18.3284271 25,17.5 L25,12.5 C25,11.6715729 24.3284271,11 23.5,11 Z M5.5,22 L1.5,22 C0.671572875,22 4.4408921e-16,22.6715729 4.4408921e-16,23.5 L4.4408921e-16,28.5 C4.4408921e-16,29.3284271 0.671572875,30 1.5,30 L5.5,30 C6.32842712,30 7,29.3284271 7,28.5 L7,23.5 C7,22.6715729 6.32842712,22 5.5,22 Z M14.5,22 L10.5,22 C9.67157288,22 9,22.6715729 9,23.5 L9,28.5 C9,29.3284271 9.67157288,30 10.5,30 L14.5,30 C15.3284271,30 16,29.3284271 16,28.5 L16,23.5 C16,22.6715729 15.3284271,22 14.5,22 Z M23.5,22 L19.5,22 C18.6715729,22 18,22.6715729 18,23.5 L18,28.5 C18,29.3284271 18.6715729,30 19.5,30 L23.5,30 C24.3284271,30 25,29.3284271 25,28.5 L25,23.5 C25,22.6715729 24.3284271,22 23.5,22 Z"
                    id="Shape"
                  />
                </g>
              </g>
            </svg>
          </button>
        </header>

        <main class="main">
          <button class="main__button main__button--schedule">
            <div>
              <span class="button__date">23</span>
              <br />
              <span class="button__month">STU</span>
            </div>
            <p class="button__info">14. sat prometnih propisa</p>
          </button>

          <button class="main__button main__button--schedule">
            <div>
              <span class="button__date">24</span>
              <br />
              <span class="button__month">STU</span>
            </div>
            <p class="button__info">15. sat prometnih propisa</p>
          </button>

          <button class="main__button main__button--schedule main__button--green">
            <div>
              <span class="button__date">04</span>
              <br />
              <span class="button__month">PRO</span>
            </div>
            <p class="button__info">Ispit iz prometnih propisa!</p>
          </button>
        </main>
      </React.Fragment>
    );
  }
}
