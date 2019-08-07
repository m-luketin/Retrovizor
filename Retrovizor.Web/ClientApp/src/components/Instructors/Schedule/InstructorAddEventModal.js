import React, { Component } from "react";
// SVG import
import GrayArrow from "../../../assets/GrayArrow.svg";
import Calendar from "../../../assets/Calendar.svg";
import Clock from "../../../assets/Clock.svg";

export default class InstructorAddEventModal extends Component {
  render() {
    const { onCloseAddEventModal } = this.props;

    return (
      <aside>
        <section className="modal--wrapper">
          <h3 className="modal__title">Dodaj termin</h3>
          <div className="modal__input--wrapper">
            <img
              className="modal__icon--calendar"
              alt="Kalendar"
              src={Calendar}
            />
            <div className="modal__instructor--wrapper">
              <img
                className="modal__instructor--arrow"
                alt="Arrow"
                src={GrayArrow}
              />
              <input type="text" placeholder="Datum" />
            </div>
          </div>
          <div className="modal__input--wrapper">
            <img className="instructor__item--clock" alt="Sat" src={Clock} />
            <div className="modal__instructor--wrapper">
              <img
                className="modal__instructor--arrow"
                alt="Arrow"
                src={GrayArrow}
              />
              <input type="text" placeholder="Vrijeme" />
            </div>
          </div>

          <div className="modal__input--wrapper modal__input--wrapper--bottom">
            <button
              onClick={onCloseAddEventModal}
              className="modal__button--empty"
            >
              Poništi
            </button>
            <button className="modal__button--blue">Spremi</button>
          </div>
        </section>
      </aside>
    );
  }
}
