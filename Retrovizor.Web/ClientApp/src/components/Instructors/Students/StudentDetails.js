import React, { Component } from "react";
import { Link } from "react-router-dom";
// SVG import
import Profile from "../../../assets/Instructor.gif";
import Phone from "../../../assets/Phone.svg";
import HeaderArrow from "../../../assets/HeaderArrow.svg";
import Clock from "../../../assets/Clock.svg";
import Timeline from "../../../assets/Timeline.svg";
import FullCheckmark from "../../../assets/FullCheckmark.svg";
import RedExclimation from "../../../assets/RedExclimation.svg";
import Pending from "../../../assets/Pending.svg";
import { formatPhoneNumber, getStudentCurrentLesson } from "../../utils";

export default class StudentDetails extends Component {
  constructor(props) {
    super(props);
    this.state = {
      firstAidInfo: { didPass: false, points: 0 },
      drivingInfo: {
        didFinishLessons: false,
        currentLesson: 0,
        didPass: false,
        points: 0
      }
    };
  }

  // componentDidMount() {
  //   this.getClassCountByClassId(1);
  // }

  // getClassCountByClassId = classId => {
  //   let count = 0;

  //   const { studentToDisplay } = this.props.location.state;
  //   studentToDisplay.studentClasses.forEach(event => {
  //     if (event.classId === classId) count++;
  //   });

  //   switch (classId) {
  //     case 1:
  //       this.setState({ regulationsCount: count });
  //       break;
  //     case 2:
  //       this.setState({ firstAidCount: count });
  //       break;

  //     default:
  //       break;
  //   }
  // };

  componentDidMount() {
    if (this.props.location.state === undefined) {
      this.returnToStudentList();
    } else {
      const { studentToDisplay } = this.props.location.state;

      this.setFirstAidState(studentToDisplay);
      this.setDrivingState(studentToDisplay);
    }
  }

  returnToStudentList = () => {
    this.props.history.push("/instruktor/kandidati");
  };

  setFirstAidState = studentToDisplay => {
    const FIRST_AID_EXAM_ID = 2;
    const MINIMUM_POINTS = 40;

    studentToDisplay.studentExams.forEach(exam => {
      if (exam.examId === FIRST_AID_EXAM_ID && exam.points >= MINIMUM_POINTS) {
        this.setState({
          firstAidInfo: { didPass: true, points: exam.points }
        });
      }
    });
  };

  setDrivingState = studentToDisplay => {
    const DRIVING_EXAM_ID = 3;
    const MINIMUM_POINTS = 50;
    const MINIMUM_LESSON_NUMBER = 35;
    const currentLesson = getStudentCurrentLesson(studentToDisplay);

    studentToDisplay.studentExams.forEach(exam => {
      if (exam.examId === DRIVING_EXAM_ID && exam.points >= MINIMUM_POINTS) {
        this.setState({
          drivingInfo: {
            didFinishLessons: true,
            currentLesson: currentLesson,
            didPass: true,
            points: exam.points
          }
        });
      } else if (currentLesson >= MINIMUM_LESSON_NUMBER) {
        this.setState({
          drivingInfo: {
            didFinishLessons: true,
            currentLesson: currentLesson,
            didPass: false,
            points: 0
          }
        });
      } else
        this.setState({
          drivingInfo: {
            didFinishLessons: false,
            currentLesson: currentLesson,
            didPass: false,
            points: exam.points
          }
        });
    });
  };

