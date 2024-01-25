import React, { useState, ChangeEvent, FormEvent } from "react";
import { useNavigate } from "react-router-dom";

interface MaterieData {
  name: string;
}

interface AddMaterieFormProps {
  onAddMaterie: (materieData: MaterieData) => void;
}

const AddMaterieForm: React.FC<AddMaterieFormProps> = ({ onAddMaterie }) => {
  const navigate = useNavigate();

  const [materieData, setMaterieData] = useState<MaterieData>({
    name: "",
  });

  const handleInputChange = (e: ChangeEvent<HTMLInputElement>) => {
    const { name, value } = e.target;
    setMaterieData({ ...materieData, [name]: value });
  };

  const handleSubmit = async (e: FormEvent<HTMLFormElement>) => {
    e.preventDefault();
    // Call the function passed from the parent component to add the test
    try {
      // Call the function passed from the parent component to add the test
      await onAddMaterie(materieData);
      // If the test was added successfully, navigate to the tests list
      console.log("Materie added successfully");
      navigate("/materii");
    } catch (error) {
      console.error("Error adding Materie:", error);
    }
  };

  return (
    <form onSubmit={handleSubmit}>
      <label>
        Name:
        <input
          type="text"
          name="name"
          value={materieData.name}
          onChange={handleInputChange}
          required
        />
      </label>
      <br />
      <button type="submit">Add Materie</button>
    </form>
  );
};

export default AddMaterieForm;
