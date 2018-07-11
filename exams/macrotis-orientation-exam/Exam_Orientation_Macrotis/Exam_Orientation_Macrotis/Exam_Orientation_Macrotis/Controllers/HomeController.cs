using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Exam_Orientation_Macrotis.Models;
using MacrotisExamApp.Repositories;
using Exam_Orientation_Macrotis.Services;

namespace Exam_Orientation_Macrotis.Controllers
{
    public class HomeController : Controller
    {
        public AttractionContext attractionContextObject { get; set; }
        public AttractionRepository attractionRepositoryObject { get; set; }
        public FilterService filterServiceObject { get; set; }

        public HomeController(AttractionContext attractionContextObject, AttractionRepository attractionRepositoryObject, FilterService filterServiceObject)
        {
            this.attractionContextObject = attractionContextObject;
            this.attractionRepositoryObject = attractionRepositoryObject;
            this.filterServiceObject = filterServiceObject;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return View(attractionContextObject.Attractions.ToList());
        }

        [HttpPost]
        [Route("/add")]
        public IActionResult Add(Attraction attraction)
        {
            attractionRepositoryObject.Create(attraction);
            return RedirectToAction("index");
        }

        [HttpGet]
        [Route("/edit/{id}")]
        public IActionResult Edit(long id)
        {
            Attraction attractionToEdit = attractionRepositoryObject.GetAttractionById(id);
            return View(attractionToEdit);
        }

        [HttpPost]
        [Route("/edit/{id}")]
        public IActionResult EditPost(Attraction attractionToEdit)
        {
            attractionRepositoryObject.Update(attractionToEdit);
            return RedirectToAction("index");
        }

        [HttpGet]
        [Route("/filter")]
        public IActionResult Attractions(string category, string city)
        {
            AttractionsJson resultJson = filterServiceObject.CategoryAndCityFilterJson(category, city);
            
            return Json(resultJson);
        }
    }
}
