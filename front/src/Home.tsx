import './App.css'
import Navbar from "./components/Navbar/Navbar.tsx";
import {getAllProducts} from "./requests/product.ts";
import React, {useEffect, useState} from "react";
import {Product} from "./models/product.model.ts";
import Card from "./components/Card/Card.tsx";
import noImage from '../src/assets/no_image.png'
import { Link } from 'react-router-dom';
//import iphone from '../src/assets/iphone.jpg'

const Home  = () => {

    const [products, setProducts] = useState<Array<Product> | null>(null);
    const [productId, setProductId] = useState<number | null>(null);
    //const [error, setError] = useState<string | null>(null);

    useEffect(() => {

        const fetchDataAndSetState = async () => {
            try {
                const res = await getAllProducts()
                setProducts(res)
            } catch (error ) {
                console.log('Error fetching data:', error);
            }
        }
        fetchDataAndSetState();
    }, []);

    // // const getProductId = (productId: number) : number => {
    // //     return productId
    // // }

    // console.log(productId)

    return (
        <>
            <Navbar></Navbar>
            <div
                className={"container"}
            >
                {products && products.map((product) => 
                    <>
                        <a href={'product/' + productId} onClick={() => setProductId(product.id)}>
                            <Card 
                                key={product.id} 
                                name={product.name}
                                description={product.description}
                                image={product.image ? product.image : noImage}  
                                price={product.price}
                            />
                        </a>
                    </>
                )}
            </div>
        </>

    )
}

export default Home
