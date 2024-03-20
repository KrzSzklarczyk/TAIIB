using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBLDTO.DTO.Product
{
    internal class AddProductDto
    {
        public int Id { get; init; }
        public required string Name { get; init; }
        public required double Price { get; init; }
        public required string Image { get; init; }
        public required bool IsActive { get; init; }
    }
}
