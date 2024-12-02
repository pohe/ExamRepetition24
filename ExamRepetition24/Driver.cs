using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamRepetition24
{

    //Spg. 9 Class Driver  Klasser og Objekter

    public class Driver
    {
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

        public string DriverLicenseNumber { get; set; }

        public Driver(string name, string driverLicenseNumber )
        {
            _name = name;
            DriverLicenseNumber = driverLicenseNumber;
        }

        public override string ToString()
        {
            return $"Name {_name} Driver Licensenumber {DriverLicenseNumber}";
        }
    }
}
