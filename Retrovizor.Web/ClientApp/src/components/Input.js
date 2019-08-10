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
      <div className={`form__field ${props.login ? "login-form__field" : ""}`}>
        <div
          className={`field__border-overlay ${
            inputFocused || props.value !== ""
              ? "field__border-overlay--focused"
              : "field__border-overlay--delay"
          } ${props.login ? "" : "field__border-overlay--pl-8px"}`}
        />
        <label
          forhtml={props.name}
          className={`field__label ${
            inputFocused || props.value !== ""
              ? `field__label--focused ${
                  props.login ? "" : "field__label--focused--fs-14px"
                }`
              : ""
          } ${
            props.login ? "" : "field__label--fs-17px field__label--pl-10px"
          }`}
        >
          {props.label}
        </label>
        <Field
          name={props.name}
          render={({ field }) => (
            <input
              {...field}
              type={props.type}
              className={props.styles}
              onFocus={handleInputFocus}
              onBlur={handleInputBlur}
            />
          )}
        />
        {props.touched && props.error && (
          <span className="field__error">{props.error}</span>
        )}
      </div>
    );
  }
}

export default Input;
