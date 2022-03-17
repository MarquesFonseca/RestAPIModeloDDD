namespace RestAPIModeloDDD.Domain.Core.Interfaces.Repository
{
    public interface Domain_Core_Interfaces_Repository_IRepositoryBase<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Remove(TEntity entity);
    }
}