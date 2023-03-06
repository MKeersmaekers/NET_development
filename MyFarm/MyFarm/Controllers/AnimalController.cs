using Microsoft.AspNetCore.Mvc;
using MyFarm.Data;
using MyFarm.Models;
using MyFarm.Models.ViewModels;

namespace MyFarm.Controllers
{
    public class AnimalController : Controller
    {
        private readonly AnimalDbContext _context;
        public AnimalController(AnimalDbContext context)
        {
            _context= context;
        }
        public IActionResult Index(string q)
        {
            List<Animal> animals;

            if(string.IsNullOrEmpty(q))
            {
                animals = _context.Animals.ToList();
            } else
            {
                animals = _context.Animals.Where(
                    a => a.Name.ToLower().Contains(q.ToLower())
                    ).ToList();
            }

            AnimalSearchViewModel vm = new AnimalSearchViewModel();
            vm.Animals = animals;
            vm.q= q;

            return View(vm);
        }
    }
}
