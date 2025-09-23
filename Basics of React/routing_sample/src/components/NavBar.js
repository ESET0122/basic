import React from 'react'
import { Link } from 'react-router-dom'

export default function NavBar() {
  return (
    <div>
      <div><button> <Link to='/'>Home</Link> </button>
      <button> <Link to='/about'>About</Link> </button></div>

    </div>
  )
}
