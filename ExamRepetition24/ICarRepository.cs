using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamRepetition24
{
    public interface ICarRepository
    {
        int Count { get; }

        void AddCar(Car car);
        List<Car> GetAll();
        Car GetCar(string regNr);
        void DeleteCar(string regNr);
        void UpdateCar(Car newCar, string oldRegNr);

    }
}
