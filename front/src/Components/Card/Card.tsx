
import './Card.css'
interface ICardProps {
    name: string,
    price: number,
    description: string,
    image: string,
}

const Card = ({name, description, price, image} : ICardProps) => {

    return (
        <div className={"card-container"}>
            <div className={"img-container"}>
                <img className={"img-product"} src={image} alt={"image"}/>
            </div>
            <div>
                <h3 className={"product-name"}>
                    {name}
                </h3>
            </div>
            <div>
                <h4 className={"product-desc"}>
                    {description}
                </h4>
            </div>
            <div>
                <h3 className={"product-price"}>
                    {price}€
                </h3>
            </div>
        </div>
    )
}

export default Card
