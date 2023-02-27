using FamilyTree.Models;
using FamilyTree.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FamilyTree.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Search(PeopleModel model)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(SearchModel model)
        {
            if (ModelState.IsValid)
            {
                using(PeopleService db = new PeopleService()) 
                {
                    var result = db.People
                        .Where(p => p.Surname == model.Surname && p.Name == model.Name && p.Patronymic == model.Patronymic || p.Surname == model.Surname && p.Name == model.Name)
                        .ToList();

                    if (result.Count == 1) {
                        return RedirectToAction("Index", "ListTree", new { @id = result[0].Id });
                    } 
                    else
                    {
                        return View("Search", result);
                    }
                }
            }

            return View("Search");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}