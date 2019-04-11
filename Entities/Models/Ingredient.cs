using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("Ingredient")]
    public class Ingredient
    {
        [Key]
        public int IngrdientId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
