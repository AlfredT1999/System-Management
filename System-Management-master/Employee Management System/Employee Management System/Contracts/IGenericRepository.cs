using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Employee_Management_System.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        // Create:
        Task Create(T entity);

        // Read:
        Task<IList<T>> FindAll(
            Expression<Func<T, bool>> expression = null,// This works like q => q.Id == 20
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,// This works like q => q.OrederBy(q == q.Id)
            Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null// This works like a Join query.
            );

        // Add another declaration that find if the id passed exists.
        Task<bool> isExists(Expression<Func<T, bool>> expression = null);

        Task<T> Find(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null);

        // Update:
        void Update(T entity);

        // Delete:
        void Delete(T entity);
    }
}
