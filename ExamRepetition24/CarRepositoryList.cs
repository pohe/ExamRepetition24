using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExamRepetition24
{
    public class CarRepositoryList : ICarRepository
    {
        private List<Car> _cars;

        public CarRepositoryList()
        {
            _cars = new List<Car>();
        }
        public int Count{ get { return _cars.Count; } }

        public void AddCar(Car car)
        {
            _cars.Add(car);//O(1)
        }

        public Car GetCar(string regNr)
        {
            foreach(Car c in _cars)  // O(n)
            {
                if (c.RegNr == regNr)
                {
                    return c;
                } 
            }
            return null;
        }

        public void DeleteCar(string regNr)
        {
            Car carToRemove = GetCar(regNr);
            if (carToRemove != null)
                _cars.Remove(carToRemove);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        

        public void UpdateCar(Car newCar, string oldRegNr)
        {
            Car oldCar = GetCar(oldRegNr);
            oldCar.RegNr = newCar.RegNr;
            oldCar.Model = newCar.Model;
        }

        public Car FindModel(string model)
        {
            // Lav den om til et for loop og et while loop?
            //foreach(Car c in _cars)
            //{
            //    if (c.Model == model)
            //        return c;
            //}
            //For loop
            //for(int index = 0; index <_cars.Count; index++ )
            //{
            //    if (_cars[index].Model== model  )
            //    {
            //        return _cars[index];
            //    }
            //}


            //while loop
            int i = 0;
            while(i<_cars.Count)
            {
                if (_cars[i].Model == model)
                {
                    return _cars[i];
                }
                i++;
            }
            return null;
        }

        public List<Car> FindAllModels(string model)
        {
            List<Car> tempCars = new List<Car>();
            foreach (Car car in _cars)
            {
                if (car.Model == model)
                {
                    tempCars.Add(car);
                }
            }
            return tempCars;
        }
    }
}
