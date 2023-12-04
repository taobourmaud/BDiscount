import './App.css'
import Navbar from "./Components/Navbar/Navbar.tsx";
import {getAllProducts} from "./requests/product.ts";
import React, {useEffect, useState} from "react";
import {Product} from "./models/product.model.ts";
import Card from "./Components/Card/Card.tsx";

const Home: React.FC = () => {
    // eslint-disable-next-line @typescript-eslint/no-unused-vars
    const [products, setProducts] = useState<Array<Product> | null>(null);
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

    return (
        <>
            <Navbar></Navbar>

                <Card></Card>
                <Card></Card>



            {/*{products?.map((product) => {*/}
            {/*    <h1>*/}
            {/*        {product.name}*/}
            {/*    </h1>*/}
            {/*    console.log(product.name)*/}
            {/*})}*/}
        </>

    )
}

export default Home
