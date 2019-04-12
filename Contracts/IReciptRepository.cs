using Entities.ExtendedModels;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IReciptRepository : IRepositoryBase<Recipt>
    {
        IEnumerable<Recipt> GetAllRecipts();
        Recipt GetReciptById(int reciptId);
        ReciptExtended GetReciptWithDetails(int reciptId);
    }
}
