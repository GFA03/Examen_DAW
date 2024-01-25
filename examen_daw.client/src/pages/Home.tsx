import { Link } from "react-router-dom";

export default function Home() {
  return (
    <div>
      <h1>Welcome to the Exam, Mr. Student!</h1>
      <p>This is the Home page.</p>
      <div>
        <Link to="/tests">Go to the Test List</Link>
      </div>
      <div>
        <Link to="/profesori">Go to the Professors list</Link>
      </div>
      <div>
        <Link to="/materii">Go to the Courses list</Link>
      </div>
    </div>
  );
}
