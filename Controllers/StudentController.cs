using Lab1MVCApp_Sanchez.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab1MVCApp_Sanchez.Controllers
{
    public class StudentController : Controller
    {

        private static List<Student> _students = new List<Student>
        {
            new Student { Id=1, Name="Ana Reyes",      Program="BSCS",
                          Email="ana@email.com",   Address="Cebu City",     Gender="Female", MotherName="Rosa",  FatherName="Luis"   },
            new Student { Id=2, Name="Carlo Santos",   Program="BSIT",
                          Email="carlo@email.com", Address="Mandaue City",  Gender="Male",   MotherName="Nena",  FatherName="Jose"   },
            new Student { Id=3, Name="Maria Lopez",    Program="BSIS",
                          Email="maria@email.com", Address="Lapu-Lapu",     Gender="Female", MotherName="Clara", FatherName="Ramon"  },
            new Student { Id=4, Name="Ben Torres",     Program="BSCS",
                          Email="ben@email.com",   Address="Talisay City",  Gender="Male",   MotherName="Lina",  FatherName="Pedro"  },
            new Student { Id=5, Name="Grace Flores",   Program="BSIT",
                          Email="grace@email.com", Address="Consolacion",   Gender="Female", MotherName="Minda", FatherName="Frank"  },
            new Student { Id=6, Name="James Ocampo",   Program="BSIS",
                          Email="james@email.com", Address="Minglanilla",   Gender="Male",   MotherName="Perla", FatherName="Diego"  },
            new Student { Id=7, Name="Jenny Castillo", Program="BSCS",
                          Email="jenny@email.com", Address="Danao City",    Gender="Female", MotherName="Alma",  FatherName="Oscar"  },
            new Student { Id=8, Name="Mark Ramos",     Program="BSIT",
                          Email="mark@email.com",  Address="Carcar City",   Gender="Male",   MotherName="Cita",  FatherName="Andres" },
        };


        public IActionResult Index()
        {
            if (TempData["Message"] is string msg)
                ViewBag.Message = msg;

            return View(_students);
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {

                _students.Add(student);

                TempData["Message"] = $"Student '{student.Name}' added successfully!";
                return RedirectToAction("Index");
            }
            return View(student);
        }
    }
}
