import React from "react";
import "./LoginAttemptList.css";

const LoginAttempt = (props) => <li {...props}>{props.children}</li>;

const LoginAttemptList = ({ loginAttempts }) => (
    <div className="Attempt-List-Main">
        <p>Recent activity</p>
        <input type="input" placeholder="Filter..." />
        <ul className="Attempt-List">
            {loginAttempts.map((attempt, index) => (
                <LoginAttempt key={index}>{attempt}</LoginAttempt>
            ))}
        </ul>
    </div>
);

export default LoginAttemptList;
