import React from 'react'
import ReactDOM from 'react-dom/client'
import Home from './Home.tsx'
import './index.css'
import { RouterProvider, createBrowserRouter } from 'react-router-dom'
import ProductPage from './pages/ProductPage.tsx'
import Navbar from './components/Navbar/Navbar.tsx'

const router = createBrowserRouter([
  {
    path: '/',
    element: <Home/>
  },
  {
    path: '/cart',
    element: <div>Panier</div>
  },
  {
    path: '/product/:id',
    element:  <ProductPage/>
  }
])

ReactDOM.createRoot(document.getElementById('root')!).render(
  <React.StrictMode>
    <Navbar></Navbar>
    <RouterProvider router={router} />
  </React.StrictMode>,
)
