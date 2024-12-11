import { ArrowBigLeft } from "lucide-react";
import { useEffect, useState } from "react";
import { useNavigate, useSearchParams } from "react-router-dom";
import { fetchByList, UpdatePosition,  } from "../API/Endpoints";
import GameListItem from "./GameListItem";
import { DragDropContext, Droppable } from "@hello-pangea/dnd";

function GameList(){

    const [gameList, setGameList] = useState([]);
    const [params] = useSearchParams();
    const navigate = useNavigate();

    // Pegando o Id e o nome da lista e guardando
    const ListId = params.get("listId");
    const NameList = params.get("nameList");

    function handleDragEnd(result){
        // Se o item não foi colocado em um local válido, termina a função
        if(!result.destination) {return;}
        
        // Atualiza na Lista local
        const games = gameList;
        const [localList] = games.splice(result.source.index,1);
        games.splice(result.destination.index,0,localList);
        setGameList(games);


        // Atualiza na API
        try{
            handleUpdatePosition(ListId,result.source.index,result.destination.index);
        }catch(error){
            console.error("Error Update API: ", error)
            getByList(ListId);
        }
    }
    



    // Requisições de endpoints
    async function getByList(){
        const data = await fetchByList(ListId);
        setGameList(data);
    }

    
    async function handleUpdatePosition(listId, init, dest) {
        await UpdatePosition(listId,init, dest);
    }

    useEffect(() =>{
        getByList()
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
                <DragDropContext onDragEnd={handleDragEnd}>
                    <Droppable droppableId="game" direction="vertical">
                        {(provided) => (
                            <div className="m-4"
                            ref={provided.innerRef}
                            {...provided.droppableProps}>

                            {gameList.map((game,position) =>(
                                <GameListItem 
                                key={game.id} 
                                game={game}
                                position={position}/>
                            ))}
                            {provided.placeholder}
                        </div>
                        )}
                    </Droppable>
                </DragDropContext>
            </div>
        </div>
    )
}

export default GameList;