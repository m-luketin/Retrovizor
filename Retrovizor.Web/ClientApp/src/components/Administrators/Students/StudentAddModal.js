import React, { Component } from "react";

export default class StudentAddModal extends Component {
  render() {
    return (
      <aside className="modal--wrapper">
        <h3 className="modal__title">Dodaj kandidata</h3>
        <div className="modal__input--wrapper">
          <svg
            className="modal__icon--name"
            xmlns="http://www.w3.org/2000/svg"
            width="25px"
            height="31px"
            viewBox="0 0 25 31"
            version="1.1"
          >
            <g
              id="Administrator"
              stroke="none"
              strokeWidth="1"
              fill="none"
              fillRule="evenodd"
            >
              <g
                id="Instruktori-dodavanje(3)"
                transform="translate(-329.000000, -692.000000)"
                fill="#8B959E"
                fillRule="nonzero"
              >
                <g id="Group" transform="translate(0.000000, 678.000000)">
                  <g
                    id="Budicon-Outline/User/user"
                    transform="translate(327.000000, 12.000000)"
                  >
                    <path
                      d="M7.25,10.2083333 C7.25,6.18125703 10.4959356,2.91666667 14.5,2.91666667 C18.5040644,2.91666667 21.75,6.18125703 21.75,10.2083333 C21.75,14.2354096 18.5040644,17.5 14.5,17.5 C10.4977906,17.4954993 7.25447496,14.2335439 7.25,10.2083333 Z M14.5,18.9583333 C8.0934969,18.9583333 2.9,24.1816779 2.9,30.625 L2.9,31.3541667 C2.9,31.7568743 3.22459356,32.0833333 3.625,32.0833333 L25.375,32.0833333 C25.7754064,32.0833333 26.1,31.7568743 26.1,31.3541667 L26.1,30.625 C26.1,24.1816779 20.9065031,18.9583333 14.5,18.9583333 Z"
                      id="Shape"
                    />
                  </g>
                </g>
              </g>
            </g>
          </svg>
          <input type="text" placeholder="Ime i prezime" />
        </div>
        <div className="modal__input--wrapper">
          <svg
            className="modal__icon--phone"
            xmlns="http://www.w3.org/2000/svg"
            width="23px"
            height="23px"
            viewBox="0 0 23 23"
            version="1.1"
          >
            <g
              id="Symbols"
              stroke="none"
              strokeWidth="1"
              fill="none"
              fillRule="evenodd"
            >
              <g
                id="Budicon-Solid/Communication/call"
                transform="translate(-1.000000, -1.000000)"
                fill="#8B959E"
                fillRule="nonzero"
              >
                <path
                  d="M23.5545499,20.7935954 L21.8337499,22.5142954 C20.1084669,24.2426029 17.3952615,24.4928598 15.3829499,23.1092954 C12.7045902,21.3404908 10.1660866,19.3685211 7.78984992,17.2107954 C5.63193288,14.8342736 3.65979587,12.295469 1.89084992,9.61679542 C0.507455066,7.60450799 0.757614715,4.89148707 2.48564992,3.16609542 L4.20644992,1.44539542 C4.49152127,1.16021917 4.87822397,1 5.28144992,1 C5.68467588,1 6.07137857,1.16021917 6.35644992,1.44539542 L9.22264992,4.31159542 C9.50782617,4.59666677 9.66804534,4.98336947 9.66804534,5.38659542 C9.66804534,5.78982138 9.50782617,6.17652407 9.22264992,6.46159542 L7.98804992,7.69609542 C7.65612625,8.02766642 7.59534102,8.54378232 7.84114992,8.94339542 C8.84688981,10.6268651 10.0308,12.1972652 11.3724499,13.6274954 C12.8026677,14.969117 14.3730315,16.1530251 16.0564499,17.1587954 C16.456077,17.4046164 16.9722206,17.3437866 17.3037499,17.0117954 L18.5383499,15.7771954 C19.1321064,15.183611 20.0945934,15.183611 20.6883499,15.7771954 L23.5547499,18.6436954 C23.8398691,18.9287892 24,19.3154854 24,19.7186869 C24,20.1218883 23.8397221,20.5085547 23.5545499,20.7935954 L23.5545499,20.7935954 Z"
                  id="Shape"
                />
              </g>
            </g>
          </svg>
          <input type="text" placeholder="Kontakt" />
        </div>
        <div className="modal__input--wrapper">
          <p className="modal__icon--category">B</p>
          <input type="text" placeholder="Kategorija" />
        </div>

        <div className="modal__input--wrapper modal__input--wrapper--bottom">
          <button className="modal__button--empty">Poništi</button>
          <button className="modal__button--blue">Spremi</button>
        </div>
      </aside>
    );
  }
}
