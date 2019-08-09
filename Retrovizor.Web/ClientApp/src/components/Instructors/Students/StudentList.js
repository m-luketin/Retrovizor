import React, { Component } from "react";
import { Link } from "react-router-dom";
// SVG import
import Profile from "../../../assets/Instructor.gif";
import WhiteArrow from "../../../assets/WhiteArrow.svg";
import { authorizedRequest } from "../../utils";

export default class StudentList extends Component {
  constructor(props) {
    super(props);
    this.state = {
      studentsArray: []
    };
  }

  componentDidMount() {
    authorizedRequest(
      `api/Student/get-current-by-instructor/2`,
      "get",
      ""
    ).then(data => {
      this.setState({ studentsArray: data });
      // console.log(data);
    });
  }

  render() {
    const { studentsArray } = this.state;

    return (
      <React.Fragment>
        <header className="header">
          <h1 className="header__title">Kandidati</h1>
        </header>
        <main className="main">
          {studentsArray.map((student, index) => (
            <Link
              key={index}
              to={{
                pathname: "/instruktor/kandidati/kandidat",
                state: { studentToDisplay: student }
              }}
            >
              <figure className="main__candidate">
                <img className="candidate__icon" src={Profile} alt="Kandidat" />
                <figcaption>
                  <h2 className="candidate__name">
                    {student.firstName} {student.lastName}
                  </h2>
                  <p className="candidate__lessons">
                    {
                      student.studentClasses[student.studentClasses.length - 1]
                        .currentLesson
                    }
                    /35 sati
                  </p>
                  <img
                    className="main__button--arrow"
                    alt="Strelica"
                    src={WhiteArrow}
                  />
                </figcaption>
              </figure>
            </Link>
          ))}
        </main>
      </React.Fragment>
    );
  }
}
