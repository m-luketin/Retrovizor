import React, { Component } from "react";
import "./Login.css";

export default class Login extends Component {
  render() {
    return (
      <main class="main">
        <div class="main__login-container">
          <img
            src="./assets/images/logo.svg"
            alt="Logo"
            class="login-container__logo"
          />
          <form class="login-container__login-form">
            <div class="login-form__field">
              <label for="username" class="field__label">
                Korisničko ime
              </label>
              <input type="text" name="username" class="field__input" />
            </div>
            <div class="login-form__field">
              <input
                type="password"
                placeholder="Lozinka"
                name="username"
                class="field__input"
              />
            </div>
            <button type="submit" class="field__submit">
              Prijava
            </button>
          </form>
          <p class="login-container__obstacle">
            Imaš poteškoća s prijavom?
            <a class="obstacle__contact"> Obrati nam se.</a>
          </p>
        </div>
      </main>
    );
  }
}
