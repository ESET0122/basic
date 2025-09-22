import React, { useContext } from 'react'
import { Context } from '../App';

export default function UseContextSample() {
    const {username} = useContext(Context);
  return (
    <div>
        welcome to use context
        <br/>
        {username}
    </div>
  )
}
