import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'

function App(){
  let count = 0
  const increment = ()=>{
    count++
    document.getElementById('a').innerText = count
  }
  const decrement = ()=>{
    count--
    document.getElementById('a').innerText = count
  }
  

  return(
    <>
      <h1>Counter WebApp</h1>
      <h1 id='a'>
        0
      </h1>
      <button onClick={increment}> Increment</button>
      <button onClick={decrement}> Decrement</button>
    </>
  )
}

// function App() {
//   // const [count, incCount] = useState(0)
//   // const cnt = 0
//   // increment = ()=> cnt+1
//   // decrement = ()=> cnt-1


//   return (
//     <>
//     <h1>Counter App</h1>
//     <h2 id='a'>0</h2>
//     <button onClick={()=>{
//       const element = document.getElementById('a');
//       var curr = parseInt(element.textContent)
//       element.textContent = curr+1
//       }}>Increment</button>
//     <button onClick={()=>{
//       const element = document.getElementById('a');
//       var curr = parseInt(element.textContent)
//       element.textContent = curr-1
//       }}>Decrement</button>
//       {/* <div>
//         <a href="https://vite.dev" target="_blank">
//           <img src={viteLogo} className="logo" alt="Vite logo" />
//         </a>
//         <a href="https://react.dev" target="_blank">
//           <img src={reactLogo} className="logo react" alt="React logo" />
//         </a>
//       </div>
//       <h1>Counter WebApp</h1>
//       <div className="card">
//         <button onClick={() => incCount((count) => count + 1)}>
//           count is {count}
//         </button>
//         <p>
//           Edit <code>src/App.jsx</code> and save to test HMR
//         </p>
//       </div>
//       <p className="read-the-docs">
//         Click on the Vite and React logos to learn more
//       </p> */}
//     </>
//   )
// }

export default App
