using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentProject.Model
{
    public class Cours
    {
        public int CoursID { get; set; }
        public int CoursName { get; set; }
        public ICollection<StudentCours> StudentsER { get; set; }
    }
}
