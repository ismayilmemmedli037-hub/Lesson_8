using Microsoft.EntityFrameworkCore;

var context = new AppDbContext();
var result = from student in context.Students
             join group1 in context.Groups
             on student.GroupId equals group1.Id
             join teacher in context.Teachers
             on group1.TeacherId equals teacher.Id
             select new
             {
                 StudentName = student.Name,
                 GroupName = group1.Name,
                 TeacherName = teacher.Name
             };
foreach (var item in result)
{
    Console.WriteLine( $"{item.StudentName} - {item.GroupName} - {item.TeacherName}" );
}