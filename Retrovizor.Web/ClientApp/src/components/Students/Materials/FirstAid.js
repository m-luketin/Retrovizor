import React, { Component } from "react";
import { Link } from "react-router-dom";
import "./MaterialsContent.css";
// SVG import
import HeaderArrow from "../../../assets/HeaderArrow.svg";
import WhiteArrow from "../../../assets/WhiteArrow.svg";
import Exclimation from "../../../assets/Exclimation.svg";


export default class FirstAid extends Component {
  

  render() {
    return (
      <React.Fragment>
        <header>
          <Link to="/kandidat/materijali">
            <img className="header__arrow" alt="Strelica" src={HeaderArrow} />
            <h1 className="header__title header__title--blue">Prva pomoć</h1>
          </Link>
        </header>

        <main>
          <button className="main__button main__button--green">
            <img
              className="main__button--exclimation"
              alt="Usklicnik"
              src={Exclimation}
            />
            <h3 className="main__button--description">
              Probni ispit iz prve pomoći
            </h3>
            <img
              className="main__button--arrow"
              alt="Strelica"
              src={WhiteArrow}
            />
          </button>

          <button className="main__button">
            <h1 className="main__button--number">1.</h1>
            <h3 className="main__button--description">Lanac spašavanja</h3>
            <img
              className="main__button--arrow"
              alt="Strelica"
              src={WhiteArrow}
            />
          </button>

          <button className="main__button">
            <h1 className="main__button--number">2.</h1>
            <h3 className="main__button--description">
              Uklanjanje odjeće i obuće s umesrećenog
            </h3>
            <img
              className="main__button--arrow"
              alt="Strelica"
              src={WhiteArrow}
            />
          </button>

          <button className="main__button">
            <h1 className="main__button--number">3.</h1>
            <h3 className="main__button--description">
              Pružanje umjetnog disanja
            </h3>
            <img
              className="main__button--arrow"
              alt="Strelica"
              src={WhiteArrow}
            />
          </button>

          <button className="main__button">
            <h1 className="main__button--number">4.</h1>
            <h3 className="main__button--description">Opekline</h3>
            <img
              className="main__button--arrow"
              alt="Strelica"
              src={WhiteArrow}
            />
          </button>

          <button className="main__button">
            <h1 className="main__button--number">5.</h1>
            <h3 className="main__button--description">
              Pomoć pri gniječenim ozljedama
            </h3>
            <img
              className="main__button--arrow"
              alt="Strelica"
              src={WhiteArrow}
            />
          </button>
        </main>
      </React.Fragment>
    );
  }
}
