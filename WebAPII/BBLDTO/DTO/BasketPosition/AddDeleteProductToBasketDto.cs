using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBLDTO.DTO.BasketPosition
{
    internal class AddDeleteProductToBasketDto
    {
        public required int ID { get; init; }
        public required int ProductID { get; init; }
        public int? UserID { get; init; }
        public required int Amount { get; init; }
    }
}
