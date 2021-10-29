using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Employee_Management_System.Contracts
{
    /* This is the repository base interface which allow whichever class, with the use of template T. 
       At the same time this interface contains the CRUD operations for the database info. */
    public interface IRepositoryBase<T> where T : class
    {
        // Create:
        Task<bool> Create(T entity);

        // Read:
        Task<ICollection<T>> FindAll();

        // Add another declaration that find if the id passed exists.
        Task<bool> isExists(int id);

        Task<T> FindById(int id);

        // Update:
        Task<bool> Update(T entity);

        // Delete:
        Task<bool> Delete(T entity);

        // Save:
        Task<bool> Save();
    }

   
}
