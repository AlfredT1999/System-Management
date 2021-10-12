using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management_System.Contracts
{
    /* This is the repository base interface which allow whichever class, with the use of template T. 
       At the same time this interface contains the CRUD operations for the database info. */
    public interface IRepositoryBase<T> where T : class
    {
        // Create:
        bool Create(T entity);

        // Read:
        ICollection<T> FindAll();
        T FindById(int id);

        // Update:
        bool Update(T entity);

        // Delete:
        bool Delete(T entity);

        // Save:
        bool Save();
    }
}
