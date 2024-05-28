import { BasketPositionResponseDTO } from "./basketposition.interface";
import { OrderPositionResponseDTO } from "./orderposition.interface";

export interface ProductResponseDTO {
    id: number;
    name: string;
    price: number;
    image: string;
    isActive: boolean;
    basketPositions: BasketPositionResponseDTO[];
    orderPositions: OrderPositionResponseDTO[];
}

export interface ProductRequestDTO {
    name: string;
    price: number;
    image: string;
    isActive: boolean;
    basketPositions: BasketPositionResponseDTO[];
    orderPositions: OrderPositionResponseDTO[];
}