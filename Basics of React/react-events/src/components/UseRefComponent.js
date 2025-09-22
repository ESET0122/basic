import React, { useRef } from 'react'

export default function UseRefComponent() {
  
    const inputElement = useRef(null);
    const focusHandler = ()=>{
        console.log(inputElement.current);
        inputElement.current.focus();
    }
    return (
    <>Welcome to use ref hook
    <br/>
    <input ref = {inputElement}/>
    <br/>
    <button onClick={focusHandler}>focus</button>
    </>
  )
}
