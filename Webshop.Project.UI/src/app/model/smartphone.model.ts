export interface Smartphone {
    name: string,
    description: string,
    price: number,
    image: string,
    stock: number,
    memoryCapacity: number,
    colour: string,
    screenSize: number,
    brandID: number,
    categoryID: number
}

export interface Brand {
    name: string,
}

export interface Category {
    name: string,
}