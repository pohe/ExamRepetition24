using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamRepetition24
{
    /// <summary>
    /// Spg 5. Inheritance (Arv)
    /// </summary>
    public class ECar :Car  //ECar is a Car
    {
		private int _range;

		public int Range
		{
			get { return _range; }
			set { _range = value; }
		}

        public ECar(string regNr, string model, int range): base(regNr, model)
        {
            _range = range;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Regnr {RegNr} Model {Model} Range {_range}");
        }

        public override string ToString()
        {
            return base.ToString() + $" Range {_range}";
        }

    }
}
