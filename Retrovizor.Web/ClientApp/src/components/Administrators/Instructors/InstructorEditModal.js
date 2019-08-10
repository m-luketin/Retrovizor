import React, { Component } from "react";
import Input from "../../Input";
import { withFormik } from "formik";
import * as Yup from "yup";
import {
  authorizedRequest,
  formatPhoneNumber,
  getFirstName,
  getLastName
} from "../../utils";
import "./InstructorModals.css";
// SVG import
import Person from "../../../assets/Person.svg";
import Phone from "../../../assets/Phone.svg";
import NormalCar from "../../../assets/NormalCar.svg";
import Calendar from "../../../assets/Calendar.svg";
class InstructorEditModal extends Component {
  componentDidMount() {
    const { id } = this.props;

    authorizedRequest(`api/instructor/get/${id}`, "get").then(data => {
      this.props.setFieldValue(
        "fullName",
        data.firstName + " " + data.lastName
      );
      this.props.setFieldValue("contact", data.user.phoneNumber);
      this.props.setFieldValue(
        "vehicle",
        data.vehicle.manufacturer + " " + data.vehicle.model
      );
      this.props.setFieldValue("year", data.vehicle.year);
    });
  }

  handleDelete = () => {
    const { id } = this.props;

    authorizedRequest(`api/instructor/delete/${id}`, "delete");
  };

  render() {
    const {
      values,
      errors,
      handleSubmit,
      submitting,
      onCloseEditModal
    } = this.props;

    const { handleDelete } = this;

    return (
      <aside>
        <section className="modal--wrapper">
          <h3 className="modal__title">Dodaj instruktora</h3>{" "}
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
              name="vehicle"
              styles="modal__input--car"
              type="text"
              label="Vozilo"
              value={values.vehicle}
              error={errors.vehicle}
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
            <button onClick={onCloseEditModal} className="modal__button--empty">
              Poništi
            </button>

            <button className="modal__button--red" onClick={handleDelete}>
              Obriši
            </button>
          </div>
        </section>
      </aside>
    );
  }
}

export default withFormik({
  enableReinitialize: true,

  mapPropsToValues() {
    return {
      fullName: "",
      contact: "",
      vehicle: "",
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
})(InstructorEditModal);
