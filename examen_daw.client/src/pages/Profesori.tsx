import { useEffect, useState } from "react";
import { Link } from "react-router-dom";

interface Profesor {
  id: string;
  name: string;
}

function Profesori() {
  const [profesori, setProfesori] = useState<Profesor[]>();

  useEffect(() => {
    fetchProfesori();
  }, []);

  const fetchProfesori = async () => {
    try {
      const response = await fetch("https://localhost:7216/api/Profesor/all");
      const data = await response.json();
      setProfesori(data);
    } catch (error) {
      console.error("Error fetching profesori:", error);
    }
  };

  const handleDeleteProfesor = async (id: string) => {
    try {
      // Make a DELETE request to the API endpoint for deleting the test
      const response = await fetch(
        `https://localhost:7216/api/Profesor/delete/${id}`,
        {
          method: "DELETE",
        }
      );

      if (response.ok) {
        // test deleted successfully, update the test list
        fetchProfesori();
      } else {
        // Handle error response
        console.error("Error deleting profesor:", response.statusText);
      }
    } catch (error: unknown) {
      // Handle network or other errors
      console.error("Error:", error);
    }
  };

  return (
    <>
      <div>
        <h1>Professors list</h1>
        <ul>
          {profesori?.map((prof) => (
            <li key={prof.id}>
              {prof.name}
              <button onClick={() => handleDeleteProfesor(prof.id)}>
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
        <Link to="/profesori/add">Add Profesor</Link>
      </div>
    </>
  );
}

export default Profesori;
