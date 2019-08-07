import React, { Component } from "react";
import { Container } from "reactstrap";
import Navigation from "./Navigation/Navigation";
import "./Common.css";

export class Layout extends Component {
  static displayName = Layout.name;

  render() {
    return (
      <div>
        <Navigation location={window.location.href} />
        <Container>{this.props.children}</Container>
      </div>
    );
  }
}
