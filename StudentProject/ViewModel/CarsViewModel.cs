using Microsoft.AspNetCore.Http;
using StudentProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentProject.ViewModel
{
    public class CarsViewModel
    { 
       
        public string CarName { get; set; }
        public string Modern { get; set; }
        public string ImgUrl { get; set; }
        public string Color { get; set; }
        public int StudentID { get; set; }
        public List<Student> Students { get; set; }
       
    }
}
