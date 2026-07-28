
import React from "react";

function BookDetails(props) {
  if (props.show) {
    return (
      <div>
        <h2>Book Details</h2>
        <p><b>Book Name:</b> React Basics</p>
        <p><b>Author:</b> John Smith</p>
        <p><b>Price:</b> ₹500</p>
      </div>
    );
  }

  return null;
}

export default BookDetails;