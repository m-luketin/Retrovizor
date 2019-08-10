import React, { Component } from "react";
import { BrowserRouter, Switch, Route, Redirect } from "react-router-dom";
import { PrivateRoute } from "./components/PrivateRoute";
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
import StudentList from "./components/Instructors/Students/StudentList";
import StudentDetails from "./components/Instructors/Students/StudentDetails";
import InstructorSchedule from "./components/Instructors/Schedule/InstructorSchedule";
import InstructorProfile from "./components/Instructors/InstructorProfile/InstructorProfile";

export default class App extends Component {
  static displayName = App.name;

  render() {
    return (
      <BrowserRouter>
        <Layout>
          <Switch>
            <Route exact path="/" render={props => <Login {...props} />} />
            {/* Students */}
            <PrivateRoute
              exact
              path="/kandidat/materijali"
              component={Materials}
              // render={props => <Materials {...props} />}
            />
            <PrivateRoute
              exact
              path="/kandidat/materijali/propisi"
              component={Regulations}
              // render={props => <Regulations {...props} />}
            />
            <PrivateRoute
              exact
              path="/kandidat/materijali/prva-pomoc"
              component={FirstAid}
              // render={props => <FirstAid {...props} />}
            />
            <PrivateRoute
              exact
              path="/kandidat/raspored"
              component={Schedule}
              // render={props => <Schedule {...props} />}
            />
            <PrivateRoute
              exact
              path="/kandidat/voznja"
              component={Driving}
              // render={props => <Driving {...props} />}
            />
            <PrivateRoute
              exact
              path="/kandidat/voznja/instruktor"
              component={InstructorDetails}
              // render={props => <InstructorDetails {...props} />}
            />
            <PrivateRoute
              exact
              path="/kandidat/voznja/instruktori"
              component={InstructorList}
              // render={props => <InstructorList {...props} />}
            />
            <PrivateRoute
              exact
              path="/kandidat/profil"
              component={StudentProfile}
              // render={props => <StudentProfile {...props} />}
            />
            <PrivateRoute
              exact
              path="/kandidat/profil/postavke"
              component={Settings}
              // render={props => <Settings {...props} />}
            />
            {/* Students */}

            {/* Instructors */}
            <PrivateRoute
              exact
              path="/instruktor/kandidati"
              component={StudentList}
              // render={props => <StudentList {...props} />}
            />
            <PrivateRoute
              exact
              path="/instruktor/kandidati/kandidat"
              component={StudentDetails}
              // render={props => <StudentDetails {...props} />}
            />
            <PrivateRoute
              exact
              path="/instruktor/raspored"
              component={InstructorSchedule}
              // render={props => <InstructorSchedule {...props} />}
            />
            <PrivateRoute
              exact
              path="/instruktor/profil"
              component={InstructorProfile}
              // render={props => <InstructorProfile {...props} />}
            />
            <PrivateRoute
              exact
              path="/instruktor/profil/postavke"
              component={Settings}
              // render={props => <Settings {...props} />}
            />
            {/* Instructors */}

            {/* Administrator */}
            <PrivateRoute
              exact
              path="/administrator/instruktori"
              component={Instructors}
              // render={props => <Instructors {...props} />}
            />
            <PrivateRoute
              exact
              path="/administrator/instruktori/detalji/:id"
              component={Instructor}
              // render={props => <Instructor {...props} />}
            />
            <PrivateRoute
              exact
              path="/administrator/kandidati"
              component={Students}
              // render={props => <Students {...props} />}
            />
            <PrivateRoute
              exact
              path="/administrator/kandidati/kandidat/:id"
              component={Student}
              // render={props => <Student {...props} />}
            />
            <PrivateRoute
              exact
              path="/administrator/raspored"
              component={AdministratorSchedule}
              // render={props => <AdministratorSchedule {...props} />}
            />
            <PrivateRoute
              exact
              path="/administrator/raspored/lista-kandidata"
              component={EventStudentsToAdd}
              // render={props => <EventStudentsToAdd {...props} />}
            />
            <PrivateRoute
              exact
              path="/administrator/profil"
              component={AdministratorProfile}
              // render={props => <AdministratorProfile {...props} />}
            />
            <PrivateRoute
              exact
              path="/administrator/profil/postavke"
              component={Settings}
              // render={props => <Settings {...props} />}
            />
            {/* Administrator */}
            <Redirect to="/" />
          </Switch>
        </Layout>
      </BrowserRouter>
    );
  }
}
