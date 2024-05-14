using BBLDTO.DTO.BasketPosition;

namespace BBLDTO.interfaces.Basket
{
    interface IBasketRepository
    {
        List<BasketPositionResponseDto> GetBasketPositions(int UserId);
        void AddBasketPosition(BasketPositionRequestDto basketRequest);
        void DeleteBasketPosition(int basketId);
        void ChargeBasketPositionProductAmount(int basketId, int amount);
    }
}
