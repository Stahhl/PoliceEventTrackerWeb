using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PoliceEventTrackerWeb.Data;

namespace PoliceEventTrackerWeb.Controllers
{
    public class LocationController : Controller
    {
        public LocationController(DataAccess data)
        {
            dataAccess = data;
        }

        private DataAccess dataAccess;

        // GET: Location
        public ActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> TopLocations()
        {
            var locations = await dataAccess.GetTopLocations();

            return View(locations);
        }
    }
}