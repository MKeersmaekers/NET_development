using System.Linq;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;
using MvcMovie.DAL;
using Microsoft.EntityFrameworkCore;

namespace MvcMovie.Controllers
{
    public class RatingsController : Controller
    {
        private IRepository<Rating> ratingRepository;
        public RatingsController(MovieContext context)
        {
            ratingRepository = new RatingRepository(context);
        }

        // GET: Ratings/List
        public IActionResult List()
        {
            var ratings = ratingRepository.GetAll().OrderBy(r => r.Name);

            return View(ratings.ToList());
        }

        // GET: Ratings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ratings/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("RatingID,Code,Name")] Rating rating)
        {
            if (ModelState.IsValid)
            {
                ratingRepository.Insert(rating);
                ratingRepository.Save();
                return RedirectToAction("List");
            }
            return View(rating);
        }

        // GET: Ratings/Edit/5
        public IActionResult Edit(int id)
        {
            var rating = ratingRepository.GetAll().SingleOrDefault(r => r.RatingID == id);

            return View(rating);
        }

        // POST: Ratings/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("RatingID,Code,Name")] Rating rating)
        {
			if (ModelState.IsValid)
            {
                try
                {
                    ratingRepository.Update(rating);
                    ratingRepository.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                return RedirectToAction("List");
            }
            return View(rating);
        }

        // GET: Ratings/Delete/5
        public IActionResult Delete(int id)
        {
            var rating = ratingRepository.GetAll().SingleOrDefault(r => r.RatingID == id);
            ratingRepository.Delete(rating!);
            ratingRepository.Save();
            return RedirectToAction("List");
        }

    }
}
