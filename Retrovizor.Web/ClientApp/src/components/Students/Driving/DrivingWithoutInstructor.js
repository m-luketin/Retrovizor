import React, { Component } from "react";
import { Link } from "react-router-dom";
// SVG import
import BluePlus from "../../../assets/BluePlus.svg";

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
          <Link to="/kandidat/voznja/instruktori">
            <div className="main__driving">
              <button className="main__button main__button--schedule main__button--driving main__button--driving--add main__button--driving--nothing">
                <img alt="Plus" src={BluePlus} />
                <h3>Odaberi instruktora</h3>
              </button>
            </div>
          </Link>
        </section>
      </main>
    );
  }
}
