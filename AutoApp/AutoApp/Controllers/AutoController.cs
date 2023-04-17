using AutoApp.Data;
using AutoApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoApp.Controllers
{
    public class AutoController : Controller
    {
        private readonly IRepository<Auto> _autoRepository;
        public AutoController(AutoDbContext dbContext)
        {
            _autoRepository = new AutoRepository(dbContext);
        }
        // GET: AutoController
        public ActionResult Index()
        {
            var autos = _autoRepository.GetAll();
            return View(autos);
        }

        // GET: AutoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AutoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AutoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AutoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AutoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AutoController/Delete/5
        public ActionResult Delete(int id)
        {
            _autoRepository.Delete(id);
            return RedirectToAction("Index");
        }

        // POST: AutoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
