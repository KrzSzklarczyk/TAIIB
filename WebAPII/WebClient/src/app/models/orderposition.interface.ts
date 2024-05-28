import { OrderResponseDTO } from "./order.interface";
import { ProductResponseDTO } from "./product.interface";

export interface OrderPositionResponseDTO {
    iD: number;
    amount: number;
    price: number;
    order: OrderResponseDTO;
    product: ProductResponseDTO;
}