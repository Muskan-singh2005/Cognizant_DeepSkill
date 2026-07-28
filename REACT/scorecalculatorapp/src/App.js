import './Stylesheets/mystyle.css';
import CalculateScore from './Components/CalculateScore';

function App() {
  return (
    <div>
      <CalculateScore
        Name="Rahul"
        School="ABC Public School"
        Total={450}
        goal={5}
      />
    </div>
  );
}

export default App;