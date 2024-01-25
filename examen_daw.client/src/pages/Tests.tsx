import { useEffect, useState } from "react";
import { Link } from "react-router-dom";

interface Test {
  id: string;
  name: string;
}

function Tests() {
  const [tests, setTests] = useState<Test[]>();

  useEffect(() => {
    fetchTests();
  }, []);

  const fetchTests = async () => {
    try {
      const response = await fetch("https://localhost:7216/api/Test/all");
      const data = await response.json();
      setTests(data);
    } catch (error) {
      console.error("Error fetching tests:", error);
    }
  };

  const handleDeleteTest = async (id: string) => {
    try {
      // Make a DELETE request to the API endpoint for deleting the test
      const response = await fetch(
        `https://localhost:7216/api/Test/delete/${id}`,
        {
          method: "DELETE",
        }
      );

      if (response.ok) {
        // test deleted successfully, update the test list
        fetchTests();
      } else {
        // Handle error response
        console.error("Error deleting test:", response.statusText);
      }
    } catch (error: unknown) {
      // Handle network or other errors
      console.error("Error:", error);
    }
  };

  return (
    <>
      <div>
        <h1>Test List</h1>
        <ul>
          {tests?.map((test) => (
            <li key={test.id}>
              {test.name}
              <button onClick={() => handleDeleteTest(test.id)}>Delete</button>
            </li>
          ))}
        </ul>
      </div>
      <div>
        <Link to="/home">Go to Home Page</Link>
      </div>
      <div>
        <Link to="/tests/add">Add test</Link>
      </div>
    </>
  );
}

export default Tests;
