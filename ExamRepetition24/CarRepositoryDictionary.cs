using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExamRepetition24
{
    public class CarRepositoryDictionary : ICarRepository
    {
        private Dictionary<string, Car> _cars;

        public CarRepositoryDictionary()
        {
            _cars = new Dictionary<string, Car>();
        }
        public int Count { get { return _cars.Count; } }

        public void AddCar(Car car)
        {
            if (!_cars.ContainsKey(car.RegNr)) //Husk der ikke må være dubletter
            {
                _cars.Add(car.RegNr, car);
            }
        }

        public void DeleteCar(string regNr)
        {
            if (_cars.ContainsKey(regNr))  //If kan undværes
            {
                _cars.Remove(regNr);
            }
        }

        public List<Car> GetAll()
        {
            return _cars.Values.ToList();
        }

        public Car GetCar(string regNr)
        {
            if (_cars.ContainsKey(regNr))  //If kan undværes
            {
                return _cars[regNr];
            }
            return null;
        }

        public void UpdateCar(Car newCar, string oldRegNr)
        {
            if (_cars.ContainsKey(oldRegNr))
            {
                _cars.Remove(oldRegNr);
                AddCar(newCar);
            }
        }
    }
}
