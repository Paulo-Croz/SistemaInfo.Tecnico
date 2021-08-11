using System;
using System.Collections.Generic;
using System.Text;
using SistemaInfo.Tecnico.Domain.Entities;
using SistemaInfo.Tecnico.Domain.Interface.Repositories;
using SistemaInfo.Tecnico.Domain.Interface.Services;

namespace SistemaInfo.Tecnico.Domain.Interface
{
    public class ServicePesquisa : ServiceBase<Pesquisa>, IServicePesquisa
    {
        private readonly IRepositoryPesquisa repositoryPesquisa;

        public ServicePesquisa(IRepositoryPesquisa repositoryPesquisa)
            : base(repositoryPesquisa)
        {
            this.repositoryPesquisa = repositoryPesquisa;
        }
    }
}
