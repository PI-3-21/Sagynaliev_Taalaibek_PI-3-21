using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EatAndDrink.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 6)")]
        public decimal Price { get; set; }

    }
}
