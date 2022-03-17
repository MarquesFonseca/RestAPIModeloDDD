using RestAPIModeloDDD.Domain.Core.Interfaces.Repository;
using RestAPIModeloDDD.Domain.Core.Interfaces.Services;
using RestAPIModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPIModeloDDD.Domain.Services
{
    public class Domain_Services_ServiceProduto : Domain_Services_ServiceBase<Produto>, Domain_Core_Interfaces_Services_IServiceProduto
    {
        private readonly Domain_Core_Interfaces_Repository_IRepositoryProduto repositoryProduto;
        public Domain_Services_ServiceProduto(Domain_Core_Interfaces_Repository_IRepositoryProduto repositoryProduto) : base(repositoryProduto)
        {
            this.repositoryProduto = repositoryProduto;
        }
    }
}
