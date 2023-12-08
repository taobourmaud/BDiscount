import axios from "axios";

const BASE_URL = "http://localhost:5002/api/basket"

export const addToBasket = async (userId: number, productId: number, quantity: number )  => {
    try {
        const res = await axios.post(`${BASE_URL}`, {
            userId,
            productId,
            quantity
        }, {
            headers : {
                "Content-Type": "application/json",
            }
        })

        return res.data
    }catch(error) {
        console.error('Error fetching data:', error);
    }
}