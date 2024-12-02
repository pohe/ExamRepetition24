using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamRepetition24
{

    //Spg. 14 DriverRepository med Dictionary

    public class DriverRepositoryDictionary : IDriverRepository
    {
        private Dictionary<string, Driver> _drivers;

        public DriverRepositoryDictionary()
        {
            _drivers = new Dictionary<string, Driver>();
        }
        public int Count{ get { return _drivers.Count; } }

        public void AddDriver(Driver driver)
        {
            if (!_drivers.ContainsKey(driver.DriverLicenseNumber))
            {
                _drivers.Add(driver.DriverLicenseNumber, driver);
            }
            else
                throw new DriverExistException("Der eksisterer en driver med samme DriverLicenseNr");
        }

        public void DeleteDriver(string driverLicenseNumber)
        {
            if (_drivers.ContainsKey(driverLicenseNumber))
            {
                _drivers.Remove(driverLicenseNumber);
            }
        }

        public List<Driver> FindAllDriversByName(string name)
        {
            List<Driver> returnList = new List<Driver>();
            foreach(Driver d in _drivers.Values)
            {
                if (d.Name == name)
                {
                    returnList.Add(d);
                }
            }
            return returnList;
        }

        public Driver FindDriver(string driverLicenseNumber)
        {
            if (_drivers.ContainsKey(driverLicenseNumber))
            {
                return _drivers[driverLicenseNumber];
            }
            return null;
        }

        public List<Driver> GetAll()
        {
            return _drivers.Values.ToList();
        }

        public Driver GetDriver(string driverLicenseNumber)
        {
            if (_drivers.ContainsKey(driverLicenseNumber))
            {
                return _drivers[driverLicenseNumber];
            }
            return null;
        }

        public void UpdateDriver(Driver newDriver, string driverLicenseNumber)
        {
            DeleteDriver(driverLicenseNumber);
            AddDriver(newDriver);
        }
    }
}
