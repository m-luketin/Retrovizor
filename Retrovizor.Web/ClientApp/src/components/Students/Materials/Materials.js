import React, { Component } from "react";
import { Link } from "react-router-dom";
import "./Materials.css";
// SVG import
import WhiteArrow from "../../../assets/WhiteArrow.svg";
import WhiteSpeedyCar from "../../../assets/WhiteSpeedyCar.svg";
import WhiteBus from "../../../assets/WhiteBus.svg";
import Heart from "../../../assets/Heart.svg";


export default class Materials extends Component {
  

  render() {
    return (
      <React.Fragment>
        <header>
          <h1 className="header__title">Materijali</h1>
        </header>

        <main>
          <Link to="/kandidat/materijali/propisi">
            <button className="main__button--big bc-blue">
              <div className="main__button--images">
                <img
                  className="main__button--car"
                  alt="Auto"
                  src={WhiteSpeedyCar}
                />
                <img className="main__button--bus" alt="Bus" src={WhiteBus} />
              </div>

              <div className="main__button--text">
                <h3>Prometni propisi</h3>
                <p>Pitanja i probni ispiti iz prometnih propisa</p>
              </div>

              <img
                className="main__button--arrow"
                alt="Strelica"
                src={WhiteArrow}
              />
            </button>
          </Link>

          <Link to="/kandidat/materijali/prva-pomoc">
            <button className="main__button--big bc-red">
              <img
                className="main__button--images main__button--heart"
                alt="Srce"
                src={Heart}
              />
              <div className="main__button--text">
                <h3>Prva pomoć</h3>
                <p>Pitanja i probni ispiti iz prve pomoći</p>
              </div>
              <img
                className="main__button--arrow"
                alt="Strelica"
                src={WhiteArrow}
              />
            </button>
          </Link>
        </main>
      </React.Fragment>
    );
  }
}
