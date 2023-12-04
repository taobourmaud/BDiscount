
import './Card.css'
import muguet from '../../assets/muguet.jpeg'
// interface ICardProps {
//     name: string,
//     price: number,
//     image: string,
// }

const Card = () => {

    return (
        <div className={"card-container"}>
            <div className={"img-container"}>
                <img className={"img-product"} src={muguet} alt={"image"}/>
            </div>
            <div>
                <h3 className={"product-name"}>
                    Muguet
                </h3>
            </div>
            <div>
                <h4 className={"product-desc"}>
                    Lorem Ipsum
                </h4>
            </div>
            <div>
                <h3 className={"product-price"}>
                    100€
                </h3>
            </div>
        </div>
    )
}

export default Card
