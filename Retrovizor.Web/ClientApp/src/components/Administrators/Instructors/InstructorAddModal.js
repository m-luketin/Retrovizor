import React, { Component } from "react";
import "./InstructorModals.css";
// SVG import
import Person from "../../../assets/Person.svg";
import Phone from "../../../assets/Phone.svg";
import NormalCar from "../../../assets/NormalCar.svg";
import Calendar from "../../../assets/Calendar.svg";

export default class InstructorAddModal extends Component {
  render() {
    return (
      <aside className="modal--wrapper">
        <h3 className="modal__title">Dodaj instruktora</h3>
        <div className="modal__input--wrapper">
          <img className="modal__icon--name" alt="Osoba" src={Person} />
          <input type="text" placeholder="Ime i prezime" />
        </div>
        <div className="modal__input--wrapper">
          <img className="modal__icon--phone" alt="Telefon" src={Phone} />
          <input type="text" placeholder="Kontakt" />
        </div>
        <div className="modal__input--wrapper">
          <img className="modal__icon--car" alt="Auto" src={NormalCar} />
          <input className="modal__input--car" type="text" placeholder="Auto" />
          <img
            className="modal__icon--calendar"
            alt="Kalendar"
            src={Calendar}
          />
          <input
            className="modal__input--year"
            type="number"
            placeholder="Godina"
          />
        </div>

        <div className="modal__input--wrapper modal__input--wrapper--bottom">
          <button className="modal__button--empty">Poništi</button>
          <button className="modal__button--blue">Spremi</button>
        </div>
      </aside>
    );
  }
}
