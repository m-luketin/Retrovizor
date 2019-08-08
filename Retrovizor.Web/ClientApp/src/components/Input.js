import React, { Component } from "react";
import { Field } from "formik";

class Input extends Component {
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
    const { props, handleInputFocus, handleInputBlur } = this;
    const { inputFocused } = this.state;

    return (
      <div className="login-form__field">
        <div
          className={`field__border-overlay ${
            inputFocused
              ? "field__border-overlay--focused"
              : "field__border-overlay--delay"
          }`}
        />
        <label
          forhtml={props.name}
          className={`field__label ${
            inputFocused ? "field__label--focused" : ""
          }`}
        >
          {props.label}
        </label>
        <Field
          type={props.type}
          name={props.name}
          render={({ field }) => (
            <input
              {...field}
              className={props.styles}
              onFocus={handleInputFocus}
              onBlur={handleInputBlur}
            />
          )}
        />
        <span className="field__error">{props.error}</span>
      </div>
    );
  }
}

export default Input;
