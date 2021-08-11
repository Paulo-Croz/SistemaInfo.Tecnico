
using System;
using SistemaInfo.Tecnico.Data.Context;
using SistemaInfo.Tecnico.Domain.Interface.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace SistemaInfo.Tecnico.Data.Repository
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly SqlContext sqlContext;

        public RepositoryBase(SqlContext sqlContext)
        {
            this.sqlContext = sqlContext;
        }

        public void Add(TEntity obj)
        {
            try
            {
                sqlContext.Set<TEntity>().Add(obj);
                sqlContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<TEntity> GetAll()
        {
            return sqlContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return sqlContext.Set<TEntity>().Find(id);
        }
    }
}
