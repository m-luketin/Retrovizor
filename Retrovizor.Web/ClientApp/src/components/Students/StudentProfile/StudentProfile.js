import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import './StudentProfile.css';
import { authorizedRequest } from '../../utils';

// SVG import
import Profile from '../../../assets/Instructor.gif';
import Timeline from '../../../assets/Timeline.svg';
import FullCheckmark from '../../../assets/FullCheckmark.svg';
import RedExclimation from '../../../assets/RedExclimation.svg';
import Pending from '../../../assets/Pending.svg';
import GrayPencil from '../../../assets/GrayPencil.svg';


export default class StudentProfile extends Component {
	constructor(props) {
		super(props);

		this.state = {
			id: 0,
			name: '',
			category: '',
			timeline: []
		};
	}

	componentDidMount = () => {
		let tmpTimelineClasses = [];
		let tmpTimelineExams = [];
		authorizedRequest('api/student/get/0', 'get')
			.then(response => {
				this.setState({
					id: response.id,
					name: response.firstName,
					category: response.category
				});
			})
			.then(() => {
				authorizedRequest(`api/class/get-by-student/${this.state.id}`)
					.then(response => {
						tmpTimelineClasses = response;
					})
					.then(() => {
						authorizedRequest(`api/exam/get-by-student/${this.state.id}`)
							.then(response => {
								tmpTimelineExams = response;
							})
							.then(() => {
								let tmpTimeline = [];
								tmpTimelineClasses.map(tlc => {
									tmpTimeline.push(tlc);
									tmpTimelineExams.map(tle => {
										if (tlc.class.name.indexOf(tle.exam.type) !== -1)
											tmpTimeline.push(tle);
									});
								});
								this.setState({ timeline: tmpTimeline });
							});
					});
			});
	};

