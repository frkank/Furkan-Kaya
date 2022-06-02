using BesikduzuSeyahat.Business.Abstract;
using BesikduzuSeyahat.Data.Abstract;
using BesikduzuSeyahat.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BesikduzuSeyahat.WebUI.Controllers
{
    public class HomeController : Controller
    {

        private ICityService _cityService;
        private IDirectionService _directionService;

        public HomeController(ICityService cityService, IDirectionService directionService)
        {
            this._cityService = cityService;
            this._directionService = directionService;
        }


        public IActionResult Index(string departure, string arrival)
        {
            if (departure == null || arrival == null || departure == arrival)
            {
                var cityModel = new DirectionTicket()
                {
                    Cities = _cityService.GetAll(),
                    Directions = null
                };

                ViewBag.Cities = new SelectList(cityModel.Cities, "CityId", "CityName");
                return View(cityModel);
            }
            else
            {
                var cityModel = new DirectionTicket()
                {
                    Cities = _cityService.GetAll(),
                    Directions = _directionService.GetTravel(departure, arrival)
                };
                TempData["departure"] = _directionService.GetDeparture(departure);
                TempData["arrival"] = _directionService.GetArrival(arrival);
                ViewBag.Cities=new SelectList(cityModel.Cities, "CityId","CityName");
                return View(cityModel);
            }
        }
        public IActionResult History()
        {
            return View();
        }
        public IActionResult BoardMembers()
        {
            return View();
        }
        public IActionResult Treats()
        {
            return View();
        }
        public IActionResult ServiceCenter()
        {
            return View();
        }
    }
}
