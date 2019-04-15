using Entities.AdditionalModels;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("Ingredient")]
    public class Ingredient
    {
        [Key]
        [Column("IngredientId")]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<ReciptIngredient> ReciptIngredients { get; set; }
    }
}
