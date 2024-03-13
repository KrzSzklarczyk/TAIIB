using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Model
{
    public class BasketPosition : IEntityTypeConfiguration<BasketPosition>
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Product))]
        public Product? ProductId { get; set; }
        [ForeignKey(nameof(User))]
        public User? UserId { get; set; }
        public int Amount { get; set; }

        public void Configure(EntityTypeBuilder<BasketPosition> builder)
        {
            throw new NotImplementedException();
        }
    }
}
