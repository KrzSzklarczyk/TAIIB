using BBLDTO.DTO;
using BBLDTO.DTO.Product;
namespace BBLDTO.interfaces.Product
{
    public interface IProductRepository
    {
        List<ProductResponseDto> GetProducts(Page pageProperties);
        ProductResponseDto GetProduct(int productId);
        void AddProduct(ProductResponseDto productRequest);
        void UpdateProduct(int productId, ProductResponseDto productRequest);
        void DeleteProduct(int productId);
        void ChangeProductStatus(int productId, bool activated);
    }
}
