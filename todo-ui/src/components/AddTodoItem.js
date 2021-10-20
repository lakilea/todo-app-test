//import liraries
import React, { useEffect, useState } from 'react';

// create a component
const AddTodoItem = ({ data }) => {

  const [text,setText] = useState("");

  const addNewItem = () => {

  }

  return (
    <div className="add-item">
      <input type="text" value={text} onKeyUp={(x)=> { debugger; setText(x.target.value) } }></input>
      <button onClick={()=> addNewItem() }>Add</button>
      <button>Cancel</button>
    </div>
  );
};

//make this component available to the app
export default AddTodoItem;
