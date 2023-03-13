using Microsoft.AspNetCore.Mvc;
using MusicStore.Data;

namespace MusicStore.Controllers
{
    public class StoreController : Controller
    {
        private readonly StoreContext _context;

        public StoreController(StoreContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListGenres()
        {
            var genres = _context.Genres.OrderBy(m => m.Name).ToList();

            return View(genres);
        }
    }
}
