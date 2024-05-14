using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBLDTO.DTO.Order
{
    public class OrderResponseDto
    {
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public virtual IEnumerable<OrderPositionResponseDto>? OrderPositions { get; set; }
    }
}
