using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TruckersRegistration.Model.Entity;
using TruckersRegistration.Service;

namespace TruckersRegistration.Controllers
{
    public class DriverController : Controller
    {
        private readonly DriverService _service;

        public DriverController(DriverService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var drivers = _service.Load();

            return View(drivers);
        }

        [HttpGet]
        public IActionResult Save()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save(Driver driver)
        {
            _service.Save(driver);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var driver = _service.Load(id);

            return View("Save", driver);
        }

        public IActionResult Delete(int id)
        {
            _service.Delete(id);

            return RedirectToAction("Index");
        }
    }
}
