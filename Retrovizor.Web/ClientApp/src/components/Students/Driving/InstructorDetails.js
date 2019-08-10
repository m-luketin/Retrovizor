import React, { Component } from "react";
import { Link } from "react-router-dom";
import Calendar from "react-calendar";
import {
  authorizedRequest,
  formatPhoneNumber,
  getInstructorsActiveStudentCount,
  formatTimeForDisplay,
  formatDate,
  formatDateNotForDisplay
} from "../../utils";
import "./Instructor.css";
// SVG import
import Profile from "../../../assets/Instructor.gif";
import DisplayCar from "../../../assets/DisplayCar.png";
import Phone from "../../../assets/Phone.svg";
import HeaderArrow from "../../../assets/HeaderArrow.svg";
import CalendarSvg from "../../../assets/Calendar.svg";
import NormalCar from "../../../assets/NormalCar.svg";
import People from "../../../assets/People.svg";
import Garbage from "../../../assets/Garbage.svg";
import { isUserValid } from "../../PrivateRoute";

export default class InstructorDetails extends Component {
  constructor(props) {
    super(props);
    this.state = {
      instrucorToDisplay: null,
      eventsArray: null,
      filteredEventsArray: [],
      calendarVisibility: false,
      selectedDate: new Date()
    };
  }

  componentDidMount() {
    isUserValid();

    authorizedRequest(`api/Instructor/get-by-student/0`, "get", "").then(
      data => {
        this.setState({ instrucorToDisplay: data });
        // console.log(data);

        authorizedRequest(
          `api/Event/get-by-instructor/${data.id}`,
          "get",
          ""
        ).then(events => {
          this.setState({ eventsArray: events });
          // console.log(events);
        });
      }
    );
  }

  handleToggleCalendarVisibility = () => {
    const { calendarVisibility } = this.state;
    this.setState({ calendarVisibility: !calendarVisibility });
  };

  handleCalendarChange = e => {
    let { filteredEventsArray, eventsArray } = this.state;
    filteredEventsArray = [];

    eventsArray.forEach(event => {
      if (event.startsAt.includes(formatDateNotForDisplay(e))) {
        filteredEventsArray.push(event);
      }
    });
    this.setState({ filteredEventsArray, selectedDate: e });
  };

  render() {
    const {
      instrucorToDisplay,
      filteredEventsArray,
      calendarVisibility,
      selectedDate
    } = this.state;
    const { studentId } = this.props.location.state;

    if (instrucorToDisplay === null || filteredEventsArray === null)
      return null;

    return (
      <React.Fragment>
        <header>
          <Link to="/kandidat/voznja">
            <img className="header__arrow" alt="Strelica" src={HeaderArrow} />
            <h1 className="header__title header__title--blue">Instruktor</h1>
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
                    {instrucorToDisplay.firstName} {instrucorToDisplay.lastName}
                  </h3>
                  <p className="instructor__school">
                    Autoškola "{instrucorToDisplay.user.drivingSchool.name}"
                  </p>
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
                  Kontakt:
                </figcaption>
                <p className="instructor__item--text c-blue">
                  {formatPhoneNumber(instrucorToDisplay.user.phoneNumber)}
                </p>
              </div>
            </figure>

            <figure className="instructor__item">
              <img
                className="instructor__item--people"
                alt="Ljudi"
                src={People}
              />
              <div>
                <figcaption className="instructor__item--title">
                  Kandidati:
                </figcaption>
                <p className="instructor__item--text">
                  {getInstructorsActiveStudentCount(instrucorToDisplay)}/15
                </p>
              </div>
            </figure>

            <section className="instructor__item--wrapper">
              <figure className="instructor__item">
                <img
                  className="intructor__item--car"
                  alt="Auto"
                  src={NormalCar}
                />
                <div>
                  <figcaption className="instructor__item--title">
                    Auto:
                  </figcaption>
                  <p className="instructor__item--text">
                    {instrucorToDisplay.vehicle.manufacturer}{" "}
                    {instrucorToDisplay.vehicle.model}
                  </p>
                </div>
              </figure>
              <img
                className="instructor__item--preview"
                src={DisplayCar}
                alt="car"
              />
            </section>

            <figure className="instructor__item instructor__item--itinerary">
              <img
                className="instructor__item--calendar"
                alt="Kalendar"
                src={CalendarSvg}
              />
              <div>
                <figcaption className="instructor__item--title">
                  Raspored:
                </figcaption>
              </div>
            </figure>
          </section>

          <section>
            <div
              onClick={this.handleToggleCalendarVisibility}
              className="instructor__item--schedule"
            >
              <img
                className="intructor__item--arrow"
                alt="Strelica"
                src={HeaderArrow}
              />
              <h3 className="instructor__schedule--date">
                {formatDate(selectedDate.toString())[0]},
              </h3>
              <p className="instructor__schedule--day">
                {formatDate(selectedDate.toString())[1]}.{" "}
                {formatDate(selectedDate.toString())[2]}
              </p>
            </div>

            {calendarVisibility ? (
              <Calendar
                onChange={e => this.handleCalendarChange(e)}
                value={this.state.selectedDate}
                minDate={new Date()}
                minDetail={"month"}
                activeStartDate={new Date(2019, 10, 8)}
              />
            ) : null}

            {filteredEventsArray.length > 0
              ? filteredEventsArray.map((event, index) => (
                  <React.Fragment key={index}>
                    {studentId === event.studentEvents[0].studentId ? (
                      <button className="main__button main__button--schedule instructor__schedule--button ">
                        <div className="instructor__schedule--time">
                          <h3>{formatTimeForDisplay(event.startsAt)}</h3>
                        </div>
                        <p className="button__info">Rezervirano</p>
                        <img
                          className="button__garbage"
                          alt="Brisi"
                          src={Garbage}
                        />
                      </button>
                    ) : (
                      <button className="main__button main__button--schedule instructor__schedule--button instructor__schedule--taken">
                        <div className="instructor__schedule--time">
                          <h3>{formatTimeForDisplay(event.startsAt)}</h3>
                        </div>
                        <p className="button__info">Zauzeto</p>
                      </button>
                    )}
                  </React.Fragment>
                ))
              : null}

            {/* <button className="main__button main__button--schedule instructor__schedule--button ">
              <div className="instructor__schedule--time">
                <h3>10:15</h3>
              </div>
              <p className="button__info">Rezervirano</p>
              <img className="button__garbage" alt="Brisi" src={Garbage} />
            </button>

            <button className="main__button main__button--schedule instructor__schedule--button instructor__schedule--free">
              <div className="brc-blue instructor__schedule--time ">
                <h3>11:15</h3>
              </div>
              <p className="button__info">Slobodno</p>
              <img
                className="button__info--arrow button__garbage"
                alt="Strelica"
                src={HeaderArrow}
              />
            </button> */}
          </section>
        </main>
      </React.Fragment>
    );
  }
}
