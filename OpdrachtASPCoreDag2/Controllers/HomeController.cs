using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OpdrachtASPCoreDag2.Models;

namespace OpdrachtASPCoreDag2.Controllers
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
//            ProbeerselASPDBEntities dbcontext = new ProbeerselASPDBEntities();
            OpdrachtASPCoreDag2.Opdracht1coredag2Context c = new OpdrachtASPCoreDag2.Opdracht1coredag2Context();
            //c.Teacher.SelectMany<Teacher>(a=> { new Teacher(); }).ToList();
            Teacher jojo = c.Teacher.Find(1);
            Teacher g = new Teacher();
            g.AddedOn = new DateTime();
            g.Name = "Fred";
            g.Skills = "nope";
            g.Salary = 5;
            _logger.LogWarning("Here we are");
            Console.WriteLine("Hi all");
            g.TotalStudents = 14;
          //  c.Teacher.Add(g);
            var ab = c.Teacher.Where(a => a.Name == "Fred").ToList();
            Motor m = new Motor();
            m.Merk = "BMW";
            m.Prijs = 134;
            m.Type = "Zalco";
           // c.Motor.Add(m);
           // c.SaveChanges();
            return View(ab);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
