import { useEffect, useState } from "react";
import { useParams } from "react-router"
import { getProductById } from "../requests/product";
import { Product } from "../models/product.model";
import Navbar from "../components/Navbar/Navbar";



const ProductPage = () => {
    const {id } = useParams()

    const [product, setProduct] = useState<Product | null>(null);
 

    const productId = parseInt(id!, 10)

    useEffect(() => {
        const fetchDataAndSetState = async () => {
            try {
                const res = await getProductById(productId)
                setProduct(res)
            } catch (error ) {
                console.log('Error fetching data:', error);
            }
        }
        fetchDataAndSetState();
    }, []);

    console.log(product)

    return (
        <>
            <Navbar></Navbar>
            <div>Hello</div>
        </>
    )

}

export default ProductPage