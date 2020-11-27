using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TruckersRegistration.Model.Entity;

namespace TruckersRegistration.Repository
{
    public class DriverRepository
    {
        private readonly ApplicationDbContext _context;

        public DriverRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Driver> Load()
        {
            return _context.Drivers
                            .Include("Truck")
                            .Include("Address");
        }

        public Driver Load(int id)
        {
            return _context.Drivers
                            .Include("Truck")
                            .Include("Address")
                            .First(d => d.Id == id);
        }

        public void Save(Driver driver)
        {
            _context.Drivers.Add(driver);
            _context.SaveChanges();
        }

        public void Edit(Driver driver)
        {
            var model = _context.Drivers.First(d => d.Id == driver.Id);

            model.Name = driver.Name;
            model.Truck = driver.Truck;
            model.Address = driver.Address;
            
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var model = _context.Drivers.First(d => d.Id == id);
            _context.Drivers.Remove(model);
            
            _context.SaveChanges();
        }
    }
}
