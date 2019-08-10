import React, { Component } from "react";
import { withFormik } from "formik";
import * as Yup from "yup";
import Input from "../../Input";
import {
  getFirstName,
  getLastName,
  formatPhoneNumber,
  authorizedRequest
} from "../../utils";
// SVG import
import Person from "../../../assets/Person.svg";
import Phone from "../../../assets/Phone.svg";

class StudentAddModal extends Component {
  render() {
    const {
      onCloseAddModal,
      values,
      errors,
      touched,
      handleSubmit,
      submitting
    } = this.props;

    return (
      <aside>
        <section className="modal--wrapper">
          <h3 className="modal__title">Dodaj kandidata</h3>
          <div className="modal__input--wrapper">
            <img className="modal__icon--name" alt="Osoba" src={Person} />
            <Input
              type="text"
              name="fullName"
              label="Ime i prezime"
              value={values.fullName}
              error={errors.fullName}
            />
          </div>
          <div className="modal__input--wrapper">
            <img className="modal__icon--phone" alt="Telefon" src={Phone} />
            <Input
              type="text"
              name="contact"
              label="Kontakt"
              value={values.contact}
              error={errors.contact}
            />
          </div>
          <div className="modal__input--wrapper">
            <p className="modal__icon--category">B</p>
            <Input
              type="text"
              name="category"
              label="Kategorija"
              value={values.category}
              error={errors.category}
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
      category: ""
    };
  },

  validationScheme: Yup.object().shape({
    fullName: Yup.string()
      .required("Obavezno")
      .min(5, "Najmanje 5 znakova")
      .max(30, "Najviše 30 znakova"),
    contact: Yup.string()
      .required("Obavezno")
      .min(9, "Najmanje 9 znakova")
      .max(14, "Najviše 14 znakova"),
    category: Yup.string()
      .required("Obavezno")
      .min(1, "Najmanje 1 znak")
      .max(5, "Najviše 5 znakova")
  }),

  handleSubmit(values, { resetForm }) {
    const student = {
      firstName: getFirstName(values.fullName),
      lastName: getLastName(values.fullName),
      category: values.category,
      user: {
        phoneNumber: formatPhoneNumber(values.contact)
      }
    };

    authorizedRequest("/api/student/add", "post", student).then(resetForm());
  }
})(StudentAddModal);
