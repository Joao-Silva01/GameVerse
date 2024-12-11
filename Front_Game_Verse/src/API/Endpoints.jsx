import Connection from "./Connection";



// EndPoints GameList
export default async function fetchAllList() {
    const response = await Connection.get("gameList");

    return response.data;
}

export async function fetchByList(listId) {
    const response = await Connection.get(`gameList/${listId}`)
    
    return response.data;
}


export async function UpdatePosition(listId, inital, destination) {
    const body = {
        Source : inital,
        Destination : destination
    }

    return await Connection.post(`/gameList/${listId}`, body);
}

// EndPoints GameList
export async function fetchGameById(gameId) {
    const response = await Connection.get(`/game/${gameId}`)

    return response.data;
}