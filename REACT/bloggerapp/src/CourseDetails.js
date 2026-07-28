
import React from "react";

function CourseDetails(props) {
  return (
    <div>
      {props.show && (
        <div>
          <h2>Course Details</h2>
          <p><b>Course Name:</b> React Development</p>
          <p><b>Duration:</b> 3 Months</p>
          <p><b>Trainer:</b> ABC Faculty</p>
        </div>
      )}
    </div>
  );
}

export default CourseDetails;