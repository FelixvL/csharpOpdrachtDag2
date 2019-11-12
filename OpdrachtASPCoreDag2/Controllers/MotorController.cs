using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OpdrachtASPCoreDag2.Models;
using OpdrachtASPCoreDag2.Repositories;

namespace OpdrachtASPCoreDag2.Controllers
{
    public class MotorController : Controller
    {
        private readonly IMotorRepository repo;

        public MotorController(IMotorRepository repo) {
            this.repo = repo;
        }

        public IActionResult ShowMotoren() {
            var list = repo.GetMotoren();
            return View( "Views/Home/MotorenOverview.cshtml",list);
        }

        public IActionResult VoegToe() {
            return View("Views/Home/MotorenToevoegen.cshtml", new MotorModel());
        }
        public IActionResult VoegToePost(MotorModel mModel) {
            repo.VoegMotorToe(mModel);
            var list = repo.GetMotoren();
            return View("Views/Home/MotorenOverview.cshtml", list);
        }

    }
}
