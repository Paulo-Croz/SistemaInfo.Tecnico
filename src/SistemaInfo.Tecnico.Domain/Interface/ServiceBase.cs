using SistemaInfo.Tecnico.Domain.Interface.Services;
using System.Collections.Generic;
using SistemaInfo.Tecnico.Domain.Interface.Repositories;

namespace SistemaInfo.Tecnico.Domain.Interface
{
    public class ServiceBase<TEntiy> : IServiceBase<TEntiy> where TEntiy : class
    {
        private readonly IRepositoryBase<TEntiy> repository;

        public ServiceBase(IRepositoryBase<TEntiy> repository)
        {
            this.repository = repository;
        }
        public void Add(TEntiy obj)
        {
            repository.Add(obj);
        }

        public List<TEntiy> GetAll()
        {
            return repository.GetAll();
        }

        public TEntiy GetById(int id)
        {
            return repository.GetById(id);
        }
    }
}
