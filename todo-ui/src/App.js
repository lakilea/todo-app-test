import logo from './logo.svg';
import './App.css';
import TodoItemList from './components/TodoItemList';
import { useState } from 'react';
import AddTodoItem from './components/AddTodoItem';

function App() {

  const [isAddMode,setIsAddMode] = useState(false);

  return (
    isAddMode ?
    <div className="App">
      <AddTodoItem />
    </div>
    :
    <div className="App">
      <TodoItemList>
      </TodoItemList>
      <button onClick={()=>setIsAddMode(true)}>Add New Todo Item</button>
    </div>
  );
}

export default App;
