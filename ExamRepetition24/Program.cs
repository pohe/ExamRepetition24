// See https://aka.ms/new-console-template for more information
using ExamRepetition24;

Console.WriteLine("Hello, World!");

Car c1 = new Car("AB 1231", "Volvo");
Console.WriteLine(c1);
Car c2 = new Car("CD 4343", "Volvo");
Console.WriteLine(c2);
Car c3 = new Car("FG 5454", "Volvo");
Console.WriteLine(c2);
Car c4 = new Car("XDD 4556", "Volvo");
Console.WriteLine(c2);

Console.WriteLine("CarRepositoryList");

//ICarRepository carRepo = new CarRepositoryList();
ICarRepository carRepo = new CarRepositoryDictionary();
carRepo.AddCar(c1);
carRepo.AddCar(c2);
carRepo.AddCar(c3);
carRepo.AddCar(c4);

List<Car> cars = carRepo.GetAll();
foreach (Car c in cars)
{
    Console.WriteLine(c);
}

Console.WriteLine("DeleteCar med regnr FG 5454");
carRepo.DeleteCar("FG 5454");
cars = carRepo.GetAll();
foreach (Car c in cars)
{
    Console.WriteLine(c);
}

Console.WriteLine("UpdateCar med regnr CD 4343 til en model Mercedes");

Car cToUpdate = new Car("CD 4343", "Mercedes");
carRepo.UpdateCar(cToUpdate, cToUpdate.RegNr);

cars = carRepo.GetAll();
foreach (Car c in cars)
{
    Console.WriteLine(c);
}
Console.WriteLine("Arv");
ECar eCar = new ECar("ER 3434", "Saab", 500);
//Car eCar = new ECar("ER 3434", "Saab", 500);
Console.WriteLine(eCar);
c1.PrintInfo();
eCar.PrintInfo();

Console.WriteLine("Polymorfi");
carRepo.AddCar(eCar);
cars = carRepo.GetAll();
foreach (Car c in cars)
{
    Console.WriteLine(c);
}

Console.WriteLine("Find model");
Car foundCar = carRepo.FindModel("Volvo");
Console.WriteLine(foundCar);

Console.WriteLine("FindAllModels");
List<Car> returnList = carRepo.FindAllModels("Volvo");
foreach( Car c in returnList)
{
    Console.WriteLine(c);
}


