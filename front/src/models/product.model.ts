import Base from "./_base.model.ts";


export class Product extends Base{

    productId? : number

    name?: string

    category?: string

    image?: string

    price?: number

    quantity?: number

    constructor({
        productId= 0,
        name= '',
        category= '',
        image= '',
        price= 0,
        quantity= 0,
        ...data
                }) {
        super(data)
        this.productId = productId
        this.name = name
        this.category = category
        this.image = image
        this.price = price
        this.quantity = quantity

    }

}