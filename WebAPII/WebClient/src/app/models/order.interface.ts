import { OrderPositionResponseDTO } from "./orderposition.interface";
import { UserResponseDTO } from "./user.interface";

export interface OrderResponseDTO {
    iD: number;
    date: string;
    user: UserResponseDTO;
    positions: OrderPositionResponseDTO[];
}