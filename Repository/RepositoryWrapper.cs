using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repositoryContext;
        private IReciptRepository _recipt;
        private IIngredientRepository _ingredient;

        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public IReciptRepository Recipt
        {
            get
            {
                if(_recipt == null)
                {
                    _recipt = new ReciptRepository(_repositoryContext);
                }

                return _recipt;
            }
        }

        public IIngredientRepository Ingredient
        {
            get
            {
                if (_ingredient == null)
                {
                    _ingredient = new IngredientRepository(_repositoryContext);
                }

                return _ingredient;
            }
        }
    }
}
