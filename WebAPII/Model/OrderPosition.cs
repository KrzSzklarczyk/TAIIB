using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OrderPosition
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Order))]
        public Order? OrderId { get; set; }
        public int Amount { get; set; }
        public double Float { get; set; }

    }
}
