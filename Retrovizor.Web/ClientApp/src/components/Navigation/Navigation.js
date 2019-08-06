import React, { Component } from "react";
import "./Navigation.css";
import StudentNav from "./StudentNav";
import AdministratorNav from "./AdministratorNav";
import InstructorNav from "./InstructorNav";

export default class Navigation extends Component {
  constructor(props) {
    super(props);
    this.state = {
      navDisplay: []
    };
  }

  componentDidMount() {
    this.navDisplayArraySetup(window.location.href);
  }

  componentWillReceiveProps(nextProps) {
    this.navDisplayArraySetup(nextProps.location);
  }

  navDisplayArraySetup = stringToCheck => {
    let { navDisplay } = this.state;
    stringToCheck = window.location.href;

    if (stringToCheck.includes("/kandidat/")) {
      navDisplay = [true, false, false];
    } else if (stringToCheck.includes("/instruktor/")) {
      navDisplay = [false, true, false];
    } else if (stringToCheck.includes("/administrator/")) {
      navDisplay = [false, false, true];
    } else this.setState({ navClass: "d-none" });

    this.setState({ navDisplay });
  };

  render() {
    const { navDisplay } = this.state;

    if (navDisplay[0]) return <StudentNav />;
    else if (navDisplay[1]) return <InstructorNav />;
    else if (navDisplay[2]) return <AdministratorNav />;
    else return null;
  }
}
