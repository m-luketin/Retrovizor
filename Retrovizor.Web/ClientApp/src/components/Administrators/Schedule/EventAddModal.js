import React, { Component } from "react";
import "./EventModal.css";
// SVG import
import GrayArrow from "../../../assets/GrayArrow.svg";
import Calendar from "../../../assets/Calendar.svg";
import People from "../../../assets/People.svg";
import Garbage from "../../../assets/Garbage.svg";

export default class EventAddModal extends Component {
  render() {
    const { onCloseAddModal } = this.props;

    return (
      <aside>
        <section className="modal--wrapper">
          <h3 className="modal__title">Dodaj događaj</h3>
          <div className="modal__input--wrapper">
            <div className="modal__instructor--wrapper">
              <img
                className="modal__instructor--arrow"
                alt="Arrow"
                src={GrayArrow}
              />
              <input
                className="modal__event--type"
                type="text"
                placeholder="Tip"
              />
            </div>
            <input
              className="modal__event--number"
              type="number"
              placeholder="Sat"
            />
          </div>
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
            <img className="modal__icon--people" alt="Ljudi" src={People} />
            <div className="modal__instructor--wrapper">
              <img
                className="modal__instructor--arrow"
                alt="Arrow"
                src={GrayArrow}
              />
              <input type="text" placeholder="Kandidati" />
            </div>
          </div>

          <div className="modal__input--wrapper modal__input--right">
            <span className="modal__instructor--student">
              <p>Matija Luketin</p>
              <img
                className="modal__icon--delete"
                alt="Garbage"
                src={Garbage}
              />
            </span>
            <span className="modal__instructor--student">
              <p>Matija Luketin</p>
              <img
                className="modal__icon--delete"
                alt="Garbage"
                src={Garbage}
              />
            </span>
            <span className="modal__instructor--student">
              <p>Matija Luketin</p>
              <img
                className="modal__icon--delete"
                alt="Garbage"
                src={Garbage}
              />
            </span>
            <span className="modal__instructor--student">
              <p>Matija Luketin</p>
              <img
                className="modal__icon--delete"
                alt="Garbage"
                src={Garbage}
              />
            </span>
            <span className="modal__instructor--student">
              <p>Matija Luketin</p>
              <img
                className="modal__icon--delete"
                alt="Garbage"
                src={Garbage}
              />
            </span>
          </div>

          <div className="modal__input--wrapper modal__input--wrapper--bottom">
            <button onClick={onCloseAddModal} className="modal__button--empty">
              Poništi
            </button>
            <button className="modal__button--blue">Spremi</button>
          </div>
        </section>
      </aside>
    );
  }
}
