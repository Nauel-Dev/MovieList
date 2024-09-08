using Microsoft.AspNetCore.Mvc;
using Moive_finder.Data_Layer;
using Moive_finder.Models;
using System.ComponentModel;

namespace Moive_finder.Controllers
{
    public class MovieController : Controller
    {
        private readonly ApplicationDbContext _db;
        public MovieController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            List<Movie> objMovieList= _db.Movies.ToList();
            return View(objMovieList);
        }
        public IActionResult Add()
        {
        
            return View();
        
        }

        [HttpPost]
        public IActionResult Add(Movie obj)
        {
            if(obj.Name==obj.DisplayOrder.ToString()) {
                ModelState.AddModelError("name", "The display order should not match the name");
            
            }
            if (ModelState.IsValid)
            {
                _db.Movies.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
            
            
        }
        public IActionResult Edit(int? id)
        {
if(id==null || id ==0)
            {
                return NotFound();
            }
           
            Movie movieFromDb = _db.Movies.Find(id);
            if(movieFromDb==null)
            {

            }

            return View();

        }

        [HttpPost]
        public IActionResult Edit(Movie obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The display order should not match the name");

            }
            if (ModelState.IsValid)
            {
                _db.Movies.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();


        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            if (id != 123)
            {
                ModelState.AddModelError("DisplayOrder", "enter the right number");
              

            }

            Movie movieFromDb = _db.Movies.Find(id);
            if (movieFromDb == null)
            {

            }

            return View();

        }

        [HttpPost,ActionName("Delete")]
        public IActionResult DeletePOST(Movie obj)
        {
        
           

            _db.Movies.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            

            return View();


        }
    }
}
