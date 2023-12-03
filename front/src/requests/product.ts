import axios from "axios";

/** base url for products */
const BASE_URL = "http://localhost:5001/api/products";

// TODO ajouter authent
export const getAllProducts = async () => {
    try {
        const response = await axios.get(`${BASE_URL}`, {
            headers : {
                "Content-Type": "application/json",
                //"Access-Control-Allow-Headers" : "Content-Type, Authorization"
            }
        })

        return response.data

    } catch (e) {
        console.log(e)
    }
}

