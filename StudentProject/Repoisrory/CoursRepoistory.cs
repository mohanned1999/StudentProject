using StudentProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentProject.Repoisrory
{
    public class CoursRepoistory:IStudent<Cours>
    {

        private readonly StudentDbContext context;

        public CoursRepoistory(StudentDbContext _context)
        {
            context = _context;
        }
        public void Add(Cours entity)
        {
            context.Cours.Add(entity);


        }

        public void Delete(int id)
        {
            var x = context.Cours.Find(id);
            context.Cours.Remove(x);


        }

        public Cours Find(int id)
        {
            return context.Cours.SingleOrDefault(x => x.CoursID == id);
        }

        public IList<Cours> GetAll()
        {
            return context.Cours.ToList();
        }

        public void update(Cours etity)
        {
            context.Update(etity);
        }
    }
}
