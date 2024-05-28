import { BasketPositionResponseDTO } from "./basketposition.interface";
import { OrderResponseDTO } from "./order.interface";

export enum Type {
    Casual = 1,
    Admin = 2
}

export interface UserResponseDTO {
    id: number;
    login: string;
    password: string;
    type: Type;
    isActive: boolean;
    basketPositions: BasketPositionResponseDTO[];
    orders: OrderResponseDTO[];
}