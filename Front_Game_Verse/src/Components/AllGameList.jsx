import { useNavigate } from "react-router-dom"

export default function AllGameList({data}){
    const navigate = useNavigate();

    function byList(listId, nameList){
        const query = new URLSearchParams();
        query.set("listId", listId);
        query.set("nameList", nameList)
        navigate(`/GameList?${query.toString()}`)
    }

    return(
    <div className="w-[600px] h-[300px]  text-4xl font-bold grid justify-center">
            {data.map(gameList =>
                <div key={gameList.id} className="relative top-[55px] left-[8px] justify-self-center">
                    <button 
                    onClick={() => byList(gameList.id, gameList.name)}
                    className="bg-orange-400 hover:bg-orange-500 text-stone-800 rounded-[50px] p-[25px] m-[10px]">
                        {gameList.name}
                    </button>
                </div>
            )}

    </div>)

}