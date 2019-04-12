using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ExtendedModels
{
    public class ReciptExtended
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Ingredient> Ingredients { get; set; }

        public ReciptExtended()
        {
        }

        public ReciptExtended(Recipt recipt)
        {
            Id = recipt.Id;
            Name = recipt.Name;
        }
    }
}
