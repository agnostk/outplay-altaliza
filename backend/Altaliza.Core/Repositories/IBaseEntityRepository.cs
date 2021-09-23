using System.Collections.Generic;
using Altaliza.Core.Entities;

namespace Altaliza.Core.Repositories
{
    public interface IBaseEntityRepository<TBase> where TBase : BaseEntity
    {
        TBase GetOne(int id);
        IEnumerable<TBase> GetAll();
        void Create(TBase tBase);
        void Update(TBase tBase);
        void Delete(int id);
        int Commit();
    }
}