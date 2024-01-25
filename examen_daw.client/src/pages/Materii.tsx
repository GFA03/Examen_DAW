import { useEffect, useState } from "react";
import { Link } from "react-router-dom";

interface Materie {
  id: string;
  name: string;
}

function Materii() {
  const [materii, setMaterii] = useState<Materie[]>();

  useEffect(() => {
    fetchMaterii();
  }, []);

  const fetchMaterii = async () => {
    try {
      const response = await fetch("https://localhost:7216/api/Materie/all");
      const data = await response.json();
      setMaterii(data);
    } catch (error) {
      console.error("Error fetching materii:", error);
    }
  };

  const handleDeleteMaterie = async (id: string) => {
    try {
      // Make a DELETE request to the API endpoint for deleting the test
      const response = await fetch(
        `https://localhost:7216/api/Materie/delete/${id}`,
        {
          method: "DELETE",
        }
      );

      if (response.ok) {
        // test deleted successfully, update the test list
        fetchMaterii();
      } else {
        // Handle error response
        console.error("Error deleting materie:", response.statusText);
      }
    } catch (error: unknown) {
      // Handle network or other errors
      console.error("Error:", error);
    }
  };

  return (
    <>
      <div>
        <h1>Courses list</h1>
        <ul>
          {materii?.map((materie) => (
            <li key={materie.id}>
              {materie.name}
              <button onClick={() => handleDeleteMaterie(materie.id)}>
                Delete
              </button>
            </li>
          ))}
        </ul>
      </div>
      <div>
        <Link to="/home">Go to Home Page</Link>
      </div>
      <div>
        <Link to="/materii/add">Add Course</Link>
      </div>
    </>
  );
}

export default Materii;
