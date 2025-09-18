import React, { useState } from 'react'

export default function LoginFormComponent() {

    const [loginState,setLoginState] = useState({
        username:"",
        password: ""
    });
    const onUsernameChangeHandler = (e)=>{
        setLoginState({
            ...loginState,
            username: e.target.value
        }
        )
    }
    const onPasswordChangeHandler = (e)=>{
        setLoginState({
            ...loginState,
            password: e.target.value
        }
    )
    }
    const onSubmitHandler = (e)=>{
        e.preventDefault()
        if(loginState.username !== "username"){
            alert('invalid username')
            return;
        }
        if(loginState.password !== "password"){
            alert('invalid password')
            return;
        }
        alert('Login Successful')
        
    }
  return (
    <>
    Welcome to login page
    <br/>
    <form onSubmit={onSubmitHandler}>
    <input name='username' type= "text" value = {loginState.username} onChange = {onUsernameChangeHandler}/>
    <br/>
    <input name='password' type='password' value = {loginState.password} onChange = {onPasswordChangeHandler}/>
    <br />
    <button type = "submit" > login</button>
    
    <button type = "reset"> reset</button>
    </form>
    </>
  )
}
