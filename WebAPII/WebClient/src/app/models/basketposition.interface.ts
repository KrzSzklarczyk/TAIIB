import { ProductResponseDTO } from "./product.interface";
import { UserResponseDTO } from "./user.interface";

export interface BasketPositionResponseDTO {
    id: number;
    product: ProductResponseDTO;
    user: UserResponseDTO;
    amount: number;
}