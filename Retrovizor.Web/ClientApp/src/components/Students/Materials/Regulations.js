import React, { Component } from "react";
import { Link } from "react-router-dom";
import "./MaterialsContent.css";
// SVG import
import HeaderArrow from "../../../assets/HeaderArrow.svg";
import WhiteArrow from "../../../assets/WhiteArrow.svg";
import FullHeart from "../../../assets/FullHeart.svg";


export default class Regulations extends Component {
  

  render() {
    return (
      <React.Fragment>
        <header>
          <Link to="/kandidat/materijali">
            <img className="header__arrow" alt="Strelica" src={HeaderArrow} />
            <h1 className="header__title header__title--blue">
              Prometni propisi
            </h1>
          </Link>
        </header>

        <main>
          <button className="main__button main__button--green">
            <img
              className="main__button--exclimation"
              alt="Srce"
              src={FullHeart}
            />
            <h3 className="main__button--description">
              Probni ispit iz prometnih propisa
            </h3>
            <img
              className="main__button--arrow"
              alt="Strelica"
              src={WhiteArrow}
            />
          </button>

          <button className="main__button">
            <h1 className="main__button--number">1.</h1>
            <h3 className="main__button--description">
              Propisi u cestovnom prometu
            </h3>
            <img
              className="main__button--arrow"
              alt="Strelica"
              src={WhiteArrow}
            />
          </button>

          <button className="main__button">
            <h1 className="main__button--number">2.</h1>
            <h3 className="main__button--description">
              Ponašanje sudinika u prometu
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
              Cesta i njena obilježja
            </h3>
            <img
              className="main__button--arrow"
              alt="Strelica"
              src={WhiteArrow}
            />
          </button>

          <button className="main__button">
            <h1 className="main__button--number">4.</h1>
            <h3 className="main__button--description">Znakovi u prometu</h3>
            <img
              className="main__button--arrow"
              alt="Strelica"
              src={WhiteArrow}
            />
          </button>

          <button className="main__button">
            <h1 className="main__button--number">5.</h1>
            <h3 className="main__button--description">
              Ostali sudionici u cestovnom prometu
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
