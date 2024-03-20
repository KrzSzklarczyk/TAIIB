using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order : IEntityTypeConfiguration<Order>
    {
        [Key]
        public int Id { get; set; }
        public int UserID { get; set; }
        [ForeignKey(nameof(UserID))]
        public User? User { get; set; }
        public virtual IEnumerable<OrderPosition>? OrderPositionsId { get; set; }
        [Required]
        public DateTime Date { get; set; }

        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasOne(x => x.User)
                .WithMany(x => x.OderId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
