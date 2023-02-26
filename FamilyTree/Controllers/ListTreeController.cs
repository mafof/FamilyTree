using FamilyTree.Models;
using FamilyTree.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FamilyTree.Controllers
{
    public class ListTreeController : Controller
    {
        public IActionResult Index()
        {
/*            using (TreeService db = new TreeService()) 
            {
                Debug.WriteLine("Усепешно");

                var trees = db.Tree;
                foreach(var tree in trees) 
                {
                    Debug.WriteLine("{0} {1}", tree.Surname, tree.Name);
                }
            }*/
            return View();
        }
    }
}
