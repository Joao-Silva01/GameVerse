import Connection from "./Connection";


export default async function GetAllList() {
    const response = await Connection.get("gameList");

    return response.data;
}

export async function GetByList(listId) {
    const response = await Connection.get(`gameList/${listId}`)
    
    return response.data;
}