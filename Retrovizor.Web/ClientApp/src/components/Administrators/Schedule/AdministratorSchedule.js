import React, { Component } from "react";
import EventAddModal from "./EventAddModal";
// SVG import
import Calendar from "../../../assets/Calendar.svg";
import GrayPlus from "../../../assets/GrayPlus.svg";
import HeaderArrow from "../../../assets/HeaderArrow.svg";
import { isUserValid } from "../../PrivateRoute";

export default class AdministratorSchedule extends Component {
  constructor(props) {
    super(props);
    this.state = {
      addModalVisibility: false
    };
  }

  componentDidMount() {
    isUserValid();
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
          <h1 className="header__title">Raspored</h1>
          <div>
            <img
              className="header__icon header__icon--calendar"
              alt="Kalendar"
              src={Calendar}
            />
            <img
              onClick={this.handleOpenAddModal}
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
          <button className="main__button main__button--schedule main__button--schedule--admin">
            <div>
              <span className="button__date">23</span>
              <br />
              <span className="button__month">STU</span>
            </div>
            <p className="button__info">14. sat prometnih propisa</p>
          </button>

          <button className="main__button main__button--schedule">
            <div>
              <span className="button__date">24</span>
              <br />
              <span className="button__month">STU</span>
            </div>
            <p className="button__info">15. sat prometnih propisa</p>
          </button>

          <button className="main__button main__button--schedule main__button--green">
            <div>
              <span className="button__date">04</span>
              <br />
              <span className="button__month">PRO</span>
            </div>
            <span>
              <p className="button__info">Ispit iz vožnje!</p>
              <p className="button__info">Luka Bendić</p>
            </span>
          </button>
        </main>
        {addModalVisibility ? (
          <EventAddModal onCloseAddModal={this.handleCloseAddModal} />
        ) : null}
      </React.Fragment>
    );
  }
}
