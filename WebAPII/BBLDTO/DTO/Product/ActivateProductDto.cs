using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBLDTO.DTO.Product
{
    internal class ActivateProductDto
    {
        public int Id { get; init; }
        public bool IsActive { get; init; }
        public string? Name { get; init; }
    }
}
