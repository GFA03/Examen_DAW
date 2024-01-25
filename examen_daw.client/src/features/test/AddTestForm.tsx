import React, { useState, ChangeEvent, FormEvent } from "react";
import { useNavigate } from "react-router-dom";

interface TestData {
  name: string;
}

interface AddTestFormProps {
  onAddTest: (testData: TestData) => void;
}

const AddTestForm: React.FC<AddTestFormProps> = ({ onAddTest }) => {
  const navigate = useNavigate();

  const [testData, setTestData] = useState<TestData>({
    name: "",
  });

  const handleInputChange = (e: ChangeEvent<HTMLInputElement>) => {
    const { name, value } = e.target;
    setTestData({ ...testData, [name]: value });
  };

  const handleSubmit = async (e: FormEvent<HTMLFormElement>) => {
    e.preventDefault();
    // Call the function passed from the parent component to add the test
    try {
      // Call the function passed from the parent component to add the test
      await onAddTest(testData);
      // If the test was added successfully, navigate to the tests list
      console.log("test added successfully");
      navigate("/tests");
    } catch (error) {
      console.error("Error adding test:", error);
    }
  };

  return (
    <form onSubmit={handleSubmit}>
      <label>
        Name:
        <input
          type="text"
          name="name"
          value={testData.name}
          onChange={handleInputChange}
          required
        />
      </label>
      <br />
      <button type="submit">Add test</button>
    </form>
  );
};

export default AddTestForm;
