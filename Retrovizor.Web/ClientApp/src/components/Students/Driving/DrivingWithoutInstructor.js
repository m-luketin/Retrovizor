import React, { Component } from "react";
import { Link } from "react-router-dom";

export default class DrivingWithoutInstructor extends Component {
  render() {
    return (
      <main className="main__drive">
        <section className="main__map">
          <p className="main__map--text main__map--text--lines">
            Za korištenje ove značajke potrebno je odabrati instruktora.
          </p>
        </section>
        <section className="main__next--lesson--wrapper">
          <h3 className="main__next--lesson">Sljedeći termin:</h3>
          <Link to="/kandidat/voznja/administrator/instruktori">
            <div className="main__driving">
              <button className="main__button main__button--schedule main__button--driving main__button--driving--add main__button--driving--nothing">
                <svg
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
                      id="Budicon-Solid/Interface/plus-ui"
                      fill="#1488CC"
                      fillRule="nonzero"
                    >
                      <path
                        d="M25,12.5 C25,12.9060917 24.6707976,13.2352941 24.2647059,13.2352941 L13.2352941,13.2352941 L13.2352941,24.2647059 C13.2352941,24.6707976 12.9060917,25 12.5,25 C12.0939083,25 11.7647059,24.6707976 11.7647059,24.2647059 L11.7647059,13.2352941 L0.735294118,13.2352941 C0.32920239,13.2352941 0,12.9060917 0,12.5 C0,12.0939083 0.32920239,11.7647059 0.735294118,11.7647059 L11.7647059,11.7647059 L11.7647059,0.735294118 C11.7647059,0.32920239 12.0939083,0 12.5,0 C12.9060917,0 13.2352941,0.32920239 13.2352941,0.735294118 L13.2352941,11.7647059 L24.2647059,11.7647059 C24.6707976,11.7647059 25,12.0939083 25,12.5 Z"
                        id="Shape"
                      />
                    </g>
                  </g>
                </svg>
                <h3>Odaberi instruktora</h3>
              </button>
            </div>
          </Link>
        </section>
      </main>
    );
  }
}
