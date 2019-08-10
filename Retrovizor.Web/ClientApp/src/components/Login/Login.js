import React from "react";
import "./Login.css";
import { withFormik, Form } from "formik";
import * as Yup from "yup";
import axios from "axios";
import { setTokens } from "../utils";
import Input from "../Input";

// SVG import
import Logo from "../../assets/Logo.svg";

const Login = ({ values, handleSubmit, errors, touched, isSubmitting }) => (
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
          value={values.username}
          login={true}
        />
        <Input
          type="password"
          name="password"
          styles="field__input"
          label="Lozinka"
          error={errors.password}
          value={values.password}
          login={true}
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

  handleSubmit(values, { resetForm, props }) {
    const userCredentials = {
      username: values.username,
      password: values.password
    };

    resetForm();

    axios
      .post("/api/auth/login", userCredentials)
      .then(res => {
        setTokens(res.data.access, res.data.refresh).then(() => {
          const user = window.localStorage.getItem("user");
          props.history.push(`/${user}/profil`);
        });
      })
      .catch(err => alert("Kriva kombinacija imena i šifre"));
  }
})(Login);
