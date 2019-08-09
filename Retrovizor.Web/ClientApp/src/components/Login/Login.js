import React from "react";
import "./Login.css";
import { withFormik, Form } from "formik";
import * as Yup from "yup";
import axios from "axios";
import { setTokens } from "../utils";
import Input from "../Input";

// SVG import
import Logo from "../../assets/Logo.svg";

const Login = ({ handleSubmit, errors, touched, isSubmitting }) => (
  <main className="main">
    <div className="main__login-container">
      <img className="login-container__logo" alt="Logo" src={Logo} />
      <Form className="login-container__login-form">
        <Input
          type="text"
          name="username"
          styles="field__input"
          label="Korisničko ime"
          error={errors.username}
        />
        {console.log(errors)}
        <Input
          type="password"
          name="password"
          styles="field__input"
          label="Lozinka"
          error={errors.password}
        />
        <button
          type="submit"
          className="field__submit"
          disabled={isSubmitting}
          onClick={() => handleSubmit()}
        >
          Prijava
        </button>
      </Form>
      <p className="login-container__obstacle">
        Imaš poteškoća s prijavom?
        <a className="obstacle__contact"> Obrati nam se.</a>
      </p>
    </div>
  </main>
);

export default withFormik({
  mapPropsToValues() {
    return {
      username: "",
      password: ""
    };
  },

  validationSchema: Yup.object().shape({
    username: Yup.string().required("Polje je obavezno"),
    password: Yup.string().required("Polje je obavezno")
  }),

  handleSubmit(values, { resetForm }) {
    const userCredentials = {
      username: values.username,
      password: values.password
    };

    resetForm();

    axios
      .post("/api/auth/login", userCredentials)
      .then(res => setTokens(res.data.access, res.data.refresh))
      .catch(err => alert(err));
  }
})(Login);
