using RestAPIModeloDDD.Domain.Core.Interfaces.Repository;
using RestAPIModeloDDD.Domain.Entities;

namespace RestAPIModeloDDD.Infrastructure.Data.Repository
{
    public class Infrastructure_Data_Repository_RepositoryCliente : Infrastructure_Data_Repository_RepositoryBase<Cliente>, Domain_Core_Interfaces_Repository_IRepositoryCliente
    {
        private readonly Infrastructure_Data_SqlServerContext sqlServerContext;

        public Infrastructure_Data_Repository_RepositoryCliente(Infrastructure_Data_SqlServerContext context) : base(context)
        {
            this.sqlServerContext = sqlServerContext ?? throw new ArgumentNullException(nameof(sqlServerContext));
        }
    }
}