import { Link } from "react-router-dom";

export default function Home() {
  return (
    <div>
      <h1>Welcome to the Exam, Mr. Student!</h1>
      <p>This is the Home page.</p>
      <Link to="/tests">Go to the Test List</Link>
    </div>
  );
}
