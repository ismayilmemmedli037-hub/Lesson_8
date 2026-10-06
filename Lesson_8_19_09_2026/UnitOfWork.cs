using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public IGenericRepository<Teacher> Teachers { get; }
    public IGenericRepository<Group> Groups { get; }
    public IGenericRepository<Student> Students { get; }

    public UnitOfWork(AppDbContext context)
    {
        _context = context;

        Teachers = new GenericRepository<Teacher>(_context);
        Groups = new GenericRepository<Group>(_context);
        Students = new GenericRepository<Student>(_context);
    }

    public void Save()
    {
        _context.SaveChanges();
    }
}