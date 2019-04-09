using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    class ReciptIngredient
    {
        public int ReciptId { get; set; }
        public Recipt Recipt { get; set; }

        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
