import { BrowserRouter, Navigate, Route, Routes } from "react-router-dom";
import "./App.css";
import Tests from "./pages/Tests";
import Home from "./pages/Home";
import AddTestForm from "./features/test/AddTestForm";

interface testData {
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
        </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;
