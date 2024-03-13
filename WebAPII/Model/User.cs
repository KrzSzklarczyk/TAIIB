using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public virtual IEnumerable<Order>? OderId { get; set; }
        public virtual IEnumerable<BasketPosition>? BasketPositionsId { get; set; }
        [MaxLength(30), Required]   
        public string? Login { get; set; }
        [MaxLength(30), Required]
        public string? Password { get; set; }
        public Type? Type { get; set; }
        public bool IsActive { get; set; }

    }
}
