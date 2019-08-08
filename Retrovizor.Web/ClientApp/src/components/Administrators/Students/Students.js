import React, { Component } from "react";
import { Link } from "react-router-dom";
import StudentAddModal from "./StudentAddModal";
import "./Students.css";
import "./StudentModals.css";
// SVG import
import profileImg from "../../../assets/Instructor.gif";
import GrayPlus from "../../../assets/GrayPlus.svg";
import WhiteArrow from "../../../assets/WhiteArrow.svg";

export default class Students extends Component {
  constructor(props) {
    super(props);
    this.state = {
      addModalVisibility: false
    };
  }

  handleOpenAddModal = () => {
    document.getElementsByTagName("body")[0].classList.add("o-hidden");
    this.setState({ addModalVisibility: true });
  };

  handleCloseAddModal = () => {
    document.getElementsByTagName("body")[0].classList.remove("o-hidden");
    this.setState({ addModalVisibility: false });
  };

  render() {
    const { addModalVisibility } = this.state;

    return (
      <React.Fragment>
        <header className="header">
          <h1 className="header__title">Kandidati</h1>
          <img
            onClick={this.handleOpenAddModal}
            className="header__icon--plus"
            alt="Plus"
            src={GrayPlus}
          />
        </header>
        <main className="main">
          <Link to="/administrator/kandidati/kandidat">
            <figure className="main__candidate">
              <img
                className="candidate__icon"
                src={profileImg}
                alt="Kandidat"
              />
              <figcaption>
                <h2 className="candidate__name">Luka Bendić</h2>
                <p className="candidate__lessons">12/35 sati</p>
                <img
                  className="main__button--arrow"
                  alt="Strelica"
                  src={WhiteArrow}
                />
              </figcaption>
            </figure>
          </Link>

          <figure className="main__candidate">
            <img className="candidate__icon" src={profileImg} alt="Kandidat" />
            <figcaption>
              <h2 className="candidate__name">Luka Bendić</h2>
              <p className="candidate__lessons">12/35 sati</p>
              <img
                className="main__button--arrow"
                alt="Strelica"
                src={WhiteArrow}
              />
            </figcaption>
          </figure>

          <figure className="main__candidate">
            <img className="candidate__icon" src={profileImg} alt="Kandidat" />
            <figcaption>
              <h2 className="candidate__name">Luka Bendić</h2>
              <p className="candidate__lessons">12/35 sati</p>
              <img
                className="main__button--arrow"
                alt="Strelica"
                src={WhiteArrow}
              />
            </figcaption>
          </figure>

          <figure className="main__candidate">
            <img className="candidate__icon" src={profileImg} alt="Kandidat" />
            <figcaption>
              <h2 className="candidate__name">Luka Bendić</h2>
              <p className="candidate__lessons">12/35 sati</p>
              <img
                className="main__button--arrow"
                alt="Strelica"
                src={WhiteArrow}
              />
            </figcaption>
          </figure>

          <figure className="main__candidate">
            <img className="candidate__icon" src={profileImg} alt="Kandidat" />
            <figcaption>
              <h2 className="candidate__name">Luka Bendić</h2>
              <p className="candidate__lessons">12/35 sati</p>
              <img
                className="main__button--arrow"
                alt="Strelica"
                src={WhiteArrow}
              />
            </figcaption>
          </figure>

          <figure className="main__candidate">
            <img className="candidate__icon" src={profileImg} alt="Kandidat" />
            <figcaption>
              <h2 className="candidate__name">Luka Bendić</h2>
              <p className="candidate__lessons">12/35 sati</p>
              <img
                className="main__button--arrow"
                alt="Strelica"
                src={WhiteArrow}
              />
            </figcaption>
          </figure>
        </main>

        {addModalVisibility ? (
          <StudentAddModal onCloseAddModal={this.handleCloseAddModal} />
        ) : null}
      </React.Fragment>
    );
  }
}
