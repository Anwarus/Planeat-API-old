using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class IngredientRepository : RepositoryBase<Ingredient>, IIngredientRepository
    {
        public IngredientRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
        }
    }
}
