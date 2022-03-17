using RestAPIModeloDDD.Domain.Core.Interfaces.Repository;
using RestAPIModeloDDD.Domain.Entities;

namespace RestAPIModeloDDD.Infrastructure.Data.Repository
{
    public class Infrastructure_Data_Repository_RepositoryProduto : Infrastructure_Data_Repository_RepositoryBase<Produto>, Domain_Core_Interfaces_Repository_IRepositoryProduto
    {
        private readonly Infrastructure_Data_SqlServerContext sqlServerContext;

        public Infrastructure_Data_Repository_RepositoryProduto(Infrastructure_Data_SqlServerContext context) : base(context)
        {
            this.sqlServerContext = sqlServerContext ?? throw new ArgumentNullException(nameof(sqlServerContext));
        }
    }
}