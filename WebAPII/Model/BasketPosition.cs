using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Model
{
    public class BasketPosition : IEntityTypeConfiguration<BasketPosition>
    {
        [Key]
        public int ID { get; set; }
        public int ProductID { get; set; }
        [ForeignKey(nameof(ProductID))]
        public Product? Product { get; set; }
        public int UserID { get; set; }
        [ForeignKey(nameof(UserID))]
        public User? User { get; set; }
        public int Amount { get; set; }

        public void Configure(EntityTypeBuilder<BasketPosition> builder)
        {
            builder
                .HasOne(x => x.Product)
                .WithMany(x => x.BasketId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(x => x.User)
                .WithMany(x => x.BasketPositionsId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
