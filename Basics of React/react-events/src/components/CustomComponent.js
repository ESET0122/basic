import React, { useEffect, useState } from "react";


const useFetch = (url)=>{
    const [data,setData] = useState([])
    const [loading,setLoading] = useState(false)
    const [error,setError] = useState(null)
    const getData = () =>{
        setLoading(true)
        fetch(url)
        .then((data)=>data.json())
        .then((data)=>setData(data))
        .catch((error)=>setError(error.message))
        .finally(()=>{setLoading(false)})
    }
    useEffect(getData,[])
    return [loading,data,error]
}

const useFetchjson = (url)=>{
    const [data,setData] = useState([])
    const [loading,setLoading] = useState(false)
    const [error,setError] = useState(null)
    const getData = () =>{
        setLoading(true)
        fetch(url)
        .then((data)=>data.json())
        .then((data)=>setData(data))
        .catch((error)=>setError(error.message))
        .finally(()=>{setLoading(false)})
    }
    useEffect(getData,[])
    return {loading,data,error}
}

export default function CustomComponent(){
    // const [data,setData] = useState([])
    // const [loading,setLoading] = useState(false)
    // const [error,setError] = useState(null)
    // const getData = () =>{
    //     setLoading(true)
    //     fetch('https://jsonplaceholder.typicode.com/users')
    //     .then((data)=>data.json())
    //     .then((data)=>setData(data))
    //     .catch((error)=>setError(error.message))
    //     .finally(()=>{setLoading(false)})
    // }
    // useEffect(getData,[])
    const [loading,data,error] = useFetch('https://jsonplaceholder.typicode.com/users')
    return(
        <div>
            {/* {
                loading?<>loading...</>:<></>
            } */}
            {
                loading && <>loading...</>
            }
            {
                error && <>error..</>
            }
            {
                data.map((item)=><div key={item.id}>{item.id}. {item.name} </div>)
            }
        </div>
    )
}