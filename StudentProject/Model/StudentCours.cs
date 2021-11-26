using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentProject.Model
{
    public class StudentCours
    {  [Key]
        public int StudentCoursID { get; set; }
        public int CoursIDFK { get; set; }
        public int StudentIDFK { get; set; }
       [ForeignKey (nameof(StudentIDFK))]
        public Student Student { get; set; }
        [ForeignKey(nameof(CoursIDFK))]
        public Cours Cours { get; set; }

    }
}
