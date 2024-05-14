using BBLDTO.DTO;
using BBLDTO.DTO.Product;
using BBLDTO.interfaces.Product;
using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productService;

        public ProductController(IProductRepository productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetProducts([FromQuery] Page pageProperties)
        {
            var products = _productService.GetProducts(pageProperties);
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var product = _productService.GetProduct(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public IActionResult AddProduct([FromBody] ProductResponseDto productRequest)
        {
            _productService.AddProduct(productRequest);
            return CreatedAtAction(nameof(GetProduct), new { id = productRequest.ID }, productRequest);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] ProductResponseDto productRequest)
        {
            if (id != productRequest.ID)
            {
                return BadRequest();
            }

            var existingProduct = _productService.GetProduct(id);
            if (existingProduct == null)
            {
                return NotFound();
            }

            _productService.UpdateProduct(id, productRequest);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var existingProduct = _productService.GetProduct(id);
            if (existingProduct == null)
            {
                return NotFound();
            }

            _productService.DeleteProduct(id);
            return NoContent();
        }

        [HttpPost("{id}/status")]
        public IActionResult ChangeProductStatus(int id, [FromBody] bool activated)
        {
            var existingProduct = _productService.GetProduct(id);
            if (existingProduct == null)
            {
                return NotFound();
            }

            _productService.ChangeProductStatus(id, activated);
            return NoContent();
        }
    }
}
