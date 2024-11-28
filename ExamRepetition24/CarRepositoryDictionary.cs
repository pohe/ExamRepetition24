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

        public List<Car> FindAllModels(string model)
        {
            List<Car> tempCars = new List<Car>();
            foreach (Car car in _cars.Values)
            {
                if (car.Model == model)
                {
                    tempCars.Add(car);
                }
            }
            return tempCars;
        }

        public Car FindModel(string model)
        {
            //foreach(Car c in _cars.Values)
            //{
            //    if (c.Model == model)
            //        return c; 
            //}
            List<Car> tempList = _cars.Values.ToList();
            for (int i =0; i<_cars.Values.Count; i++)
            {
                if (tempList[i].Model == model)
                {
                    return tempList[i];
                }
            }

            return null;
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
                _cars.Remove(oldRegNr); //Det er nødvendigt at fjerne den hvis regnr opdateres
                AddCar(newCar);
            }
        }
    }
}
