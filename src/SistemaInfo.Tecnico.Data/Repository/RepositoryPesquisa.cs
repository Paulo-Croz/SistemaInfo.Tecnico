using SistemaInfo.Tecnico.Data.Context;
using SistemaInfo.Tecnico.Domain.Entities;
using SistemaInfo.Tecnico.Domain.Interface.Repositories;

namespace SistemaInfo.Tecnico.Data.Repository
{
    public class RepositoryPesquisa : RepositoryBase<Pesquisa>, IRepositoryPesquisa
    {
        private readonly SqlContext sqlContext;

        public RepositoryPesquisa(SqlContext sqlContext)
            :base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
