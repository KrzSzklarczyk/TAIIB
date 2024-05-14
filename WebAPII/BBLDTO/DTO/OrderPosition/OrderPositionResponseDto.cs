using BBLDTO.DTO.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBLDTO.DTO.Order
{
    public class OrderPositionResponseDto
    {
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public ProductResponseDto? Product { get; set; }
    }
}
