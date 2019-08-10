import React, { Component } from "react";
import { Link } from "react-router-dom";
import StudentAddModal from "./StudentAddModal";
import "./Students.css";
import "./StudentModals.css";
// SVG import
import Profile from "../../../assets/Instructor.gif";
import GrayPlus from "../../../assets/GrayPlus.svg";
import WhiteArrow from "../../../assets/WhiteArrow.svg";
import { authorizedRequest } from "../../utils";

export default class Students extends Component {
  constructor(props) {
    super(props);
    this.state = {
      addModalVisibility: false,
      students: null
    };
  }

  componentDidMount() {
    authorizedRequest("/api/student/get-by-driving-school", "get").then(data =>
      this.setState({ ...this.state, students: data })
    );
  }

  handleOpenAddModal = () => {
    document.getElementsByTagName("body")[0].classList.add("o-hidden");
    this.setState({ addModalVisibility: true });
  };

  handleCloseAddModal = () => {
    document.getElementsByTagName("body")[0].classList.remove("o-hidden");
    this.setState({ addModalVisibility: false });
  };

  render() {
    const { addModalVisibility, students } = this.state;

    return (
      <React.Fragment>
        <header className="header">
          <h1 className="header__title">Kandidati</h1>
          <img
            onClick={this.handleOpenAddModal}
            className="header__icon--plus"
            alt="Plus"
            src={GrayPlus}
          />
        </header>
        <main className="main">
          {!students
            ? "Loading"
            : students.map(student => (
                <Link
                  key={student.id}
                  to={`/administrator/kandidati/kandidat/${student.id}`}
                >
                  <figure className="main__candidate">
                    <img
                      className="candidate__icon"
                      src={Profile}
                      alt="Kandidat"
                    />
                    <figcaption>
                      <h2 className="candidate__name">
                        {student.firstName} {student.lastName}
                      </h2>
                      <p className="candidate__lessons">
                        {
                          student.studentClasses[
                            student.studentClasses.length - 1
                          ].currentLesson
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

        {addModalVisibility ? (
          <StudentAddModal onCloseAddModal={this.handleCloseAddModal} />
        ) : null}
      </React.Fragment>
    );
  }
}
