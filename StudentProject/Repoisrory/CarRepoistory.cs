using Microsoft.EntityFrameworkCore;
using StudentProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentProject.Repoisrory
{
    public class CarRepoistory : IStudent<Cars>
    {
        private readonly StudentDbContext _context;

        public CarRepoistory(StudentDbContext context )
        {
            _context = context;
        }
        public void Add(Cars entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var x = _context.Cars.Find(id);
            _context.Remove(x);
            _context.SaveChanges();

        }

        public Cars Find(int id)
        {
            return _context.Cars.SingleOrDefault(x => x.CarID == id);
        }

        public IList<Cars> GetAll()
        {
            return _context.Cars.Include(x => x.Student).ToList();
        }

        public void update(Cars etity)
        {
            _context.Update(etity);
            _context.SaveChanges();
        }
    }
}
