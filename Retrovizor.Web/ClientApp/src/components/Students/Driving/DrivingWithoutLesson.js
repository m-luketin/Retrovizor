import React, { Component } from "react";
import { Link } from "react-router-dom";
// SVG import
import Profile from "../../../assets/Instructor.gif";
import BluePlus from "../../../assets/BluePlus.svg";

export default class DrivingWithoutLesson extends Component {
  render() {
    return (
      <main className="main__drive">
        <section className="main__map">
          <p className="main__map--text">Nema dodanog sljedećeg termina.</p>
        </section>
        <section className="main__next--lesson--wrapper">
          <h3 className="main__next--lesson">Sljedeći termin:</h3>
          <div className="main__driving">
            <img
              className="main__driving--instructor"
              src={Profile}
              alt="Instruktor"
            />

            <Link to="/kandidat/voznja/instruktor">
              <button className="main__button main__button--schedule main__button--driving main__button--driving--add">
                <img alt="Plus" src={BluePlus} />
                <h3>Dodaj termin</h3>
              </button>
            </Link>
          </div>
        </section>
      </main>
    );
  }
}
