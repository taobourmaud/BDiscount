import './Navbar.css'

const Navbar = () => {
    return (
        <div
         className={"navbar"}
        >
            <img className={"img"} src={"/cdiscount.svg"} alt={"logo"}/>
            <div
                className={"icons"}
            >


                <img className={"cart"} src={"../public/cart.svg"}/>
                <img className={"account"} src={"../public/account.svg"}/>
            </div>
        </div>
    )
}

export default Navbar