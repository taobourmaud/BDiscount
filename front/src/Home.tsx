
import './App.css'
import Navbar from "./Components/Navbar/Navbar.tsx";
import {getAllProducts} from "./requests/product.ts";

function Home() {

     const getData = getAllProducts()

     console.log(getData)

  return (
    <>
        <Navbar></Navbar>
    </>
  )
}

export default Home
