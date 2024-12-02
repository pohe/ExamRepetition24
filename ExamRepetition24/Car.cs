using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamRepetition24
{

    /// <summary>
    /// Spg 1. Klasser og Objekter
    /// </summary>
    public class Car
    {
        public string Model { get; set; }

		private string _regNr;

		public string RegNr
		{
			get { return _regNr; }
			set
            { //Spg. 8 Exception
                if (value.Length>10)
                {
                    throw new ArgumentException($"Regnr {value} er for langt ");
                }
                else
                    _regNr = value; 
            }
		}

        //Spg. 13 Add Driver to Car

        public Driver TheDriver { get; set; }

        public Car()
        {
            
        }




        public Car(string regNr, string model)
        { //Spg. 8 Exception
            if (regNr.Length > 10)
            {
                throw new ArgumentException($"Regnr {regNr} er for langt ");
            }
            else
                _regNr = regNr;
            _regNr = regNr;
            Model = model; 
        }

        public void AddDriverToCar(Driver driver)
        {
            TheDriver = driver; 
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"RegNr {_regNr} Model {Model}");
        }

        public override string ToString()
        {
            return $"RegNr {_regNr} Model {Model} Driver { (TheDriver != null ? TheDriver.Name : "No driver") }";
        }

    }
}
