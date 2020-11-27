using System;
using System.Collections.Generic;
using System.Text;
using TruckersRegistration.Model.Entity;
using TruckersRegistration.Repository;

namespace TruckersRegistration.Service
{
    public class DriverService
    {
        private readonly DriverRepository _repository;

        public DriverService(DriverRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Driver> Load()
        {
            return _repository.Load();
        }

        public Driver Load(int id)
        {
            return _repository.Load(id);
        }

        public void Save(Driver driver)
        {
            if (driver.Id == 0)
                _repository.Save(driver);
            else
                _repository.Edit(driver);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
