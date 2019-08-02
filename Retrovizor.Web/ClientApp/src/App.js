import React, { Component } from "react";
import { Route } from "react-router";
import { Layout } from "./components/Layout";
import Login from "./components/Login/Login";
import Materials from "./components/Students/Materials/Materials";
import Regulations from "./components/Students/Materials/Regulations";
import FirstAid from "./components/Students/Materials/FirstAid";
import Schedule from "./components/Students/Schedule/Schedule";
import Driving from "./components/Students/Driving/Driving";
import StudentProfile from "./components/Students/StudentProfile/StudentProfile";
import Settings from "./components/Students/StudentProfile/Settings";
import InstructorList from "./components/Students/Driving/InstructorList";
import InstructorDetails from "./components/Students/Driving/InstructorDetails";
import Instructors from "./components/Administrators/Instructors/Instructors";
import Instructor from "./components/Administrators/Instructors/Instructor";
import Students from "./components/Administrators/Students/Students";

export default class App extends Component {
  static displayName = App.name;

  render() {
    return (
      <Layout>
        <Route exact path="/" component={Login} />
        {/* Students */}
        <Route exact path="/materijali" component={Materials} />
        <Route exact path="/materijali/propisi" component={Regulations} />
        <Route exact path="/materijali/prva-pomoc" component={FirstAid} />
        <Route exact path="/raspored" component={Schedule} />
        <Route exact path="/voznja" component={Driving} />
        <Route exact path="/voznja/instruktor" component={InstructorDetails} />
        <Route exact path="/voznja/instruktori" component={InstructorList} />
        <Route exact path="/profil" component={StudentProfile} />
        <Route exact path="/profil/postavke" component={Settings} />
        {/* Students */}

        {/* Instructors */}
        {/* Instructors */}

        {/* Administrator */}
        <Route exact path="/instruktori" component={Instructors} />
        <Route exact path="/instruktori/detalji" component={Instructor} />
        <Route exact oath="/kandidati" component={Students} />
        {/* Administrator */}
      </Layout>
    );
  }
}
