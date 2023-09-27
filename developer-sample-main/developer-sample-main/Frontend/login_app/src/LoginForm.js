import React, { useState } from "react";
import './LoginForm.css';

const LoginForm = (props) => {
    // Initialize state for input values
    const [formData, setFormData] = useState({
        name: "",
        password: "",
    });

    // Update state when input values change
    const handleChange = (event) => {
        const { name, value } = event.target;
        setFormData({
            ...formData,
            [name]: value,
        });
    };

    // Handle form submission
    const handleSubmit = (event) => {
        event.preventDefault();
        // Pass the form data to the parent component via the onSubmit prop
        props.onSubmit(formData);
    };

    return (
        <form className="form" onSubmit={handleSubmit}>
            <h1>Login</h1>
            <label htmlFor="name">Name</label>
            <input
                type="text"
                id="name"
                name="name" // Add a name attribute to capture input value
                value={formData.name} // Use controlled input value
                onChange={handleChange}
                required
            />
            <label htmlFor="password">Password</label>
            <input
                type="password"
                id="password"
                name="password" // Add a name attribute to capture input value
                value={formData.password} // Use controlled input value
                onChange={handleChange}
                required
            />
            <button type="submit">Continue</button>
        </form>
    );
}

export default LoginForm;
