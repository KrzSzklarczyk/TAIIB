using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBLDTO.DTO.Product
{
    internal class EditProductDto
    {
        public int Id { get; init; }
        public string? Name { get; init; }
        public double? Price { get; init; }
        public string? Image { get; init; }
        public bool? IsActive { get; init; }
    }
}
