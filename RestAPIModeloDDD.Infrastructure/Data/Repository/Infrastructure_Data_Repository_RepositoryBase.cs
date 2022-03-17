using Microsoft.EntityFrameworkCore;
using RestAPIModeloDDD.Domain.Core.Interfaces.Repository;

namespace RestAPIModeloDDD.Infrastructure.Data.Repository
{
    public class Infrastructure_Data_Repository_RepositoryBase<TEntity> : Domain_Core_Interfaces_Repository_IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly Infrastructure_Data_SqlServerContext _context;

        public Infrastructure_Data_Repository_RepositoryBase(Infrastructure_Data_SqlServerContext context)
        {
            _context = context;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public void Add(TEntity entity)
        {
            try
            {
                _context.Set<TEntity>().Add(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(TEntity entity)
        {
            try
            {
                _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Remove(TEntity entity)
        {
            try
            {
                _context.Set<TEntity>().Remove(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}