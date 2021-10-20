//import liraries
import React, { useEffect, useState } from 'react';
import TodoItem from "./TodoItem"

// create a component
const TodoItemList = () => {
  const [todoList,setTodoList] = useState([]);

  useEffect(() => {
    fetch("https://localhost:44373/api/todo",
    {
      method: "GET"
    })
    .then(res => { return res.json() })
    .then(response => {
      setTodoList(response);
    });
  }, []);

  return (
    <div>
      <h3>Todo List</h3>
      {todoList.map((x,i)=> {
        return (
          <TodoItem data={x}></TodoItem>
        )
      })}
    </div>
  );
};

//make this component available to the app
export default TodoItemList;
