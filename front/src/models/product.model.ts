import Base from "./_base.model.ts";


export class Product extends Base{

    id : number

    name: string

    description:string

    category: string

    image: string

    price: number

    quantity: number

    constructor({
        id= 0,
        name= '',
        category= '',
        description = '',
        image= '',
        price= 0,
        quantity= 0,
        ...data
                }) {
        super(data)
        this.id = id
        this.description = description
        this.name = name
        this.category = category
        this.image = image
        this.price = price
        this.quantity = quantity

    }

}