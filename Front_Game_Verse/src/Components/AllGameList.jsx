export default function AllGameList({data}){


    return(
    <div className="w-[600px] h-[300px]  text-4xl font-bold grid justify-center">
            {data.map(gameList =>
                <div key={gameList.id} className="relative top-[55px] left-[8px] justify-self-center">
                    <button className="bg-orange-400 hover:bg-orange-500 text-stone-700 rounded-[50px] p-[25px] m-[10px]">
                        {gameList.name}
                    </button>
                </div>
            )}

    </div>)

}