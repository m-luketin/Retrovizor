import React, { Component } from "react";
import "./Settings.css";
// SVG import
import HeaderArrow from "../../assets/HeaderArrow.svg";
import WhiteArrow from "../../assets/WhiteArrow.svg";
import Lock from "../../assets/Lock.svg";
import Bell from "../../assets/Bell.svg";
import Shield from "../../assets/Shield.svg";
import Info from "../../assets/Info.svg";
import Logout from "../../assets/Logout.svg";

export default class Settings extends Component {
  returnToLastPage = () => {
    this.props.history.goBack();
  };

  render() {
    return (
      <React.Fragment>
        <header onClick={this.returnToLastPage}>
          <img className="header__arrow" alt="Strelica" src={HeaderArrow} />
          <h1 className="header__title header__title--blue">Postavke</h1>
        </header>

        <main>
          <button className="main__button">
            <img className="main__button--lock" alt="Lokot" src={Lock} />
            <h3 className="main__button--description">Privatnost</h3>
            <img
              className="main__button--arrow"
              alt="Strelica"
              src={WhiteArrow}
            />
          </button>

          <button className="main__button">
            <img className="main__button--bell" alt="Zvono" src={Bell} />
            <h3 className="main__button--description">Obavijesti</h3>
            <img
              className="main__button--arrow"
              alt="Strelica"
              src={WhiteArrow}
            />
          </button>

          <button className="main__button">
            <img className="main__button--shield" alt="Stit" src={Shield} />
            <h3 className="main__button--description">Sigurnosti</h3>
            <img
              className="main__button--arrow"
              alt="Strelica"
              src={WhiteArrow}
            />
          </button>

          <button className="main__button">
            <img className="main__button--info" alt="Info" src={Info} />
            <h3 className="main__button--description">
              Uvjeti i pravila o zaštiti privatnosti
            </h3>
            <img
              className="main__button--arrow"
              alt="Strelica"
              src={WhiteArrow}
            />
          </button>

          <figure className="logout">
            <img alt="Logout" src={Logout} />
            <figcaption>Logout</figcaption>
          </figure>
        </main>
      </React.Fragment>
    );
  }
}
