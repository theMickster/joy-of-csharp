using System.Collections.Generic;
using GangOfFour.Core.Entities;
using GangOfFour.Core.Interfaces.Repositories;

namespace GangOfFour.Application.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : BaseEntity
    {
        public abstract T GetById(int id);

        public abstract IReadOnlyList<T> ListAll();

        public abstract int Count();
    }
}