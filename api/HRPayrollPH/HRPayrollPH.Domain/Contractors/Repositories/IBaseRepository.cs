using System.Linq.Expressions;

namespace HRPayrollPH.Domain.Contractors.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> All { get; }
        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> expression);
        bool IsExist(Expression<Func<TEntity, bool>> expression);
        void Create(TEntity entity);
        void Update(TEntity entity);
    }
}