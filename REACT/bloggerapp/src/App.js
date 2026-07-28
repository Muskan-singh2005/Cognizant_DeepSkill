import React from "react";
import BookDetails from "./BookDetails";
import BlogDetails from "./BlogDetails";
import CourseDetails from "./CourseDetails";

function App() {
  return (
    <div style={{ padding: "20px" }}>
      <BookDetails show={true} />

      <hr />

      <BlogDetails show={true} />

      <hr />

      <CourseDetails show={true} />
    </div>
  );
}

export default App;