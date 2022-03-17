namespace RestAPIModeloDDD.Domain.Core.Interfaces.Services
{
    public interface Domain_Core_Interfaces_Services_IServiceBase<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Remove(TEntity entity);
    }
}