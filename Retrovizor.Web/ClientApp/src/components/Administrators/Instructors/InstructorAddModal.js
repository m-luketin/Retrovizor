import React, { Component } from "react";
import Input from "../../Input";
import "./InstructorModals.css";
// SVG import
import Person from "../../../assets/Person.svg";
import Phone from "../../../assets/Phone.svg";
import NormalCar from "../../../assets/NormalCar.svg";
import Calendar from "../../../assets/Calendar.svg";
import { withFormik } from "formik";
import * as Yup from "yup";
import {
  authorizedRequest,
  getFirstName,
  getLastName,
  formatPhoneNumber
} from "../../utils";

class InstructorAddModal extends Component {
  render() {
    const {
      onCloseAddModal,
      values,
      handleSubmit,
      submitting,
      errors
    } = this.props;

    return (
      <aside>
        <section className="modal--wrapper">
          <h3 className="modal__title">Dodaj instruktora</h3>
          <div className="modal__input--wrapper">
            <img className="modal__icon--name" alt="Osoba" src={Person} />
            <Input
              name="fullName"
              type="text"
              label="Ime i prezime"
              value={values.fullName}
              error={errors.fullName}
            />
          </div>
          <div className="modal__input--wrapper">
            <img className="modal__icon--phone" alt="Telefon" src={Phone} />
            <Input
              name="contact"
              type="text"
              label="Kontakt"
              value={values.contact}
              error={errors.contact}
            />
          </div>
          <div className="modal__input--wrapper">
            <img className="modal__icon--car" alt="Auto" src={NormalCar} />
            <Input
              name="car"
              styles="modal__input--car"
              type="text"
              label="Auto"
              value={values.car}
              error={errors.car}
            />
            <img
              className="modal__icon--calendar"
              alt="Kalendar"
              src={Calendar}
            />
            <Input
              name="year"
              styles="modal__input--year"
              type="number"
              label="Godina"
              value={values.year}
              error={errors.year}
            />
          </div>

          <div className="modal__input--wrapper modal__input--wrapper--bottom">
            <button onClick={onCloseAddModal} className="modal__button--empty">
              Poništi
            </button>
            <button
              className="modal__button--blue"
              disabled={submitting}
              onClick={handleSubmit}
            >
              Spremi
            </button>
          </div>
        </section>
      </aside>
    );
  }
}

export default withFormik({
  mapPropsToValues() {
    return {
      fullName: "",
      contact: "",
      car: "",
      year: 0
    };
  },

  validationSchema: Yup.object().shape({
    fullName: Yup.string()
      .required("Obavezno")
      .min(5, "Najmanje 5 znakova")
      .max(30, "Najviše 30 znakova"),
    contact: Yup.string()
      .required("Obavezno")
      .min(9, "Najmanje 9 znakova")
      .max(14, "Najviše 14 znakova"),
    car: Yup.string()
      .required("Obavezno")
      .min(3, "Najmanje 3 znaka")
      .max(25, "Najviše 25 znakova"),
    year: Yup.number("Broj")
      .integer("Cijeli broj")
      .required("Obavezno")
  }),

  handleSubmit(values, { resetForm }) {
    const instructor = {
      firstName: getFirstName(values.fullName),
      lastName: getLastName(values.fullName),
      user: {
        phoneNumber: formatPhoneNumber(values.contact)
      },
      vehicle: {
        model: values.car,
        year: values.year
      }
    };

    resetForm();

    authorizedRequest("api/instructor/add", "post", instructor);
  }
})(InstructorAddModal);
