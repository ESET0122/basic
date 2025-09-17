
import { useState } from 'react';
import './App.css';

// function App({name,tagline}) {
//   return (
//     <div>
//       <p>{name}</p>
//       <p>{tagline}</p>
//     </div>
//   );
// }

function App(){
  
  const [counter,setCounter] = useState(0);

  const incrementHandler = ()=>{
    setCounter(counter+1);
  }
  const decrementHandler = ()=>{
    setCounter(counter-1);
  }
  return(
  <div>
    <p>{counter}</p>
    <button onClick={incrementHandler}>
        Increment
    </button>
    <button onClick={decrementHandler}>
        Decrement
    </button>
  </div>

  );
}

export default App;
