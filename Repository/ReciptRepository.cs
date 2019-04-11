using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class ReciptRepository : RepositoryBase<Recipt>, IReciptRepository
    {
        public ReciptRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
        }
    }
}
