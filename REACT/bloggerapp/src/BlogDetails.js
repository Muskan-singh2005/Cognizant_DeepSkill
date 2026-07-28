
import React from "react";

function BlogDetails(props) {
  return (
    <div>
      {props.show ? (
        <div>
          <h2>Blog Details</h2>
          <p><b>Title:</b> Introduction to React</p>
          <p><b>Author:</b> Admin</p>
          <p><b>Description:</b> Learn the basics of React components and JSX.</p>
        </div>
      ) : (
        <h3>Blog Details are not available.</h3>
      )}
    </div>
  );
}

export default BlogDetails;