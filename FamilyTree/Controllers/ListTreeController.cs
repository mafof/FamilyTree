using FamilyTree.Migrations;
using FamilyTree.Models;
using FamilyTree.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Diagnostics;

namespace FamilyTree.Controllers
{
    public class ListTreeController : Controller
    {
        [HttpGet("[controller]/[action]/{id}")]
        public IActionResult Index(int id, string? surname, string? name, string? patronymic)
        {
            using(PeopleService db = new PeopleService())
            {

                List<GrandMotherGreatGrandsonModel> resultDB = db.GrandMotherGreatGrandson(id).ToList();

                List<List<GrandMotherGreatGrandsonModel>> result = new List<List<GrandMotherGreatGrandsonModel>>();

                int? idGrandmother = null;
                resultDB.ForEach(el =>
                {
                    if (idGrandmother == null || idGrandmother != el.IdGrandmother) 
                    {
                        idGrandmother = el.IdGrandmother;
                        result.Add(new List<GrandMotherGreatGrandsonModel>());

                    }
                    
                    result[result.Count - 1].Add(el);
                });

                ViewBag.FullName = $"{surname} {name} {patronymic}";
                ViewBag.Result = result;
            }
            return View();
        }
    }
}
