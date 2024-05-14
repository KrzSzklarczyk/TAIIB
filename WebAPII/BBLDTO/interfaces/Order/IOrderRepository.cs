using BBLDTO.DTO.Order;

namespace BBLDTO.interfaces.Order
{
    public interface IOrderRepository
    {
        void CreateOrder(int UsertId);
        List<OrderResponseDto> GetAllOrders();
        List<OrderResponseDto> GetUserOrders(int UserId);
        List<OrderPositionResponseDto> GetOrderPositions(int OrderId);
    }
}
