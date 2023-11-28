import logo from './logo.svg';
import './App.css';
import axios from 'axios';
import { useEffect } from 'react';

function App() {
  //check api calls working flawlessly?
  function callApi() {
    let apiUrl = "http://localhost:5265/weatherforecast";
    axios.get(apiUrl).then(d => {
      console.log(d.data);
    });
  }
  //useEffect(() => { callApi(); }, []);
  return (
    <div className="todo-container">
      <div className="header">
        <h2>To-Do List</h2>
      </div>

      <div className="add-task">
        <input type="text" id="taskInput" placeholder="Enter task..." />
        <button className="add-button" onclick="addTask()">Add</button>
      </div>

      <div className="task-list" id="taskList">
        <div className='todo-item'>
          <span>1</span>
          <span class="task-name">Name</span>
          <span class="task-name">Name 1</span>
          <div class="todo-buttons">
            <button class="edit-button" onclick="editTask(this)">Edit</button>
            <button class="delete-button" onclick="deleteTask(this)">Delete</button>
          </div>
        </div>
        <div className='todo-item'>
          <span>1</span>
          <span class="task-name">Name</span>
          <span class="task-name">Name 1</span>
          <div class="todo-buttons">
            <button class="edit-button" onclick="editTask(this)">Edit</button>
            <button class="delete-button" onclick="deleteTask(this)">Delete</button>
          </div>
        </div>
      </div>
    </div>
  );
}

export default App;
