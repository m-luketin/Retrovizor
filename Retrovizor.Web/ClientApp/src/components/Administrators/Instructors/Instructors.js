import React, { Component } from "react";
import { Link } from "react-router-dom";
import InstructorAddModal from "./InstructorAddModal";
import { authorizedRequest } from "../../utils";
import "./Instructors.css";
// SVG import
import Profile from "../../../assets/Instructor.gif";
import GrayPlus from "../../../assets/GrayPlus.svg";
import FullStar from "../../../assets/FullStar.svg";
import OutlineStar from "../../../assets/OutlineStar.svg";

export default class Instructors extends Component {
  constructor(props) {
    super(props);
    this.state = {
      addModalVisibility: false,
      instructors: null
    };
  }

  componentDidMount() {
    authorizedRequest("/api/instructor/get-by-driving-school", "get").then(
      data => this.setState({ ...this.state, instructors: data })
    );
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
    const { addModalVisibility, instructors } = this.state;

    return (
      <React.Fragment>
        <header className="header--instructors">
          <h1 className="header__title">Instruktori</h1>
          <img
            onClick={this.handleOpenAddModal}
            className="header__icon--plus"
            alt="Plus"
            src={GrayPlus}
          />
        </header>
        <main className="main__drive main__instructor--list">
          <section className="main__next--lesson--wrapper">
            {instructors === null
              ? "Loading"
              : instructors.map(instructor => (
                  <div className="main__driving">
                    <img
                      className="main__driving--instructor"
                      src={Profile}
                      alt="Instruktor"
                    />

                    <Link
                      to={`/administrator/instruktori/detalji/${instructor.id}`}
                    >
                      <button
                        key={instructor.id}
                        className="main__button main__button--schedule main__button--driving main__button--instructor"
                      >
                        <span className="button__info">
                          <h3 className="instructor__name">
                            {instructor.firstName} {instructor.lastName}
                          </h3>
                          <p className="instructor__car" />
                          <div className="instructor__stars">
                            <img
                              className="instructor__star"
                              alt="Zvijezda"
                              src={FullStar}
                            />
                            <img
                              className="instructor__star"
                              alt="Zvijezda"
                              src={FullStar}
                            />
                            <img
                              className="instructor__star"
                              alt="Zvijezda"
                              src={FullStar}
                            />
                            <img
                              className="instructor__star"
                              alt="Zvijezda"
                              src={FullStar}
                            />
                            <img
                              className="instructor__star"
                              alt="Zvijezda"
                              src={OutlineStar}
                            />
                          </div>
                        </span>
                      </button>
                    </Link>
                  </div>
                ))}
          </section>

          {addModalVisibility ? (
            <InstructorAddModal onCloseAddModal={this.handleCloseAddModal} />
          ) : null}
        </main>
      </React.Fragment>
    );
  }
}
