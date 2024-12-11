import { ArrowBigLeft } from "lucide-react";
import { useEffect, useState } from "react";
import { useNavigate, useSearchParams } from "react-router-dom";
import { fetchByList, UpdatePosition } from "../API/Endpoints";
import GameListItem from "./GameListItem";

function GameList(){

    const [gameList,setGameList] = useState([]);
    const [params] = useSearchParams();
    const navigate = useNavigate();

    // Pegando o Id e o nome da lista e guardando
    const ListId = params.get("listId");
    const NameList = params.get("nameList");


    // Requisições de endpoints
    function GetByList(){
        const data = fetchByList(ListId);
        setGameList(data);
    }

    function HandleUpdatePosition(listId, init, dest){
        UpdatePosition(listId,init,dest);
    }
    

    useEffect(() =>{
        GetByList()
    },[])

    return(
        <div className="bg-cyan-500 w-screen h-screen p-14">
            <div className="flex justify-between">
                <button onClick={() => navigate("/")}
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
                    <GameListItem key={game.id} game={game}/>
                ))}

                </div>
            </div>
        </div>
    )
}

export default GameList;