using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamRepetition24
{
    //Spg 10 Interface IDriverRepository 

    public interface IDriverRepository
    {
        int Count { get; }

        void AddDriver(Driver driver);
        List<Driver> GetAll();
        Driver GetDriver(string driverLicenseNumber);
        void DeleteDriver(string driverLicenseNumber);
        void UpdateDriver(Driver newDriver, string driverLicenseNumber);

        Driver FindDriver(string driverLicenseNumber); 

        List<Driver> FindAllDriversByName(string name);
    }
}
