import { createContext, useState } from "react";
// import UseContextSample from "./components/UseContextSample";
import UseReducerComponent from "./components/UseReducerComponent";
import CustomComponent from "./components/CustomComponent";


// const Context = createContext();
// export {Context};
function App() {

  // const [count,setCount] = useState(0);
  // const [username,setUsername] = useState("username");


  return (
    // <Context.Provider value={{count,setCount,username,setUsername}}>
      
    // </Context.Provider>
    <>
    <CustomComponent/>
    </>
    
  );
}

export default App;
