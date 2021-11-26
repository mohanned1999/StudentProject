using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentProject.Model
{
    public class Cars
    {
        [Key]
        public int CarID { get; set; }
        public string CarName { get; set; }
        public string Modern  { get; set; }
        public string ImgUrl { get; set; }
        public string Color { get; set; }
        public Student Student { get; set; }

    }
}
