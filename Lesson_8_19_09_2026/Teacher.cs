using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
public class Teacher
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Group> Groups { get; set; }
}