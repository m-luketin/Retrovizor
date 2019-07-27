import React, { Component } from "react";
import { Link } from "react-router-dom";
import "../Common.css";
import "./Materials.css";

export default class Materials extends Component {
  render() {
    return (
      <React.Fragment>
        <header>
          <h1 class="header__title">Materijali</h1>
        </header>

        <main>
          <Link to="/materijali/propisi">
            <button class="main__button--big bc-blue">
              <div class="main__button--images">
                <svg
                  class="main__button--car"
                  xmlns="http://www.w3.org/2000/svg"
                  width="25px"
                  height="17px"
                  viewBox="0 0 25 17"
                  version="1.1"
                >
                  <g
                    id="Symbols"
                    stroke="none"
                    stroke-width="1"
                    fill="none"
                    fill-rule="evenodd"
                  >
                    <g
                      id="Budicon-Solid/Travel/sedan-front"
                      transform="translate(0.000000, -4.000000)"
                      fill="#FFFFFF"
                      fill-rule="nonzero"
                    >
                      <path
                        d="M24.5,8 L21.7133001,8 C21.0876001,6.79910428 20.3775001,5.53300428 19.9333001,4.75440428 C19.6670398,4.2870408 19.1700866,3.99889888 18.6322001,4 L6.36780008,4 C5.82973487,3.99871865 5.33254861,4.28688499 5.06620008,4.75440428 C4.62250008,5.53300428 3.91250008,6.79910428 3.28670008,8 L0.5,8 C0.223857708,8 0,8.22386191 0,8.5 L0,10 C0,10.2296095 0.156130985,10.4297939 0.378900083,10.4854043 L2.01420008,10.8941043 C2.00726585,10.9290741 2.00252328,10.964443 2,11 C2,11.8066043 2.65080008,17.8200043 2.90240008,20.1143043 C2.95821562,20.6202259 3.38691452,21.0024087 3.89590008,21.0000156 L6.38200008,21.0000156 C6.76074311,21.0000156 7.10698833,20.786046 7.27640008,20.4473043 L7.86180008,19.2764043 C7.946492,19.107014 8.11961744,19.0000107 8.30900008,19 L16.6910001,19 C16.8803827,19.0000107 17.0535082,19.107014 17.1382001,19.2764043 L17.7236001,20.4473043 C17.8930118,20.786046 18.2392571,21.0000156 18.6180001,21.0000156 L21.1041001,21.0000156 C21.6130856,21.0024087 22.0417845,20.6202259 22.0976001,20.1143043 C22.3492001,17.8200043 23,11.8066043 23,11 C22.997481,10.9644095 22.9927384,10.9290071 22.9858001,10.8940043 L24.6211001,10.4853043 C24.843833,10.4297029 25,10.2295722 25,10 L25,8.5 C25,8.22386191 24.7761425,8 24.5,8 Z M2.34000008,9.94430428 L1.00000008,9.60940428 L1.00000008,9.00000428 L2.78000008,9.00000428 C2.61290008,9.34000428 2.46220008,9.66110428 2.34000008,9.94430428 Z M9.00000008,16.5000043 C9.00000008,16.7761467 8.77614246,17.0000043 8.50000008,17.0000043 L4.84000008,17.0000043 C4.58780934,17.0000043 4.37507173,16.8122487 4.34380008,16.5620043 L4.00380008,13.5630043 C3.98122612,13.3872527 4.05356809,13.2127152 4.19385433,13.1044655 C4.33414057,12.9962159 4.52131797,12.9704995 4.68560008,13.0369043 L8.68560008,14.5962043 C8.8754876,14.6721141 9.00000008,14.856006 9.00000008,15.0605043 L9.00000008,16.5000043 Z M20.6558001,16.5620043 C20.6245474,16.8120975 20.4120384,16.9998323 20.1600001,17.0000043 L16.5000001,17.0000043 C16.2238577,17.0000043 16.0000001,16.7761467 16.0000001,16.5000043 L16.0000001,15.0605043 C15.9999332,14.8559942 16.124418,14.6720593 16.3143001,14.5961043 L20.3143001,13.0368043 C20.4785822,12.9703995 20.6657596,12.9961159 20.8060458,13.1043655 C20.9463321,13.2126152 21.018674,13.3871527 20.9961001,13.5629043 L20.6558001,16.5620043 Z M12.5000001,11.0000043 C9.48329335,10.9035784 6.48883506,10.4478971 3.58000008,9.64260428 C4.02410008,8.71850428 4.75600008,7.31740428 5.93470008,5.24950428 C6.02286203,5.0936758 6.188771,4.99809906 6.36780008,4.99997632 L18.6322001,4.99997632 C18.8112158,4.99835313 18.9769885,5.09410909 19.0650001,5.25000428 C20.2436001,7.31790428 20.9755001,8.71900428 21.4196001,9.64310428 C18.5108742,10.4481967 15.5165524,10.9037098 12.5000001,11.0000043 L12.5000001,11.0000043 Z M24.0000001,9.60940428 L22.6600001,9.94440428 C22.5376001,9.66120428 22.3870001,9.34040428 22.2200001,9.00010428 L24.0000001,9.00010428 L24.0000001,9.60940428 Z M5.09000008,14.2678043 L8.00000008,15.4023043 L8.00000008,16.0000043 L5.28690008,16.0000043 L5.09000008,14.2678043 Z M17.0000001,15.4023043 L19.9100001,14.2678043 L19.7131001,16.0000043 L17.0000001,16.0000043 L17.0000001,15.4023043 Z"
                        id="Shape"
                      />
                    </g>
                  </g>
                </svg>
                <svg
                  class="main__button--bus"
                  xmlns="http://www.w3.org/2000/svg"
                  width="23px"
                  height="23px"
                  viewBox="0 0 23 23"
                  version="1.1"
                >
                  <g
                    id="Symbols"
                    stroke="none"
                    stroke-width="1"
                    fill="none"
                    fill-rule="evenodd"
                  >
                    <g
                      id="Budicon-Solid/Travel/bus-front"
                      transform="translate(-1.000000, -1.000000)"
                      fill="#FFFFFF"
                      fill-rule="nonzero"
                    >
                      <path
                        d="M23.5,10.5 L22,10.5 L22,4 C22,3 14.5,1 12.5,1 C10.5,1 3,3 3,4 L3,10.5 L1.5,10.5 C1.22385763,10.5 1,10.7238576 1,11 L1,14 C1,14.1893456 1.10715771,14.3623949 1.2764,14.4473 L3,15.3091 L3,20.5 C3.00122906,21.1338869 3.40192604,21.6981484 4,21.9082 L4,23 C4,23.5522847 4.44771525,24 5,24 L8,24 C8.55228475,24 9,23.5522847 9,23 L9,22 L16,22 L16,23 C16,23.5522847 16.4477153,24 17,24 L20,24 C20.5522847,24 21,23.5522847 21,23 L21,21.9082 C21.598074,21.6981484 21.9987709,21.1338869 22,20.5 L22,15.3091 L23.7236,14.4473 C23.8928423,14.3623949 24,14.1893456 24,14 L24,11 C24,10.7238576 23.7761424,10.5 23.5,10.5 Z M3,14.1912 L2,13.6912 L2,11.5 L3,11.5 L3,14.1912 Z M11.5,4 L13.5,4 C13.7761424,4 14,4.22385763 14,4.5 C14,4.77614237 13.7761424,5 13.5,5 L11.5,5 C11.2238576,5 11,4.77614237 11,4.5 C11,4.22385763 11.2238576,4 11.5,4 Z M7,20 C5.8954305,20 5,19.1045695 5,18 C5,16.8954305 5.8954305,16 7,16 C8.1045695,16 9,16.8954305 9,18 C9,19.1045695 8.1045695,20 7,20 Z M13.5,20 L11.5,20 C11.2238576,20 11,19.7761424 11,19.5 C11,19.2238576 11.2238576,19 11.5,19 L13.5,19 C13.7761424,19 14,19.2238576 14,19.5 C14,19.7761424 13.7761424,20 13.5,20 Z M13.5,18 L11.5,18 C11.2238576,18 11,17.7761424 11,17.5 C11,17.2238576 11.2238576,17 11.5,17 L13.5,17 C13.7761424,17 14,17.2238576 14,17.5 C14,17.7761424 13.7761424,18 13.5,18 Z M18,20 C16.8954305,20 16,19.1045695 16,18 C16,16.8954305 16.8954305,16 18,16 C19.1045695,16 20,16.8954305 20,18 C20,19.1045695 19.1045695,20 18,20 Z M21,14.4053 C18.1916493,13.9028417 15.3511813,13.6003151 12.5,13.5 C9.64881869,13.6003151 6.80835069,13.9028417 4,14.4053 L4,7 L21,7 L21,14.4053 Z M23,13.6914 L22,14.1914 L22,11.5 L23,11.5 L23,13.6914 Z M19,18 C19,18.5522847 18.5522847,19 18,19 C17.4477153,19 17,18.5522847 17,18 C17,17.4477153 17.4477153,17 18,17 C18.5520106,17.0006612 18.9993388,17.4479894 19,18 L19,18 Z M8,18 C8,18.5522847 7.55228475,19 7,19 C6.44771525,19 6,18.5522847 6,18 C6,17.4477153 6.44771525,17 7,17 C7.55201063,17.0006612 7.99933878,17.4479894 8,18 L8,18 Z"
                        id="Shape"
                      />
                    </g>
                  </g>
                </svg>
              </div>

              <div class="main__button--text">
                <h3>Prometni propisi</h3>
                <p>Pitanja i probni ispiti iz prometnih propisa</p>
              </div>

              <img
                class="main__button--arrow"
                src="./assets/images/ARROW-TEMP.png"
                alt="Arrow"
              />
            </button>
          </Link>

          <Link to="/materijali/prva-pomoc">
            <button class="main__button--big bc-red">
              <svg
                class="main__button--images main__button--heart"
                xmlns="http://www.w3.org/2000/svg"
                width="25px"
                height="23px"
                viewBox="0 0 25 23"
                version="1.1"
              >
                <g
                  id="Symbols"
                  stroke="none"
                  stroke-width="1"
                  fill="none"
                  fill-rule="evenodd"
                >
                  <g
                    id="Budicon-Solid/Medical/medical-assistance"
                    transform="translate(0.000000, -1.000000)"
                    fill="#FFFFFF"
                    fill-rule="nonzero"
                  >
                    <path
                      d="M18.5,1 C15.8035,1 13.6332,3.027 12.5045,4.349 C11.3841,3.025 9.2249,1 6.5,1 C2.6121,1 0,3.813 0,8 C0,15.437 11.4418,23.2658 11.929,23.6047 L12.497,24 L13.067,23.6757 C13.5543,23.34 25,15.5225 25,8 C25,3.813 22.3879,1 18.5,1 Z M17,13.5 C17,13.7761424 16.7761424,14 16.5,14 L14,14 L14,16.5 C14,16.7761424 13.7761424,17 13.5,17 L11.5,17 C11.2238576,17 11,16.7761424 11,16.5 L11,14 L8.5,14 C8.22385763,14 8,13.7761424 8,13.5 L8,11.5 C8,11.2238576 8.22385763,11 8.5,11 L11,11 L11,8.5 C11,8.22385763 11.2238576,8 11.5,8 L13.5,8 C13.7761424,8 14,8.22385763 14,8.5 L14,11 L16.5,11 C16.7761424,11 17,11.2238576 17,11.5 L17,13.5 Z"
                      id="Shape"
                    />
                  </g>
                </g>
              </svg>
              <div class="main__button--text">
                <h3>Prva pomoć</h3>
                <p>Pitanja i probni ispiti iz prve pomoći</p>
              </div>
              <img
                class="main__button--arrow"
                src="./assets/images/ARROW-TEMP.png"
                alt="Arrow"
              />
            </button>
          </Link>
        </main>
      </React.Fragment>
    );
  }
}
