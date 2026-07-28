import React from "react";
import office from "./images/office.jpg";

import "./App.css";


function App() {

  const offices = [
    {
      name: "Smart Office",
      rent: 55000,
      address: "MG Road, Bangalore"
    },
    {
      name: "Tech Park",
      rent: 75000,
      address: "Electronic City, Bangalore"
    },
    {
      name: "Business Hub",
      rent: 60000,
      address: "Whitefield, Bangalore"
    }
  ];

  return (
    <div>
      <h1>Office Space Rental App</h1>

      <img
        src={office}
        alt="Office Space"
        width="500"
        height="300"
      />

      <h2>Available Office Spaces</h2>

      {offices.map((item, index) => (
        <div key={index}>
          <h3>{item.name}</h3>

          <p>
            <b>Rent:</b>{" "}
            <span
              style={{
                color: item.rent < 60000 ? "red" : "green"
              }}
            >
              {item.rent}
            </span>
          </p>

          <p>
            <b>Address:</b> {item.address}
          </p>

          <hr />
        </div>
      ))}
    </div>
  );
}

export default App;