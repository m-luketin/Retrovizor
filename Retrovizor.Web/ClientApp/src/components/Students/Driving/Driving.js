import React, { Component } from "react";
import "./Driving.css";
import DrivingWithLesson from "./DrivingWithLesson";
import DrivingWithoutLesson from "./DrivingWithoutLesson";
import DrivingWithoutInstructor from "./DrivingWithoutInstructor";

export default class Driving extends Component {
  constructor(props) {
    super(props);
    this.state = {
      doesStudentHaveInstructor: false,
      doesStudentHaveLesson: false
    };
  }
  render() {
    const { doesStudentHaveLesson, doesStudentHaveInstructor } = this.state;

    return (
      <React.Fragment>
        <header>
          <h1 className="header__title">Vožnja</h1>
        </header>
        {doesStudentHaveLesson && doesStudentHaveInstructor ? (
          <DrivingWithLesson />
        ) : doesStudentHaveInstructor ? (
          <DrivingWithoutLesson />
        ) : (
          <DrivingWithoutInstructor />
        )}
      </React.Fragment>
    );
  }
}