
import React, { useState } from "react";
import GuestPage from "./GuestPage";
import UserPage from "./UserPage";

function LoginControl() {
  const [isLoggedIn, setIsLoggedIn] = useState(false);

  const handleLogin = () => {
    setIsLoggedIn(true);
  };

  const handleLogout = () => {
    setIsLoggedIn(false);
  };

  return (
    <div>
      <h1>Ticket Booking Application</h1>

      {isLoggedIn ? (
        <>
          <button onClick={handleLogout}>Logout</button>
          <UserPage />
        </>
      ) : (
        <>
          <button onClick={handleLogin}>Login</button>
          <GuestPage />
        </>
      )}
    </div>
  );
}

export default LoginControl;