using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamRepetition24
{

    //Spg. 11 DriverRepository med List 

    public class DriverRepositoryList : IDriverRepository
    {
        private List<Driver> _drivers;

        public DriverRepositoryList()
        {
            _drivers = new List<Driver>();
        }
        public int Count { get { return _drivers.Count; } }

        public void AddDriver(Driver driver)
        {
            if (FindDriver(driver.DriverLicenseNumber) != null)
            { //Spg 12 DriverExistException
                throw new DriverExistException("Der eksisterer en driver med samme DriverLicenseNr"); 
            }
            else
            {
                _drivers.Add(driver);
            }
        }

        public void DeleteDriver(string driverLicenseNumber)
        {
            Driver driverToRemove = FindDriver(driverLicenseNumber);
            if (driverToRemove != null)
            {
                _drivers.Remove(driverToRemove);
            }
        }

        public List<Driver> FindAllDriversByName(string name)
        {
            List<Driver> tempList = new List<Driver>();
            foreach(Driver div in _drivers)
            {
                if (div.Name == name)
                {
                    tempList.Add(div);
                }
            }
            return tempList;
        }

        public Driver FindDriver(string driverLicenseNumber)
        {
            foreach(Driver div in _drivers)
            {
                if (div.DriverLicenseNumber == driverLicenseNumber)
                    return div; 
            }
            return null;
        }

        public List<Driver> GetAll()
        {
            return _drivers;
        }

        public Driver GetDriver(string driverLicenseNumber)
        {
            foreach(Driver div in _drivers)
            {
                if (div.DriverLicenseNumber == driverLicenseNumber)
                {
                    return div; 
                }
            }
            return null;
        }

        public void UpdateDriver(Driver newDriver, string driverLicenseNumber)
        {
            Driver divToUpdate = GetDriver(driverLicenseNumber);
            divToUpdate.DriverLicenseNumber = newDriver.DriverLicenseNumber;
            divToUpdate.DriverLicenseNumber = newDriver.Name;
        }
    }
}
