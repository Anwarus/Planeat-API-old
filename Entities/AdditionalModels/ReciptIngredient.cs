using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.AdditionalModels
{
    [Table("ReciptsIngredients")]
    public class ReciptIngredient
    {
        public int ReciptId { get; set; }
        public Recipt Recipt { get; set; }

        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
