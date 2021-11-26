using Microsoft.EntityFrameworkCore;
using StudentProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentProject.Repoisrory
{
    public class StudentRepoistory : IStudent<Student>
    {
        private readonly StudentDbContext context;

        public StudentRepoistory(StudentDbContext _context)
        {
            context = _context;
        }
        public void Add(Student entity)
        {
            context.Student.Add(entity);
            context.SaveChanges();
            
        }

        public void Delete(int id)
        {
            var x= context.Student.Find(id);
            context.Student.Remove(x);
            context.SaveChanges();
             
            
        }

        public Student Find(int id)
        {
           return context.Student.SingleOrDefault(x => x.StudentID == id);
        }

        public IList<Student> GetAll()
        {
            return context.Student.ToList();

        }

        public void update(Student etity)
        {
            context.Update(etity);
            context.SaveChanges();
        }
    }
}
