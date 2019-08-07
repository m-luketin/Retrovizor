import React, { Component } from "react";
import "./Login.css";
// SVG import
import Logo from "../../assets/Logo.svg";

export default class Login extends Component {
  render() {
    return (
      <main className="main">
        <div className="main__login-container">
          <img className="login-container__logo" alt="Logo" src={Logo} />
          <form className="login-container__login-form">
            <div className="login-form__field">
              <label forhtml="username" className="field__label">
                Korisničko ime
              </label>
              <input type="text" name="username" className="field__input" />
            </div>
            <div className="login-form__field">
              <input
                type="password"
                placeholder="Lozinka"
                name="username"
                className="field__input"
              />
            </div>
            <button type="submit" className="field__submit">
              Prijava
            </button>
          </form>
          <p className="login-container__obstacle">
            Imaš poteškoća s prijavom?
            <a className="obstacle__contact"> Obrati nam se.</a>
          </p>
        </div>
      </main>
    );
  }
}
