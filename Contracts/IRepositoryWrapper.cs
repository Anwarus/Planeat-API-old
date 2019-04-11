using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IRepositoryWrapper
    {
        IReciptRepository Recipt { get; set; }
        IIngredientRepository Ingredient { get; set; }
    }
}
