using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EatAndDrink.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 6)")]
        public decimal TotalPrice { get; set; }
    }
}
