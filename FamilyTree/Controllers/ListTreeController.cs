using Microsoft.AspNetCore.Mvc;

namespace FamilyTree.Controllers
{
    public class ListTreeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
