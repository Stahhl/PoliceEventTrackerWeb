using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PoliceEventTrackerWeb.Models;
using PoliceEventTrackerWeb.Data;
using PoliceEventTrackerWeb.Domain.Models;

namespace PoliceEventTrackerWeb.App.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(DataAccess data)
        {
            dataAccess = data;
        }

        private DataAccess dataAccess;

        public IActionResult UpdateDatabaseResult(Update update)
        {
            var eventsInUpdate = update.Events;

            return View(eventsInUpdate);
        }
        public async Task<IActionResult> Errors()
        {
            var errors = await dataAccess.RemoveAllErrors();

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> DisplayLatestEvents()
        {
            var events = await dataAccess.GetLatestEvents(50);

            return View(events);
        }
        public async Task<IActionResult> Details(int id)
        {
            var e = await dataAccess.GetEventById(id);

            return View(e);
        }
        public async Task<IActionResult> TopLocations()
        {
            var locations = await dataAccess.GetTopLocations();

            return View(locations);
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
