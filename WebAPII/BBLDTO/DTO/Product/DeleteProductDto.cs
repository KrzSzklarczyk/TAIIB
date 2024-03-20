using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBLDTO.DTO.Product
{
    internal class DeleteProductDto
    {
        public Guid? Id { get; set; }
        public string? Name { get; init; }
    }
}
