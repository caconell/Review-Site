using ReviewsSite.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Repositories
{
    public interface IRepository<T> : ISelectList

    {
        IEnumerable<T> GetAll();
        T GetByID(int id);

        void Create(T obj);

        void Update(T obj);

        void Delete(T obj);
    }
}