  render() {
    if (this.props.location.state === undefined) return null;

    const { studentToDisplay } = this.props.location.state;
    const { firstAidInfo, drivingInfo } = this.state;

    return (
      <React.Fragment>
        <header className="header--instructors">
          <Link to="/instruktor/kandidati">
            <img className="header__arrow" alt="Strelica" src={HeaderArrow} />
            <h1 className="header__title header__title--blue">Kandidat</h1>
          </Link>
        </header>
        <main className="main__drive main__instructor">
          <section className="main__next--lesson--wrapper">
            <div className="main__driving mb-20px">
              <img
                className="main__driving--instructor"
                src={Profile}
                alt="Instruktor"
              />

              <button className="main__button main__button--schedule main__button--driving main__button--name">
                <span className="button__info">
                  <h3 className="instructor__name">
                    {studentToDisplay.firstName} {studentToDisplay.lastName}
                  </h3>
                  <span className="profile__category">
                    <span className="profile__category--type">
                      {studentToDisplay.category}
                    </span>
                    kategorija
                  </span>
                </span>
              </button>
            </div>

            <figure className="instructor__item">
              <img
                className="instructor__item--phone"
                alt="Phone"
                src={Phone}
              />
              <div>
                <figcaption className="instructor__item--title">
                  Kontakt
                </figcaption>
                <p className="instructor__item--text c-blue">
                  {formatPhoneNumber(studentToDisplay.user.phoneNumber)}
                </p>
              </div>
            </figure>

            <figure className="instructor__item">
              <img className="instructor__item--clock" alt="Sat" src={Clock} />
              <div>
                <figcaption className="instructor__item--title">Sat</figcaption>
                <p className="instructor__item--text">
                  {getStudentCurrentLesson(studentToDisplay)}
                  /35 sati
                </p>
              </div>
            </figure>
          </section>

          <section className="main__timeline main__student--timeline pl-8px">
            <div className="main__timeline--title">
              <img
                className="timeline__icon"
                alt="Vremenska crta"
                src={Timeline}
              />
              <h3 className="timeline__title">Vremenska crta:</h3>
            </div>

            {/* <img className="item__icon" alt="Checkmark" src={FullCheckmark} />
            <figure className="timeline__item timeline__item--smaller timeline__item--passed">
              <figcaption>
                <h3 className="item__title">Prometni propisi</h3>
                <p className="item__status">15/15 sati</p>
              </figcaption>
            </figure>
            <img className="item__icon" alt="Checkmark" src={FullCheckmark} />
            <figure className="timeline__item timeline__item--smaller timeline__item--passed">
              <figcaption>
                <h3 className="item__title">Ispit iz prometnih propisa</h3>
                <p className="item__status">118/120 bodova</p>
              </figcaption>
            </figure>
            <img className="item__icon" alt="Checkmark" src={FullCheckmark} />
            <figure className="timeline__item timeline__item--smaller timeline__item--passed">
              <figcaption>
                <h3 className="item__title">Prva pomoć</h3>
                <p className="item__status">5/5 sati</p>
              </figcaption>
            </figure> */}

            {firstAidInfo.didPass ? (
              <React.Fragment>
                <img
                  className="item__icon"
                  alt="Puna kvacica"
                  src={FullCheckmark}
                />
                <figure className="timeline__item timeline__item--smaller timeline__item--passed">
                  <figcaption>
                    <h3 className="item__title">Ispit iz prve pomoći</h3>
                    <p className="item__status">
                      {firstAidInfo.points}/60 bodova
                    </p>
                  </figcaption>
                </figure>
              </React.Fragment>
            ) : (
              <React.Fragment>
                <img
                  className="item__icon"
                  alt="Usklicnik"
                  src={RedExclimation}
                />
                <figure className="timeline__item timeline__item--smaller timeline__item--warning">
                  <figcaption>
                    <h3 className="item__title item__title--warning">
                      Ispit iz prve pomoći
                    </h3>
                    <p className="item__status item__status--warning">
                      Nije položeno
                    </p>
                  </figcaption>
                </figure>
              </React.Fragment>
            )}

            {drivingInfo.didPass ? (
              <React.Fragment>
                <img className="item__icon" alt="Kvacica" src={FullCheckmark} />
                <figure className="timeline__item timeline__item--smaller timeline__item--passed">
                  <figcaption>
                    <h3 className="item__title item__title--waiting">
                      Ispit iz vožnje
                    </h3>
                    <p className="item__status item__title--waiting">
                      {drivingInfo.points}/100 bodova
                    </p>
                  </figcaption>
                </figure>
              </React.Fragment>
            ) : drivingInfo.didFinishLessons ? (
              <React.Fragment>
                <img className="item__icon" alt="Kvacica" src={FullCheckmark} />
                <figure className="timeline__item timeline__item--smaller timeline__item--passed">
                  <figcaption>
                    <h3 className="item__title item__title--waiting">Vožnja</h3>
                    <p className="item__status item__title--waiting">
                      {drivingInfo.currentLesson}/35 sati
                    </p>
                  </figcaption>
                </figure>

                <img
                  className="item__icon"
                  alt="Usklicnik"
                  src={RedExclimation}
                />
                <figure className="timeline__item timeline__item--smaller timeline__item--warning">
                  <figcaption>
                    <h3 className="item__title item__title--warning">
                      Ispit iz vožnje
                    </h3>
                    <p className="item__status item__status--warning">
                      Nije položeno
                    </p>
                  </figcaption>
                </figure>
              </React.Fragment>
            ) : (
              <React.Fragment>
                <img className="item__icon" alt="PjescaniSat" src={Pending} />
                <figure className="timeline__item timeline__item--smaller timeline__item--waiting">
                  <figcaption>
                    <h3 className="item__title item__title--waiting">Vožnja</h3>
                    <p className="item__status item__title--waiting">
                      {drivingInfo.currentLesson}/35 sati
                    </p>
                  </figcaption>
                </figure>
              </React.Fragment>
            )}
          </section>
        </main>
      </React.Fragment>
    );
  }
}
