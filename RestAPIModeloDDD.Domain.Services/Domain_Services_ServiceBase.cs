using RestAPIModeloDDD.Domain.Core.Interfaces.Repository;
using RestAPIModeloDDD.Domain.Core.Interfaces.Services;

namespace RestAPIModeloDDD.Domain.Services
{
    public class Domain_Services_ServiceBase<TEntity> : Domain_Core_Interfaces_Services_IServiceBase<TEntity> where TEntity : class
    {
        private readonly Domain_Core_Interfaces_Repository_IRepositoryBase<TEntity> repository;

        public Domain_Services_ServiceBase(Domain_Core_Interfaces_Repository_IRepositoryBase<TEntity> repository)
        {
            this.repository = repository;
        }

        public void Add(TEntity entity)
        {
            repository.Add(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return repository.GetById(id);
        }

        public void Remove(TEntity entity)
        {
            repository.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            repository.Update(entity);
        }
    }
}