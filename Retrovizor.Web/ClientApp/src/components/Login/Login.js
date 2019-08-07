import React, { Component } from "react";
import "./Login.css";
// SVG import
import Logo from "../../assets/Logo.svg";

export default class Login extends Component {
  constructor(props) {
    super(props);
    this.state = {
      inputFocused: false
    };
  }

  handleInputFocus = () => {
    this.setState({ inputFocused: true });
  };

  handleInputBlur = () => {
    this.setState({ inputFocused: false });
  };

  render() {
    const { inputFocused } = this.state;
    const { handleInputFocus, handleInputBlur } = this;

    return (
      <main className="main">
        <div className="main__login-container">
          <img className="login-container__logo" alt="Logo" src={Logo} />
          <form className="login-container__login-form">
            <div className="login-form__field">
              <div
                class={`field__border-overlay ${
                  inputFocused
                    ? "field__border-overlay--focused"
                    : "field__border-overlay--delay"
                }`}
              />
              <label
                forhtml="username"
                className={`field__label ${
                  inputFocused ? "field__label--focused" : ""
                }`}
              >
                Korisničko ime
              </label>
              <input
                type="text"
                name="username"
                className="field__input"
                onFocus={handleInputFocus}
                onBlur={handleInputBlur}
              />
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
