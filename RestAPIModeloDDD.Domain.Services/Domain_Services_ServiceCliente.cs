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
    public class Domain_Services_ServiceCliente : Domain_Services_ServiceBase<Cliente>, Domain_Core_Interfaces_Services_IServiceCliente
    {
        private readonly Domain_Core_Interfaces_Repository_IRepositoryCliente repositoryCliente;
        public Domain_Services_ServiceCliente(Domain_Core_Interfaces_Repository_IRepositoryCliente repositoryCliente) : base(repositoryCliente)
        {
            this.repositoryCliente = repositoryCliente;
        }
    }
}
