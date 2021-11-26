using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentProject.Model
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int NumSet { get; set; }
        public int Level { get; set; }
        public int Age { get; set; }
        public ICollection<Cars> Cars { get; set; }
        public ICollection<StudentCours> CoursRE { get; set; }
    }
}
