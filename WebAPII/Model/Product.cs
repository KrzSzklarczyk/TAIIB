using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public virtual IEnumerable<BasketPosition>? BasketId { get; set; }
        [MaxLength(30), Required]
        public string? Name { get; set; }
        public double Price { get; set; }
        [MaxLength(30), Required]
        public string? Image { get; set; }
        public bool IsActive { get; set; }
    }
}
