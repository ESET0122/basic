import React, { useEffect, useState } from 'react'

export default function UseEffectComponent() {

    const suggestions = ["maxhub","bottle","cat","dawg"];
    const [recommendation,setRecommendation] = useState([]);
    const[search,setSearch] = useState("");
  useEffect(()=>{
    setRecommendation(suggestions.filter((element)=>element.includes(search)));
    
  },[search])
    return (
    <div>
        <input value={search} onChange={(e)=>setSearch(e.target.value)}/>
        {
            recommendation.map((rec,index)=>(<div key={index}>{index}.{rec}</div>))
        }
    </div>
  )
}
