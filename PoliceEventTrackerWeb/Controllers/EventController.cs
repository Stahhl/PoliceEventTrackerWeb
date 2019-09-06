using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PoliceEventTrackerWeb.Models;
using PoliceEventTrackerWeb.Data;
using PoliceEventTrackerWeb.Domain.Models;

namespace PoliceEventTrackerWeb.Controllers
{
    public class EventController : Controller
    {
        public EventController(DataAccess data)
        {
            dataAccess = data;
        }

        private DataAccess dataAccess;

        // GET: Event
        public ActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> DisplayLatestEvents()
        {
            var events = await dataAccess.GetLatestEvents(50);

            return View(events);
        }
        // GET: Event/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var e = await dataAccess.GetEventById(id);

            return View(e);
        }

        // GET: Event/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Event/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Event/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Event/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Event/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Event/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}