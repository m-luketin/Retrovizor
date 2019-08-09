import React, { Component } from 'react';
import './Schedule.css';
import { authorizedRequest } from '../../utils';
// SVG import
import Calendar from '../../../assets/Calendar.svg';

export default class Schedule extends Component {
	constructor(props) {
		super(props);
		this.state = {
			id: 0,
			events: []
		};
	}

	convertMonth = month => {
		switch (month) {
			case '01':
				return 'SIJ';
			case '02':
				return 'VELJ';
			case '03':
				return 'OŽU';
			case '04':
				return 'TRA';
			case '05':
				return 'SVI';
			case '06':
				return 'LIP';
			case '07':
				return 'SRP';
			case '08':
				return 'KOL';
			case '09':
				return 'RUJ';
			case '10':
				return 'LIS';
			case '11':
				return 'STU';
			case '12':
				return 'PRO';
		}
	};

	componentDidMount() {
		authorizedRequest('api/student/get/0', 'get')
			.then(response => {
				this.setState({
					id: response.id
				});
			})
			.then(() => {
				authorizedRequest(`api/event/get-by-student/${this.state.id}`).then(response => {
          response.sort((a,b) => (a.event.startsAt > b.event.startsAt) ? 1 : ((b.event.startsAt > a.event.startsAt) ? -1 : 0));
					this.setState({ events: response });
				});
			});
	}

	render() {
		return (
			<React.Fragment>
				<header className='header'>
					<h1 className='header__title'>Raspored</h1>
					<button>
						<img
							className='header__icon header__icon--calendar'
							alt='Kalendar'
							src={Calendar}
						/>
					</button>
				</header>

				<main className='main'>
					{this.state.events.map(item => {
						return (
							<button className='main__button main__button--schedule'>
								<div>
									<span className='button__date'>
										{item.event.startsAt[8] == 0 ? '' : item.event.startsAt[8]}
										{item.event.startsAt[9]}
									</span>
									<br />
									<span className='button__month'>{this.convertMonth(`${item.event.startsAt[5]}${item.event.startsAt[6]}`)}</span>
								</div>
								<p className='button__info'>{item.event.name}</p>
							</button>
						);
					})}
					<button className='main__button main__button--schedule'>
						<div>
							<span className='button__date'>23</span>
							<br />
							<span className='button__month'>STU</span>
						</div>
						<p className='button__info'>14. sat prometnih propisa</p>
					</button>

					<button className='main__button main__button--schedule'>
						<div>
							<span className='button__date'>24</span>
							<br />
							<span className='button__month'>STU</span>
						</div>
						<p className='button__info'>15. sat prometnih propisa</p>
					</button>

					<button className='main__button main__button--schedule main__button--green'>
						<div>
							<span className='button__date'>04</span>
							<br />
							<span className='button__month'>PRO</span>
						</div>
						<p className='button__info'>Ispit iz prometnih propisa!</p>
					</button>
				</main>
			</React.Fragment>
		);
	}
}
