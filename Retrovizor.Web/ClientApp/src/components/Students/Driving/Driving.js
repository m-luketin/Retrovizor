import React, { Component } from 'react';
import DrivingWithLesson from './DrivingWithLesson';
import DrivingWithoutLesson from './DrivingWithoutLesson';
import DrivingWithoutInstructor from './DrivingWithoutInstructor';
import { authorizedRequest } from '../../utils';
import 'mapbox-gl/dist/mapbox-gl.css';
import 'react-map-gl-geocoder/dist/mapbox-gl-geocoder.css';
import './Driving.css';

export default class Driving extends Component {
	constructor(props) {
		super(props);
		this.state = {
			doesStudentHaveInstructor: false,
			doesStudentHaveLesson: false,
			instructor: null,
			event: null,
			studentData: {}
		};
	}

	componentDidMount() {
		authorizedRequest(`api/student/get/0`, 'get').then(data => {
			this.displaySetup(data);
			this.setState({ studentData: data });
			console.log(data);
		});
	}

	displaySetup = data => {
		data.vehicleSessions.forEach(session => {
			if (session.instructorId !== null && session.isActive)
				this.setState({
					doesStudentHaveInstructor: true,
					// doesStudentHaveInstructor: false,
					instructor: session.instructor
				});

			data.studentEvents.forEach(studentEvent => {
				if (studentEvent.event.type === 'Voznja') {
					this.setState({
						doesStudentHaveLesson: true,
						//doesStudentHaveLesson: false,
						event: studentEvent.event
					});
				}
			});
		});
	};

	render() {
		const { doesStudentHaveLesson, doesStudentHaveInstructor } = this.state;

		return (
			<React.Fragment>
				<header>
					<h1 className='header__title'>Vožnja</h1>
				</header>
				{doesStudentHaveLesson && doesStudentHaveInstructor ? (
					<DrivingWithLesson />
				) : doesStudentHaveInstructor ? (
					<DrivingWithoutLesson studentId={this.state.studentData.id} />
				) : (
					<DrivingWithoutInstructor />
				)}
			</React.Fragment>
		);
	}
}
