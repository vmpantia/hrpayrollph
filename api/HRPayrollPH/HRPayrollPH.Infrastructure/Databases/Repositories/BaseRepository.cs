using HRPayrollPH.Domain.Contractors.Repositories;
using HRPayrollPH.Infrastructure.Databases.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HRPayrollPH.Infrastructure.Databases.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly HRPayrollPHDbContext _context;
        protected readonly DbSet<TEntity> _table;
        public BaseRepository(HRPayrollPHDbContext context)
        {
            _context = context;
            _table = context.Set<TEntity>();
        }

        public IQueryable<TEntity> All => _table;

        public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> expression) => _table.Where(expression);

        public bool IsExist(Expression<Func<TEntity, bool>> expression) => _table.Any(expression);

        public void Create(TEntity entity) => _table.Add(entity);

        public void Update(TEntity entity) => _table.Update(entity);
    }
}
