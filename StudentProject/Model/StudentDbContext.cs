using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentProject.ViewModel;

namespace StudentProject.Model
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext>options):base(options)
        {
                  
        }
        public DbSet<Cars> Cars { get; set; }
        public DbSet<Cours> Cours { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<StudentCours> StudentCours { get; set; }
        public DbSet<StudentProject.ViewModel.CarsViewModel> CarsViewModel { get; set; }
       


    }
}
