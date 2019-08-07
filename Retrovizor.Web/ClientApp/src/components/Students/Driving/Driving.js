import React, { Component } from "react";
import DrivingWithLesson from "./DrivingWithLesson";
import DrivingWithoutLesson from "./DrivingWithoutLesson";
import DrivingWithoutInstructor from "./DrivingWithoutInstructor";
import "mapbox-gl/dist/mapbox-gl.css";
import "react-map-gl-geocoder/dist/mapbox-gl-geocoder.css";
import "./Driving.css";

export default class Driving extends Component {
  constructor(props) {
    super(props);
    this.state = {
      doesStudentHaveInstructor: true,
      doesStudentHaveLesson: true
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
