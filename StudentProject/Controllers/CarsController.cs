using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentProject.Model;
using StudentProject.Repoisrory;
using StudentProject.ViewModel;

namespace StudentProject.Controllers
{
    public class CarsController : Controller
    {
        private readonly IStudent<Cars> _cars;
        private readonly IStudent<Student> _student;

        // GET: Cars
        public CarsController(IStudent<Cars> cars, IStudent<Student> Student)
        {
            _cars = cars;
            _student = Student;
        }


        public ActionResult Index()
        {
            var car = _cars.GetAll();

            return View(car);
        }

        // GET: Cars/Details/5
        public ActionResult Details(int id)
        {
            var car = _cars.Find(id);

            return View(car);
        }

        // GET: Cars/Create
        public ActionResult Create()
        {
            var x = new CarsViewModel()
            {
                Students = _student.GetAll().ToList()
            };

          

            return View(x);
        }

        // POST: Cars/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(int id)
        {
            try
            {
               
                
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Cars/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cars/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Cars/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cars/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}