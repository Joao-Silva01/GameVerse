import { useState } from "react"
import fetchAllList from "./API/Endpoints";
import { useEffect } from "react";
import AllGameList from "./Components/AllGameList";


function App() {
  const[data,setData] = useState([]);

  async function GetAllList(){
      const allList = await fetchAllList();
      setData(allList);
  }

  useEffect(() =>{
    GetAllList();
  },[]);

  return (
    <div className="bg-cyan-500 w-screen h-screen flex | justify-center p-44">
      <h1 className="text-[65px] text-slate-200 text-center absolute top-[20px] font-bold underline">
        <strong className="text-[100px]">G</strong>AMEVERSE</h1>
        <div className="h[500px] space-x-4">
          <AllGameList data={data}/>
        </div>
    </div>
  )
}

export default App
