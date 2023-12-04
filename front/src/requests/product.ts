import axios from "axios";

/** base url for products */
const BASE_URL = "http://localhost:5001/api/products";

// TODO ajouter authent
export const getAllProducts = async ()  => {
    try {
        const res = await axios.get(`${BASE_URL}`, {
            headers : {
                "Content-Type": "application/json",
            }
        })

        return res.data
    }catch(error) {
        console.error('Error fetching data:', error);
    }
}

