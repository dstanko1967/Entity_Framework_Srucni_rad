using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Skola.Models;


namespace Skola.Controllers
{
    public class StudentController : Controller
    {
        static Studenti[] student = new Studenti[]
             {
               new Studenti { Id = 1, Ime = "Petar", Prezime = "Radovanović", JMBG ="0405997740034" , MestoRođenja = "Beograd" },
               new Studenti { Id = 2, Ime = "Miliica", Prezime = "Jovanović", JMBG = "2211997765012", MestoRođenja = "Subotica" },
               new Studenti { Id = 3, Ime = "Predrag", Prezime = "Simonovič", JMBG = "15029977200476", MestoRođenja = "Beograd" }
             };

        public IActionResult Index()
        {

            return View();

        }
        public IActionResult StudentInfo()
        {
           

            return View(student);

        }
        



    }
}
