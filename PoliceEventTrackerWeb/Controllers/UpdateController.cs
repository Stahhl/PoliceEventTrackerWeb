using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PoliceEventTrackerWeb.Data;

namespace PoliceEventTrackerWeb.Controllers
{
    public class UpdateController : Controller
    {
        public UpdateController(DataAccess data)
        {
            dataAccess = data;
        }

        private DataAccess dataAccess;

        public async Task<IActionResult> UpdateDatabase()
        {
            var update = await dataAccess.UpdateDatabase();

            //var errors = await dataAccess.RemoveAllErrors();

            return RedirectToAction(nameof(Index));
        }
        // GET: Update
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }

        //// GET: Update/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: Update/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Update/Create
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

        // GET: Update/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Update/Edit/5
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

        // GET: Update/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Update/Delete/5
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