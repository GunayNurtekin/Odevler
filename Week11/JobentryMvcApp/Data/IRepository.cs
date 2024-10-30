using System;

namespace JobentryMvcApp.Data;

public interface IRepository <T> where T : class
{
    Task <IEnumerable<T>> GetAllAsync ();

    Task <T?> GetAsync ( int id ); 

    Task <int> AddAsync (T entity);

    Task <int> UpdateAsync (T entity);

    Task <int> DeleteAsync (int id) ; 
}
