using System;
using System.Collections.Generic;
using System.Text;

namespace Gestimonio.Repository
{
    public interface IRepository<T> where T: class
    {
        // Metodos CRUD
        int Add(T entity);

        // Lista más liviana
        IEnumerable<T> GetList();
        bool Update(T entity);
        bool Delete(T entity);
        T GetById(int id);

    }
}
