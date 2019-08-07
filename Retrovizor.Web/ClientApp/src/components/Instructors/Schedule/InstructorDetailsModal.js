import React, { Component } from "react";
// SVG import
import Calendar from "../../../assets/Calendar.svg";
import Clock from "../../../assets/Clock.svg";
import Person from "../../../assets/Person.svg";
import GrayPointer from "../../../assets/GrayPointer.svg";
import FullTick from "../../../assets/FullTick.svg";
import OutlineTick from "../../../assets/OutlineTick.svg";

export default class InstructorDetailsModal extends Component {
  render() {
    return (
      <aside className="modal--wrapper">
        <div className="modal__input--wrapper">
          <img
            className="modal__icon--calendar"
            alt="Kalendar"
            src={Calendar}
          />
          <div className="modal__instructor--wrapper">
            <input type="text" placeholder="Datum" />
          </div>
        </div>
        <div className="modal__input--wrapper">
          <img className="instructor__item--clock" alt="Sat" src={Clock} />
          <div className="modal__instructor--wrapper">
            <input type="text" placeholder="Vrijeme" />
          </div>
        </div>
        <div className="modal__input--wrapper">
          <img className="instructor__item--person" alt="Osoba" src={Person} />
          <div className="modal__instructor--wrapper">
            <input type="text" placeholder="Kandidat" />
          </div>
        </div>
        <div className="modal__input--wrapper">
          <img
            className="instructor__item--pointer"
            alt="Pointer"
            src={GrayPointer}
          />
          <div className="modal__instructor--wrapper">
            <input type="text" placeholder="Lokacija" />
          </div>
        </div>
        <img alt="Je ispit" src={FullTick} />
        {/* <img alt="Nije ispit" src={OutlineTick} /> */}
        <p className="modal__instructor--label">Ispit</p>
      </aside>
    );
  }
}
