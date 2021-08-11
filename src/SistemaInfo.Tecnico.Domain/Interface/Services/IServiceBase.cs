using System.Collections.Generic;

namespace SistemaInfo.Tecnico.Domain.Interface.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        List<TEntity> GetAll();
        TEntity GetById(int id);

        }
}
