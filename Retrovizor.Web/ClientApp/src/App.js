import React, { Component } from "react";
import { BrowserRouter, Switch, Route, Redirect } from "react-router-dom";
import { Layout } from "./components/Layout";
import Login from "./components/Login/Login";
import Materials from "./components/Students/Materials/Materials";
import Regulations from "./components/Students/Materials/Regulations";
import FirstAid from "./components/Students/Materials/FirstAid";
import Schedule from "./components/Students/Schedule/Schedule";
import Driving from "./components/Students/Driving/Driving";
import StudentProfile from "./components/Students/StudentProfile/StudentProfile";
import Settings from "./components/Settings/Settings";
import InstructorList from "./components/Students/Driving/InstructorList";
import InstructorDetails from "./components/Students/Driving/InstructorDetails";
import Instructors from "./components/Administrators/Instructors/Instructors";
import Instructor from "./components/Administrators/Instructors/Instructor";
import Students from "./components/Administrators/Students/Students";
import AdministratorSchedule from "./components/Administrators/Schedule/AdministratorSchedule";
import EventStudentsToAdd from "./components/Administrators/Schedule/EventStudentsToAdd";
import AdministratorProfile from "./components/Administrators/AdministratorProfile/AdministratorProfile";
import Student from "./components/Administrators/Students/Student";

export default class App extends Component {
  static displayName = App.name;

  render() {
    return (
      <BrowserRouter>
        <Layout>
          <Switch>
            <Route exact path="/" render={props => <Login {...props} />} />
            {/* Students */}
            <Route
              exact
              path="/kandidat/materijali"
              render={props => <Materials {...props} />}
            />
            <Route
              exact
              path="/kandidat/materijali/propisi"
              render={props => <Regulations {...props} />}
            />
            <Route
              exact
              path="/kandidat/materijali/prva-pomoc"
              render={props => <FirstAid {...props} />}
            />
            <Route
              exact
              path="/kandidat/raspored"
              render={props => <Schedule {...props} />}
            />
            <Route
              exact
              path="/kandidat/voznja"
              render={props => <Driving {...props} />}
            />
            <Route
              exact
              path="/kandidat/voznja/instruktor"
              crender={props => <InstructorDetails {...props} />}
            />
            <Route
              exact
              path="/kandidat/voznja/administrator/instruktori"
              render={props => <InstructorList {...props} />}
            />
            <Route
              exact
              path="/kandidat/profil"
              render={props => <StudentProfile {...props} />}
            />
            <Route
              exact
              path="/kandidat/profil/postavke"
              render={props => <Settings {...props} />}
            />
            {/* Students */}

            {/* Instructors */}
            {/* Instructors */}

            {/* Administrator */}
            <Route
              exact
              path="/administrator/instruktori"
              render={props => <Instructors {...props} />}
            />
            <Route
              exact
              path="/administrator/instruktori/detalji"
              render={props => <Instructor {...props} />}
            />
            <Route
              exact
              path="/administrator/kandidati"
              render={props => <Students {...props} />}
            />
            <Route
              exact
              path="/administrator/kandidati/kandidat"
              render={props => <Student {...props} />}
            />
            <Route
              exact
              path="/administrator/raspored"
              render={props => <AdministratorSchedule {...props} />}
            />
            <Route
              exact
              path="/administrator/raspored/lista-kandidata"
              render={props => <EventStudentsToAdd {...props} />}
            />
            <Route
              exact
              path="/administrator/profil"
              render={props => <AdministratorProfile {...props} />}
            />
            <Route
              exact
              path="/administrator/profil/postavke"
              render={props => <Settings {...props} />}
            />
            {/* Administrator */}
            <Redirect to="/" />
          </Switch>
        </Layout>
      </BrowserRouter>
    );
  }
}
