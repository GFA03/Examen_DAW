import React, { useState, ChangeEvent, FormEvent } from "react";
import { useNavigate } from "react-router-dom";

interface ProfesorData {
  name: string;
  type: string;
}

interface AddProfesorFormProps {
  onAddProfesor: (profesorData: ProfesorData) => void;
}

const AddProfesorForm: React.FC<AddProfesorFormProps> = ({ onAddProfesor }) => {
  const navigate = useNavigate();

  const [profesorData, setProfesorData] = useState<ProfesorData>({
    name: "",
    type: "",
  });

  const handleInputChange = (e: ChangeEvent<HTMLInputElement>) => {
    const { name, value } = e.target;
    setProfesorData({ ...profesorData, [name]: value });
  };

  const handleSubmit = async (e: FormEvent<HTMLFormElement>) => {
    e.preventDefault();
    // Call the function passed from the parent component to add the test
    try {
      // Call the function passed from the parent component to add the test
      await onAddProfesor(profesorData);
      // If the test was added successfully, navigate to the tests list
      console.log("profesor added successfully");
      navigate("/profesori");
    } catch (error) {
      console.error("Error adding profesor:", error);
    }
  };

  return (
    <form onSubmit={handleSubmit}>
      <label>
        Name:
        <input
          type="text"
          name="name"
          value={profesorData.name}
          onChange={handleInputChange}
          required
        />
      </label>
      <br />
      <label>
        Type:
        <input
          type="text"
          name="type"
          value={profesorData.type}
          onChange={handleInputChange}
          required
        />
      </label>
      <button type="submit">Add Profesor</button>
    </form>
  );
};

export default AddProfesorForm;
