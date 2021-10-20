//import liraries
import React, { useEffect } from 'react';

// create a component
const TodoItem = ({ data }) => {
  return (
    <div className="todo-item">
      <span>{data.text} - {data.isCompleted ? "completed" : "not completed"}</span>
    </div>
  );
};

//make this component available to the app
export default TodoItem;
