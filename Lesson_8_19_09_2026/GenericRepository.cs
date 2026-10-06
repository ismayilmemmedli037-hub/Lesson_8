using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly AppDbContext conn;
    public GenericRepository(AppDbContext context)
    {
        conn = context;
    }
    public List<T> GetAll()
    {
        return conn.Set<T>().ToList();
    }
    public T GetById(int id)
    {
        return conn.Set<T>().Find(id);
    }
    public void Add(T entity)
    {
        conn.Set<T>().Add(entity);
    }
    public void Update(T entity)
    {
        conn.Set<T>().Update(entity);
    }
    public void Delete(T entity)
    {
        conn.Set<T>().Remove(entity);
    }
}