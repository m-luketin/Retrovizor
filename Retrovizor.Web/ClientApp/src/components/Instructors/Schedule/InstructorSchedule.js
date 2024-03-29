import React, { Component } from "react";
import InstructorAddEventModal from "./InstructorAddEventModal";
import InstructorDetailsModal from "./InstructorDetailsModal";
// SVG import
import GrayPlus from "../../../assets/GrayPlus.svg";
import HeaderArrow from "../../../assets/HeaderArrow.svg";
import WhiteArrow from "../../../assets/WhiteArrow.svg";


export default class InstructorSchedule extends Component {
  constructor(props) {
    super(props);
    this.state = {
      addEventModalVisibility: false,
      instructorDetailsModalVisibility: false
    };
  }

  

  handleOpenAddEventModal = () => {
    document.getElementsByTagName("body")[0].classList.add("o-hidden");
    this.setState({ addEventModalVisibility: true });
  };

  handleCloseAddEventModal = () => {
    document.getElementsByTagName("body")[0].classList.remove("o-hidden");
    this.setState({ addEventModalVisibility: false });
  };

  handleOpenInstructorDetailsModal = () => {
    document.getElementsByTagName("body")[0].classList.add("o-hidden");
    this.setState({ instructorDetailsModalVisibility: true });
  };

  handleCloseInstructorDetailsModal = () => {
    document.getElementsByTagName("body")[0].classList.remove("o-hidden");
    this.setState({ instructorDetailsModalVisibility: false });
  };

  render() {
    const {
      addEventModalVisibility,
      instructorDetailsModalVisibility
    } = this.state;

    return (
      <React.Fragment>
        <header className="header">
          <h1 className="header__title">Raspored</h1>
          <div>
            <img
              onClick={this.handleOpenAddEventModal}
              className="header__icon--plus"
              alt="Plus"
              src={GrayPlus}
            />
          </div>
        </header>

        <main className="main main__admin--schedule">
          {/* for search by date */}
          <div className="instructor__item--schedule instructor__item--schedule--admin">
            <img
              className="intructor__item--arrow"
              alt="Strelica"
              src={HeaderArrow}
            />
            <h3 className="instructor__schedule--date">Srijeda,</h3>
            <p className="instructor__schedule--day">17. srpnja</p>
          </div>
          {/* main__button--schedule--admin is for search by date - remove if its not search by date */}
          <button
            onClick={this.handleOpenInstructorDetailsModal}
            className="main__button main__button--schedule main__button--schedule--admin"
          >
            <div className="instructor__schedule--time">
              <h3>08:30</h3>
            </div>
            <span>
              <p className="button__info">Matija Luketin</p>
              <p className="button__info">Požeška 12, Split</p>
            </span>
            <img
              className="main__button--arrow button__garbage"
              alt="Strelica"
              src={WhiteArrow}
            />
          </button>

          <button
            onClick={this.handleOpenInstructorDetailsModal}
            className="main__button main__button--schedule instructor__schedule--exam"
          >
            <div className="instructor__schedule--time">
              <h3>10:15</h3>
            </div>
            <span>
              <p className="button__info">Nino Borović</p>
              <p className="button__info">Ispit</p>
            </span>
            <img
              className="main__button--arrow button__garbage"
              alt="Strelica"
              src={WhiteArrow}
            />
          </button>

          <button
            onClick={this.handleOpenInstructorDetailsModal}
            className="main__button main__button--schedule instructor__schedule--free"
          >
            <div className="brc-blue instructor__schedule--time ">
              <h3>11:15</h3>
            </div>
            <p className="button__info">Slobodno</p>
            <img
              className="button__info--arrow button__garbage"
              alt="Strelica"
              src={HeaderArrow}
            />
          </button>
        </main>
        {addEventModalVisibility ? (
          <InstructorAddEventModal
            onCloseAddEventModal={this.handleCloseAddEventModal}
          />
        ) : null}
        {instructorDetailsModalVisibility ? (
          <InstructorDetailsModal
            onCloseInstructorDetailsModal={
              this.handleCloseInstructorDetailsModal
            }
          />
        ) : null}
      </React.Fragment>
    );
  }
}
