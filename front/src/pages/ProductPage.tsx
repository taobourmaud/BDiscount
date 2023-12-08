import { useEffect, useState } from "react";
import { useParams } from "react-router"
import { getProductById } from "../requests/product";
import { Product } from "../models/product.model";
import "./styles/ProductPage.css"
import { addToBasket } from "../requests/basket";



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
            <div className="container-div">
                <div className={"container-product"}>
                    <div className={"container-img"}>
                        <img className="product-img" src={product?.image}></img>
                    </div>
                    <h3>
                        {product?.name}
                    </h3>
                    <h4>
                        {product?.description}
                    </h4>
                    <h4 className={"price"}>
                        Prix : {product?.price}€
                    </h4>

                    <div className={"container-button"}>
                        <button
                            onClick={() => addToBasket(1, productId, 10)}
                        >
                            Ajouter au panier
                        </button>
                    </div>
                </div>
            </div>
        </>
    )

}

export default ProductPage