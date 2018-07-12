using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Exam_Orientation_Old.Models;
using Exam_Orientation_Old.Repositories;

namespace Exam_Orientation_Old.Controllers
{
    public class HomeController : Controller
    {
        public SpaceContext SpaceContextObject { get; set; }
        public PlanetRepository PlanetRepositoryObject { get; set; }
        public SpaceShipRepository SpaceShipRepositoryObject { get; set; }

        public HomeController(SpaceContext spaceContextObject, PlanetRepository planetRepositoryObject, SpaceShipRepository spaceShipRepositoryObject)
        {
            SpaceContextObject = spaceContextObject;
            PlanetRepositoryObject = planetRepositoryObject;
            SpaceShipRepositoryObject = spaceShipRepositoryObject;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {

            return View(SpaceContextObject);
        }

        [HttpPost("/toplanet/{id}")]
        public IActionResult ToPlanet(int id)
        {
            Planet planetToUpdate = PlanetRepositoryObject.GetTodoById(id);
            SpaceShip spaceshipToUpdate = SpaceShipRepositoryObject.GetTodoById(0);

            int populationToMove = 0;
            if (spaceshipToUpdate.Population < 60)
            {
                populationToMove = (int) spaceshipToUpdate.Population;
                spaceshipToUpdate.Population = 0;
            }
            else
            {
                populationToMove = 60;
                spaceshipToUpdate.Population -= populationToMove;
            }
            planetToUpdate.Population += populationToMove;
            PlanetRepositoryObject.Update(planetToUpdate);
            SpaceShipRepositoryObject.Update(spaceshipToUpdate);
            return RedirectToAction("index");
        }

        [HttpGet("/toship/{id}")]
        public IActionResult ToShip(int id)
        {
            Planet planetToUpdate = PlanetRepositoryObject.GetTodoById(id);
            SpaceShip spaceshipToUpdate = SpaceShipRepositoryObject.GetTodoById(0);
            int populationToMove = 0;
            if (planetToUpdate.Population<60)
            {
                populationToMove = planetToUpdate.Population;
                planetToUpdate.Population = 0;
            }
            else
            {
                populationToMove = 60;
                planetToUpdate.Population -= populationToMove;
            }
            spaceshipToUpdate.Population += populationToMove;
            PlanetRepositoryObject.Update(planetToUpdate);
            SpaceShipRepositoryObject.Update(spaceshipToUpdate);
            return RedirectToAction("index");
        }

        [HttpPost("/GoToPlanet")]
        public IActionResult GoToPlanet(int id)
        {
            SpaceShip ship = SpaceShipRepositoryObject.GetTodoById(0);
            ship.OnPlanet = id;
            SpaceShipRepositoryObject.Update(ship);
            return RedirectToAction("index");
        }
    }
}
