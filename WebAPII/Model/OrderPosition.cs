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
    public class OrderPosition : IEntityTypeConfiguration<OrderPosition>
    {
        [Key]
        public int Id { get; set; }
        public int OrderID { get; set; }
        [ForeignKey(nameof(OrderID))]
        public Order? Order { get; set; }
        public int ProductId{ get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }
        public int Amount { get; set; }
        public double Float { get; set; }

        public void Configure(EntityTypeBuilder<OrderPosition> builder)
        {
            builder
                .HasOne(x => x.Order)
                .WithMany(x => x.OrderPositionsId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(x => x.Product)
                .WithMany(x => x.OrderId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
