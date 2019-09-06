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

        public IActionResult Index()
        {
            return View();
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
