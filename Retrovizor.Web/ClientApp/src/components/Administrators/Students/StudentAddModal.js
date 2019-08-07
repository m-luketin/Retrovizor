import React, { Component } from "react";
// SVG import
import Person from "../../../assets/Person.svg";
import Phone from "../../../assets/Phone.svg";

export default class StudentAddModal extends Component {
  render() {
    const { onCloseAddModal } = this.props;

    return (
      <aside>
        <section className="modal--wrapper">
          <h3 className="modal__title">Dodaj kandidata</h3>
          <div className="modal__input--wrapper">
            <img className="modal__icon--name" alt="Osoba" src={Person} />
            <input type="text" placeholder="Ime i prezime" />
          </div>
          <div className="modal__input--wrapper">
            <img className="modal__icon--phone" alt="Telefon" src={Phone} />
            <input type="text" placeholder="Kontakt" />
          </div>
          <div className="modal__input--wrapper">
            <p className="modal__icon--category">B</p>
            <input type="text" placeholder="Kategorija" />
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
