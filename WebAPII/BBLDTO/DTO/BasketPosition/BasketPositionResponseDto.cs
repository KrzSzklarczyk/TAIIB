using BBLDTO.DTO.Product;

namespace BBLDTO.DTO.BasketPosition
{
    public class BasketPositionResponseDto
    {
        public int BasketPositionId { get; set; }
        public int Amount { get; set; }
        public required ProductResponseDto Product { get; set; }
    }
}
