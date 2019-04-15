using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class ReciptRepository : RepositoryBase<Recipt>, IReciptRepository
    {
        public ReciptRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
        }

        public IEnumerable<Recipt> GetAllRecipts()
        {
            return FindAll()
                .OrderBy(r => r.Name);
        }

        public Recipt GetReciptById(int reciptId)
        {
            return FindByCondiftion(r => r.Id.Equals(reciptId))
                .FirstOrDefault();
        }

        public void CreateRecipt(Recipt recipt)
        {
            Create(recipt);
            Save();
        }
    }
}
