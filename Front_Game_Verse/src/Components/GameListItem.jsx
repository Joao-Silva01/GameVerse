import { Draggable } from "@hello-pangea/dnd";

export default function GameListItem({game, position, getGame}){
    return(
        <Draggable key={game.id} draggableId={game.id.toString()} index={position}>
            {(provided) => (
                <div
                className="grid w-full h-48 mb-5 pr-2 bg-slate-300 hover:bg-slate-400 rounded-md overflow-auto"
                {...provided.dragHandleProps}
                {...provided.draggableProps}
                ref={provided.innerRef}
                onClick={() => getGame(game.id)}>
                            
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
            )}
        </Draggable>
    )
}