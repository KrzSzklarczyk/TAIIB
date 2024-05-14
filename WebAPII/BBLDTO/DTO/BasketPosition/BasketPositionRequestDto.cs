using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBLDTO.DTO.BasketPosition
{
    public class BasketPositionRequestDto
    {
        public required int ProductId { get; set; }
        public required int UserId { get; set; }
        public required int Amount { get; set; }
    }
}