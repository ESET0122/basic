import { Fragment } from "react/jsx-runtime";

function MouseEvent(){

    return (
        <>
        <div
        style={{
            background:"green",
            color:"red",
            padding:'50px',
            border:"5px solid blue"
        }}
        onMouseEnter={()=> {console.log("mouse entered div")}}
        onMouseLeave={()=> {console.log('mouse exited div')}}
        onMouseOver={()=> {console.log('mouse over div')}}
        >
            Welcome to mouse events
        </div>
        </>

    )
}

export default MouseEvent;