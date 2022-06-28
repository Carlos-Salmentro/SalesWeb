using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SalesWebMVC.Models;

namespace SalesWebMVC.Controllers
{
    public class DepartamentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departament> departamentList = new List<Departament>();
            departamentList.Add(new Departament { ID = 1, Name = "Eletronicos" });
            departamentList.Add(new Departament { ID = 2, Name = "Fashion" });

            return View(departamentList);
        }
    }
}
