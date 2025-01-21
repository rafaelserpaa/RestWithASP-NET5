using RestWithASPNETErudio.Model;
using RestWithASPNETErudio.Model.Base;
using System.Collections.Generic;

namespace RestWithASPNETErudio.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T entity);
        T FindByID(long id);
        List<T> FindAll();
        T Update(T entity);
        void Delete(long id);
        bool Exists(long id);
    }
}

