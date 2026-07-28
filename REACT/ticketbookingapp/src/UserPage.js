
import React from "react";

function UserPage() {
  return (
    <div>
      <h2>Welcome User!</h2>

      <h3>Flight Booking</h3>

      <table border="1" cellPadding="10">
        <thead>
          <tr>
            <th>Flight No</th>
            <th>From</th>
            <th>To</th>
            <th>Fare</th>
            <th>Status</th>
          </tr>
        </thead>

        <tbody>
          <tr>
            <td>AI101</td>
            <td>Delhi</td>
            <td>Mumbai</td>
            <td>₹5000</td>
            <td>
              <button>Book Ticket</button>
            </td>
          </tr>

          <tr>
            <td>AI202</td>
            <td>Bangalore</td>
            <td>Chennai</td>
            <td>₹3500</td>
            <td>
              <button>Book Ticket</button>
            </td>
          </tr>

          <tr>
            <td>AI303</td>
            <td>Kolkata</td>
            <td>Hyderabad</td>
            <td>₹4500</td>
            <td>
              <button>Book Ticket</button>
            </td>
          </tr>
        </tbody>
      </table>

      <br />

      <p><b>You are logged in. You can book tickets.</b></p>
    </div>
  );
}

export default UserPage;