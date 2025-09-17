import React, { useState } from 'react'

export default function FormEventComponent() {
    const [username,setUserName] = useState("");
    const [password,setPassword] = useState("");
    const currUsername = "RRC"
    const currPassword = "Hello"
    const onChangeHandler = (event)=>{    
        setUserName(event.target.value);
    }
    const onChangePasswordHandler = (event)=>{    
        setPassword(event.target.value)
    }
    const displayAlert = ()=>{
        if(currPassword == password && currUsername == username){
            alert("Login Successful")
        }else{
            alert("Sahi password daalo bhai")
        }
    }
    
  return (
    <><div><input type='text' value={username} placeholder='Enter Username' onChange={onChangeHandler}></input></div>
    <div><input type='text' value={password} placeholder='Enter Password' onChange={onChangePasswordHandler}></input></div>
    <div><button onClick={displayAlert}>Login</button></div></>
  )
}
