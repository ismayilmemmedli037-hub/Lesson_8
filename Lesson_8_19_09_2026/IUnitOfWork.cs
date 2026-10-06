using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public interface IUnitOfWork
{
    IGenericRepository<Teacher> Teachers { get; }
    IGenericRepository<Group> Groups { get; }
    IGenericRepository<Student> Students { get; }
    void Save();
}