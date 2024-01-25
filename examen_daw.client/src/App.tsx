import { BrowserRouter, Navigate, Route, Routes } from "react-router-dom";
import "./App.css";
import Tests from "./pages/Tests";
import Home from "./pages/Home";
import AddTestForm from "./features/test/AddTestForm";
import Profesori from "./pages/Profesori";
import AddProfesorForm from "./features/profesori/AddProfesorForm";
import Materii from "./pages/Materii";
import AddMaterieForm from "./features/materii/AddMaterieForm";

interface testData {
  name: string;
}

interface profesorData {
  name: string;
}

function App() {
  const handleAddTest = async (testData: testData): Promise<void> => {
    try {
      const response = await fetch("https://localhost:7216/api/Test/create", {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify(testData),
      });

      if (response.ok) {
        console.log("test added successfully");
      } else {
        const errorText = await response.text();
        console.error("Error adding test:", response.status, errorText);
      }
    } catch (error) {
      console.error("Error adding test:", error);
    }
  };

  const handleAddProfesor = async (
    profesorData: profesorData
  ): Promise<void> => {
    try {
      const response = await fetch(
        "https://localhost:7216/api/Profesor/create",
        {
          method: "POST",
          headers: {
            "Content-Type": "application/json",
          },
          body: JSON.stringify(profesorData),
        }
      );

      if (response.ok) {
        console.log("Profesor added successfully");
      } else {
        const errorText = await response.text();
        console.error("Error adding profesor:", response.status, errorText);
      }
    } catch (error) {
      console.error("Error adding profesor:", error);
    }
  };

  const handleAddMaterie = async (materieData: MaterieData): Promise<void> => {
    try {
      const response = await fetch(
        "https://localhost:7216/api/Materie/create",
        {
          method: "POST",
          headers: {
            "Content-Type": "application/json",
          },
          body: JSON.stringify(materieData),
        }
      );

      if (response.ok) {
        console.log("Materie added successfully");
      } else {
        const errorText = await response.text();
        console.error("Error adding Materie:", response.status, errorText);
      }
    } catch (error) {
      console.error("Error adding Materie:", error);
    }
  };
  return (
    <div className="App">
      <BrowserRouter>
        <Routes>
          <Route index element={<Navigate to="home" />} />
          <Route path="/home" element={<Home />} />
          <Route path="/tests" element={<Tests />} />
          <Route
            path="/tests/add"
            element={<AddTestForm onAddTest={handleAddTest} />}
          />
          <Route path="/profesori" element={<Profesori />} />
          <Route
            path="/profesori/add"
            element={<AddProfesorForm onAddProfesor={handleAddProfesor} />}
          />
          <Route path="/materii" element={<Materii />} />
          <Route
            path="/materii/add"
            element={<AddMaterieForm onAddMaterie={handleAddMaterie} />}
          />
        </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;
