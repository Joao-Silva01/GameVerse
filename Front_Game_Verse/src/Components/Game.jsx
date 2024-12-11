import { useEffect, useState } from "react"
import { useNavigate, useSearchParams } from "react-router-dom";
import { fetchGameById } from "../API/Endpoints";
import { ArrowBigLeft } from "lucide-react";


export function Game(){
    const[game,setGame] = useState([]);
    const navigate = useNavigate();
    const[params] = useSearchParams();
    const gameId = params.get("gameId");

    

    async function getGame(gameId) {
        const findGame = await fetchGameById(gameId)
        setGame(findGame);
    }

    useEffect(() =>{
        getGame(gameId)
    },[])
    return(
        <div className="bg-cyan-500 w-screen h-screen grid justify-center">
            <div>
                <button onClick={() => navigate("/")}
                    className="relative top-[47px] -left-[152px] text-[30px] underline">
                        <strong className="text-[50px]">G</strong>AMEVERSE
                </button>

                <button onClick={() => navigate(-1)}
                    className="relative top-[68px] left-[890px]">
                        <ArrowBigLeft className="size-[60px] text-white"/>
                    </button>
            </div>
            <div className="m-10 overflow-auto shadow bg-white w-[1000px] - rounded-[50px]">
                
                <h1 className="text-5xl text-center font-semibold">{game.title}</h1>
                <h1 className="relative top-3 h-[3px] bg-black" />

                <div className="flex bg-slate-500 place-content-center h-[400px] m-[30px] rounded-[50px]">

                    <div className="mt-7 pl-3 "> <img src={game.imgUrl}/></div>

                    <div className="grid grid-rows-[40px] relative top-8 left-3">
                        <div className="text-2xl inline-flex">
                            <strong className="text-[25px]">Genre:</strong>
                            {game.genre}
                        </div>

                        <div className="text-2xl inline-flex">
                            <strong className="text-[25px]">Platforms:</strong>
                            {game.platforms}
                        </div>

                        <div className="flex relative -top-[24px]">
                            <img src="src\assets\star.png" 
                            style={{width:"40px", height: "40px"}}/>
                            <div className="text-[30px] font-semibold">{game.score}</div>
                        </div>

                        <div className="flex max-w-[600px] relative -top-[40px]">
                            <strong className="text-[25px]">Description:</strong>
                            <p className="m-2">{game.longDescription}</p>
                        </div>

                    </div>
                </div>

            </div>
        </div>
    )
}