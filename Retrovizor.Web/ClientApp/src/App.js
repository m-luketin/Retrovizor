import React, { Component } from "react";
import { Route } from "react-router";
import { Layout } from "./components/Layout";
import Login from "./components/Login/Login";
import Materials from "./components/Materials/Materials";
import Regulations from "./components/Materials/Regulations";
import FirstAid from "./components/Materials/FirstAid";
import Schedule from "./components/Schedule/Schedule";
import Driving from "./components/Driving/Driving";
import StudentProfile from "./components/StudentProfile/StudentProfile";
import Settings from "./components/StudentProfile/Settings";

export default class App extends Component {
  static displayName = App.name;

  render() {
    return (
      <Layout>
        <Route exact path="/" component={Login} />
        <Route exact path="/login" component={Login} />
        <Route exact path="/materijali" component={Materials} />
        <Route exact path="/materijali/propisi" component={Regulations} />
        <Route exact path="/materijali/prva-pomoc" component={FirstAid} />
        <Route exact path="/raspored" component={Schedule} />
        <Route exact path="/voznja" component={Driving} />
        <Route exact path="/voznja/instruktor" component={Driving} />
        <Route exact path="/profil" component={StudentProfile} />
        <Route exact path="/profil/postavke" component={Settings} />
      </Layout>
    );
  }
}
