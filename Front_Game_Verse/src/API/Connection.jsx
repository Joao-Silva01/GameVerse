import axios from "axios";

const connection = axios.create({
        baseURL : "https://localhost:8081"
    })


export default  connection;