	render() {
		return (
			<React.Fragment>
				<header className='header'>
					<h1 className='header__title'>Profil</h1>
					<button>
						<Link to='/kandidat/profil/postavke'>
							<img
								className='bi x0 y0 w1 h1 header__settings'
								alt='Settings button'
								src='data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAACYAAAAmCAIAAAAnX375AAAACXBIWXMAABYlAAAWJQFJUiTwAAADeElEQVRYw7WY3UtaYRzHj6KQb5gej2EqimZ1pMWMMViDhKEEJeGIEXXTdjd2uf9kl9HNKNhYY2wXazdRENamLrVjVq4Xk2RWcxVRnmMdO+3iDKfP8bzY9Hvnw/M8n+c8v9dH0c3NDSRYFEWFovHlcIz+qZDLxoZ9apUSqkXimmanM9kSD4KgPE68+fAZqlG1ITe2doGRPE6cnV80CklRVHI7xRxPpTM1ISXModja5s7ePk4Qnr5eo0FPD5JkMRCKVN0iGMH0Orh85gqWWE0kzUaDqwstjZckAtzn28pqubU6HTa71XxwlIvGN7jPjsCabmcHfYI8TpTGRx8PAtQKZGxtcz4QhOqtF89G5bKm6rbc2duHGiC87KNBJE4QjUBeXpGsSE9fb915CKwBbFmBNBr0nQ5bfZH+AQ9PXNqt5voimekQjMuDoxz3Fg/vu1oQHaxtJq/I3MlpOBrPHZ9y+Q5RKHdXEEmSRY74s5haB73u8vU6WIM6bJvbqdm5RbZV2Hrywb271S+Woii2/ELzngz1A+elhTpsT0f8bAuXwzEgCYuur6/TmezG1m7V/MkWzkwtLIU4bgiBNe12q7OjTa1Sir5+j5VnODb7AZfDFEkWX01Oc89RyGXjI34xLw+CoBZExztHKpUo5DLuOXmcCEYwQcUL1jYLmWY2GviTH1EQhCQrM9Z/Ssx7GxAE5U5OhezF7YClVCMeG/bxUsPROO9ev4/5j9XT7UQdtr/18uz8IpXOANW1XINeN8qefimKmpiaYVvb6bC5ulC9TiuVSv6lArVK6bqDDvU/Ytt0dm6R7TsoivoyH2DjIbDG53UbDXqaV6WSILCGjfr63aeFpRBJFoH7nJia4bAisyCCvY+QXkQhl9HxIMRfXj4fF4vFPB0er/I4IQQmqI8lyWIwgtW3XmLrP7iQK1iCzQturflAEDB/BXI1kWxEu5XJHrIihSTJWwhI0RVIVxdad57F1KpSyLmC5OfBr7cfZ0tR7B/wqFVKnChg60mOMofAGk9fr6FFR/tLKcwsptZhnxcIEhHzSYsTBRwnLq9IoP88O7+YnH5fNZ/5vG7A8zPZQ1jbrFLIAV71uJTLmqr2HGqVEoE1zH6OaQ6pVGKzmOrzpG23W5mDep22ga9oZ0cbUOl6up2lfC1Qopr+nqAtHYxgOFGg6y1a+4PiD8kGeYAymJKbAAAAAElFTkSuQmCC'
							/>
						</Link>
					</button>
				</header>
				<main>
					<section className='main__profile'>
						<figure>
							<div className='profile__image--wrapper'>
								<img src={Profile} alt='User icon' className='profile__user-icon' />
								<span className='profile__user--edit--wrapper'>
									<img
										className='profile__user--edit'
										alt='Olovka'
										src={GrayPencil}
									/>
								</span>
							</div>
							<figcaption className='profile__details'>
								<h2 className='profile__name'>Bok, {this.state.name}!</h2>
								<span className='profile__category'>
									<span className='profile__category--type'>
										{this.state.category}
									</span>
									kategorija
								</span>
							</figcaption>
						</figure>
					</section>

					<section className='main__timeline'>
						<div className='main__timeline--title'>
							<img className='timeline__icon' alt='Vremenska crta' src={Timeline} />
							<h3 className='timeline__title'>Vremenska crta:</h3>
						</div>
						{this.state.timeline.map(item => {
							if (item.hasOwnProperty('classId')) {
								if (item.currentLesson < item.class.totalLessons) {
									return (
										<React.Fragment>
											<img
												className='item__icon'
												alt='PjescaniSat'
												src={Pending}
											/>
											<figure className='timeline__item timeline__item--waiting'>
												<figcaption>
													<h3 className='item__title'>
														{item.class.name}
													</h3>
													<p className='item__status'>
														{item.currentLesson}/
														{item.class.totalLessons} sati
													</p>
												</figcaption>
											</figure>
										</React.Fragment>
									);
								} else if (item.currentLesson === item.class.totalLessons) {
									return (
										<React.Fragment>
											<img
												className='item__icon'
												alt='Checkmark'
												src={FullCheckmark}
											/>
											<figure className='timeline__item timeline__item--passed'>
												<figcaption>
													<h3 className='item__title'>{item.class.name}</h3>
													<p className='item__status'>
														{item.currentLesson}/
														{item.class.totalLessons} sati
													</p>
												</figcaption>
											</figure>
										</React.Fragment>
									);
								}
							} else if (item.hasOwnProperty('examId')) {
								if (item.points < item.exam.pointsToPass) {
									return (
										<React.Fragment>
											<img
												className='item__icon'
												alt='Usklicnik'
												src={RedExclimation}
											/>
											<figure className='timeline__item timeline__item--warning'>
												<figcaption>
													<h3 className='item__title'>
														Ispit {item.exam.type}
													</h3>
													<p className='item__status'>
														{item.points}/{item.exam.totalPoints} bodova
													</p>
												</figcaption>
											</figure>
										</React.Fragment>
									);
                }
                if (item.points > item.exam.pointsToPass) {
									return (
										<React.Fragment>
																	<img className='item__icon' alt='Checkmark' src={FullCheckmark} />

											<figure className='timeline__item timeline__item--passed'>
												<figcaption>
													<h3 className='item__title'>
														Ispit {item.exam.type}
													</h3>
													<p className='item__status'>
														{item.points}/{item.exam.totalPoints} bodova
													</p>
												</figcaption>
											</figure>
										</React.Fragment>
									);
								}
							}
						})}
					</section>
				</main>
			</React.Fragment>
		);
	}
}
