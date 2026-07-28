import React from "react";

function CalculateScore(props) {

    const average = props.Total / props.goal;

    return (
        <div className="card">
            <h2>Student Details</h2>

            <p><b>Name :</b> {props.Name}</p>
            <p><b>School :</b> {props.School}</p>
            <p><b>Total Marks :</b> {props.Total}</p>
            <p><b>Goal :</b> {props.goal}</p>
            <p><b>Average Score :</b> {average}</p>
        </div>
    );
}

export default CalculateScore;