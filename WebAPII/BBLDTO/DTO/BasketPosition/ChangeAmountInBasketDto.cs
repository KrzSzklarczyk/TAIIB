using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBLDTO.DTO.BasketPosition
{
    internal class ChangeAmountInBasketDto
    {
        public int ID { get; init; }
        public int ProductID { get; init; }
        public int UserID { get; init; }    
        public int Amount { get; init; }
    }
}
