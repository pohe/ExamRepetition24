using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamRepetition24
{

    /// <summary>
    /// Spg 2. Interface
    /// </summary>
    public interface ICarRepository
    {
        
        int Count { get; }

        void AddCar(Car car);
        List<Car> GetAll();
        Car GetCar(string regNr);
        void DeleteCar(string regNr);
        void UpdateCar(Car newCar, string oldRegNr);

        Car FindModel(string model); //finder første car af en given model

        List<Car> FindAllModels(string model);//finder alle cars af en given model
    }
}
