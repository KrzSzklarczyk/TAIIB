using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(User)), Required]
        public User? UserID { get; set; }
        public virtual IEnumerable<OrderPosition>? OrderPositionsId { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}
