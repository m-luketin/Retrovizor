import React, { Component } from "react";
import ReactMapGL, { Marker } from "react-map-gl";
import instructorImg from "../../assets/instructor.gif";

export default class DrivingWithLesson extends Component {
  constructor(props) {
    super(props);
    this.state = {
      viewport: {
        width: "100vw",
        height: "100%",
        latitude: 43.51125,
        longitude: 16.46944444,
        zoom: 15
      },
      marker: {
        latitude: 43.51125,
        longitude: 16.46944444
      }
    };
  }

  handleMapViewportChange = viewport => {
    this.setState(state => ({ ...state, viewport }));
  };

  handleMarkerDragEnd = event => {
    const updatedMarker = {
      latitude: event.lngLat[1],
      longitude: event.lngLat[0]
    };

    this.setState(state => ({ ...state, marker: updatedMarker }));
  };

  render() {
    const { viewport, marker } = this.state;
    const { handleMapViewportChange, handleMarkerDragEnd } = this;

    return (
      <main className="main__drive">
        <section className="main__map">
          <ReactMapGL
            {...viewport}
            mapboxApiAccessToken={process.env.REACT_APP_MAPBOX_WEBTOKEN}
            onViewportChange={viewport =>
              this.handleMapViewportChange(viewport)
            }
          >
            <Marker
              draggable
              {...marker}
              offsetTop={-20}
              offsetLeft={-10}
              onDragEnd={e => handleMarkerDragEnd(e)}
            >
              <svg
                width="21px"
                height="29px"
                viewBox="0 0 21 29"
                version="1.1"
                xmlns="http://www.w3.org/2000/svg"
                xlink="http://www.w3.org/1999/xlink"
              >
                <title>CE261831-68DF-4E2E-908F-50FA348D39D1</title>
                <desc>Created with sketchtool.</desc>
                <g
                  id="Polaznik"
                  stroke="none"
                  stroke-width="1"
                  fill="none"
                  fill-rule="evenodd"
                >
                  <g
                    id="Vožnja(1)"
                    transform="translate(-228.000000, -301.000000)"
                    fill="#1488CC"
                    fill-rule="nonzero"
                  >
                    <g
                      id="Budicon-Solid/Travel/location-pin"
                      transform="translate(224.000000, 301.500000)"
                    >
                      <path
                        d="M14.5,0 C9.05447237,0 4.64,4.26224916 4.64,9.51999995 C4.64,15.0941279 10.420744,23.9641919 13.129344,27.3474879 C13.4570243,27.7585587 13.9636853,27.9995877 14.5009366,27.9999829 C15.0381879,28.0003771 15.5452282,27.7600928 15.873556,27.3495039 C18.58378,23.9750559 24.36,15.1277279 24.36,9.51999995 C24.36,6.99513898 23.3211816,4.57368974 21.4720729,2.78834343 C19.6229642,1.00299712 17.1150346,0 14.5,0 L14.5,0 Z M14.5,12.32 C12.2577239,12.32 10.44,10.5649562 10.44,8.4 C10.44,6.23504378 12.2577239,4.48 14.5,4.48 C16.7422761,4.48 18.56,6.23504378 18.56,8.4 C18.56,10.5649562 16.7422761,12.32 14.5,12.32 L14.5,12.32 Z"
                        id="Shape"
                      />
                    </g>
                  </g>
                </g>
              </svg>
            </Marker>
          </ReactMapGL>
        </section>
        <section className="main__next--lesson--wrapper">
          <h3 className="main__next--lesson">Sljedeći termin:</h3>
          <div className="main__driving">
            <img
              className="main__driving--instructor"
              src={instructorImg}
              alt="Instruktor"
            />

            <button className="main__button main__button--schedule main__button--driving">
              <div>
                <span className="button__date">24</span>
                <br />
                <span className="button__month">STU</span>
              </div>

              <span className="button__info">
                <h3>13:30</h3>
                <p>Požeška 12, Split</p>
              </span>
            </button>
          </div>
        </section>
      </main>
    );
  }
}
