using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamRepetition24
{
    public class Car
    {
        public string Model { get; set; }

		private string _regNr;

		public string RegNr
		{
			get { return _regNr; }
			set { _regNr = value; }
		}

        public Car()
        {
            
        }

        public Car(string regNr, string model)
        {
            _regNr = regNr;
            Model = model; 
        }

        public override string ToString()
        {
            return $"RegNr {_regNr} Model {Model}";
        }

    }
}
