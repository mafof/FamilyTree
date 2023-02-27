using FamilyTree.Migrations;
using FamilyTree.Models;
using FamilyTree.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;

namespace FamilyTree.Controllers
{
    public class ListTreeController : Controller
    { 

        public IActionResult Index(int? id)
        {
            using(PeopleService db = new PeopleService())
            {
                var s = db.GrandMotherGreatGrandson(14);
                Debug.WriteLine(s);

            }

            return View();
        }
    }
}
