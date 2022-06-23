using BesikduzuSeyahat.Business.Abstract;
using BesikduzuSeyahat.Entity;
using BesikduzuSeyahat.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BesikduzuSeyahat.WebUI.Controllers
{
    public class DirectionController : Controller
    {
        private readonly IDirectionService _directionService;
        private readonly ICityService _cityService;

        public DirectionController(IDirectionService directionService, ICityService cityService)
        {
            _directionService = directionService;
            _cityService = cityService;
        }

        public IActionResult DirectionList()
        {
            var getDirections = _directionService.GetAll();
            return View(getDirections);
        }
        public IActionResult CreateDirection()
        {
            ViewBag.Cities = new SelectList(_cityService.GetAll().OrderBy(i => i.CityName), "CityName", "CityName");
            return View();
        }
        [HttpPost]
        public IActionResult CreateDirection(Direction direction)
        {
            _directionService.Create(direction);
            ViewBag.Cities = new SelectList(_cityService.GetAll().OrderBy(i => i.CityName), "CityName", "CityName");
            return RedirectToAction("DirectionList");
        }
        public IActionResult DeleteDirection(int directionId)
        {
            var direction = _directionService.GetById(directionId);
            if (direction!=null)
            {
                _directionService.Delete(direction);
            }

            return RedirectToAction("DirectionList");
        }
        
    }
}
