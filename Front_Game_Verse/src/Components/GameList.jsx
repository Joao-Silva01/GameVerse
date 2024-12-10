import { ArrowBigLeft } from "lucide-react";
import { useEffect, useState } from "react";
import { useNavigate, useSearchParams } from "react-router-dom";
import { GetByList } from "../API/Endpoints";

function GameList(){

    const [gameList,setGameList] = useState([]);
    const [params] = useSearchParams();
    const navigate = useNavigate();

    // Pegando o Id e o nome da lista e guardando
    const ListId = params.get("listId");
    const NameList = params.get("nameList");


    // Requisições de endpoints
    async function fetchByList(listId){
        const data = await GetByList(listId);
        setGameList(data);
    }

    useEffect(() =>{
        fetchByList(ListId)
    },[])

    return(
        <div className="bg-cyan-500 w-screen h-screen p-14">
            <div className="flex justify-between">
                <button onClick={() => navigate("/GameVerse")}
                    className="text-[30px] underline">
                    <strong className="text-[50px]">G</strong>AMEVERSE
                </button>
                <h1 
                className="text-center text-6xl text-slate-200 font-bold underline">
                    {NameList}
                </h1>
                <button onClick={() => navigate(-1)}>
                    <ArrowBigLeft className=" size-[60px] text-white relative top-3 -left-10"/>
                </button>
            </div>
            <div className="flex mt-10 ml-10 mr-10 overflow-auto shadow h-[500px] bg-white justify-center rounded-[15px] ">
                <div className="m-4">

                {gameList.map(game =>(
                    <div key={game.id} 
                    className="grid w-full h-48 mb-5 pr-2 bg-slate-300 hover:bg-slate-400 rounded-md overflow-auto">
                        
                        <div className="text-start ml-3 mb-2 text-3xl font-bold">{game.title}</div>

                        <div className="ml-3">
                            <img src={game.imgUrl}
                            alt={game.title}
                            style={{width:"100px", height:"auto"}}>
                            </img>
                        </div>

                        <div className="text-2xl text-start pl-32 -mt-36">
                            <strong className="text-xl">Genre:</strong>
                            {game.genre}
                        </div>

                        <div className="text-2xl text-start pl-32 -mt-28">
                            <strong className="text-xl">Platforms:</strong>
                            {game.platforms}
                        </div>

                        <div className="text-start pl-32 -mt-20">
                        <strong className="text-xl"> Description:</strong>
                        <p className="pl-32 -ml-[10px] -mt-6">{game.shortDescription}</p>
                        </div>

                        <div className="flex pl-32 -mt-10">
                            
                            <div><img src="src\assets\star.png" style={{width:"30px", height:"auto"}}/></div>
                            <div className="text-2xl pl-2 font-semibold">{game.score}</div>
                        </div>
                        
                    </div>
                ))}

                </div>
            </div>
        </div>
    )
}

export default GameList;