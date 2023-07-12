using Core_Practical_17.Interface;
using Core_Practical_17.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Diagnostics;

namespace Core_Practical_17.Controllers;

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStudentRepo _studentRepo;

        public HomeController(ILogger<HomeController> logger, IStudentRepo studentRepo)
        {
            _logger = logger;
            this._studentRepo = studentRepo;
        }



        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult AddStudent(Student student)
        {
            _studentRepo.AddStudent(student);
           return RedirectToAction("GetAllStudent", "Home");
        }

        
        [Authorize(Roles = "User,Admin")]
        public IActionResult GetAllStudent()
        {
            return View(_studentRepo.GetAll());
        }

        [Authorize ]
        public IActionResult Details(int id)
        {
            return View(_studentRepo.GetStudentById(id));
        }

        [Authorize]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(_studentRepo.GetStudentById(id));
        }


        [Authorize]
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if(ModelState.IsValid)
            {
                _studentRepo.Edit(student);
                return RedirectToAction("GetAllStudent", "Home");
            }
            return View();
        }

        [HttpGet]
        [Authorize(Roles ="Admin")]
        public IActionResult Delete(int id)
        {
            _studentRepo.Delete(id);
            return RedirectToAction("GetAllStudent", "Home");
        }


        [Authorize]
        public IActionResult AuthorisedPage()
        {
            return View();
        }

         
        public IActionResult Index()
        {
            return View();
        }

      
 
    }
