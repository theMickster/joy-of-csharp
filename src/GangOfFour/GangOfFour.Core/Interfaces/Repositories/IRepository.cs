using System.Collections.Generic;
using GangOfFour.Core.Entities;

namespace GangOfFour.Core.Interfaces.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        T GetById(int id);

        IReadOnlyList<T> ListAll();

        int Count();
    }
}