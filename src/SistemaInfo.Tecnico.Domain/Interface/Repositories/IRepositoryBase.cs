

using System.Collections.Generic;

namespace SistemaInfo.Tecnico.Domain.Interface.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        List<TEntity> GetAll();
        TEntity GetById(int id);

    }
}
