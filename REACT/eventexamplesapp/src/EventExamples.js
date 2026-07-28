import React, { useState } from "react";

function EventExamples() {
  const [count, setCount] = useState(0);

  // Increment Counter
  const increment = () => {
    setCount(count + 1);
  };

  // Decrement Counter
  const decrement = () => {
    setCount(count - 1);
  };

  // Say Hello
  const sayHello = () => {
    alert("Hello! Have a Nice Day.");
  };

  // Multiple Methods
  const handleIncrement = () => {
    increment();
    sayHello();
  };

  // Welcome Function
  const sayWelcome = (msg) => {
    alert(msg);
  };

  // Synthetic Event
  const onPress = () => {
    alert("I was clicked");
  };

  return (
    <div>
      <h2>Event Examples</h2>

      <h3>Counter: {count}</h3>

      <button onClick={handleIncrement}>Increment</button>

      <button onClick={decrement}>Decrement</button>

      <br /><br />

      <button onClick={() => sayWelcome("Welcome")}>
        Say Welcome
      </button>

      <br /><br />

      <button onClick={onPress}>
        OnPress
      </button>
    </div>
  );
}

export default EventExamples;