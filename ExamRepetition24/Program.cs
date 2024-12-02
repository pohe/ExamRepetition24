// See https://aka.ms/new-console-template for more information
using ExamRepetition24;
using System.Security.Claims;


Console.WriteLine("Spg 1. Klasser og Objekter \n");

Car c1 = new Car("AB 1231", "Volvo");
Console.WriteLine(c1);
Car c2 = new Car("CD 4343", "Volvo");
Console.WriteLine(c2);
Car c3 = new Car("FG 5454", "Volvo");
Console.WriteLine(c3);
Car c4 = new Car("XDD 4556", "Volvo");
Console.WriteLine(c4);


//Spg. 3 CarRepository med List 

//Console.WriteLine("CarRepositoryList");
//ICarRepository carRepo = new CarRepositoryList();

//Spg. 4 CarRepository med Dictionary med RegNr som key

Console.WriteLine("\nCarRepositoryDictionary\n");
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

Console.WriteLine("\nDeleteCar med regnr FG 5454 \n");
carRepo.DeleteCar("FG 5454");
cars = carRepo.GetAll();
foreach (Car c in cars)
{
    Console.WriteLine(c);
}

Console.WriteLine("\nUpdateCar med regnr CD 4343 til en model Mercedes \n");

Car cToUpdate = new Car("CD 4343", "Mercedes");
carRepo.UpdateCar(cToUpdate, cToUpdate.RegNr);

cars = carRepo.GetAll();
foreach (Car c in cars)
{
    Console.WriteLine(c);
}
//Spg 5. Inheritance (Arv)
Console.WriteLine("\nArv \n");
ECar eCar = new ECar("ER 3434", "Saab", 500);
//Car eCar = new ECar("ER 3434", "Saab", 500);
Console.WriteLine(eCar);
c1.PrintInfo();
eCar.PrintInfo();

Console.WriteLine("\nPolymorfi\n");
carRepo.AddCar(eCar);
cars = carRepo.GetAll();
foreach (Car c in cars)
{
    Console.WriteLine(c);
}

//Spg. 6 Søgning/Filtrering
// Spg. 7 Løkke strukturer
Console.WriteLine("\nFind model \n");
Car foundCar = carRepo.FindModel("Volvo");
Console.WriteLine(foundCar);

Console.WriteLine("\nFindAllModels \n");
List<Car> returnList = carRepo.FindAllModels("Volvo");
foreach( Car c in returnList)
{
    Console.WriteLine(c);
}

Console.WriteLine("\nSpg. 8 Exception\n");
try
{

    Car c5 = new Car("XXX123456789", "Mercedes");
}
catch (ArgumentException aex)
{
    Console.WriteLine(aex.Message);
}
catch (Exception exp)
{
    Console.WriteLine("Der forekom en generel fejl");
}
finally
{
    Console.WriteLine("I denne del komme man altid ligegyldigt om der forekommer fejl eller ej!");
}

//Spg. 8 Exception

Car c6 = new Car();
try
{
    c6.RegNr = "YYY987654321";
    c6.Model = "Mercedes";
}
catch (ArgumentException aex)
{
    Console.WriteLine(aex.Message);
}
catch (Exception exp)
{
    Console.WriteLine("Der forekom en generel fejl");
}
finally
{
    Console.WriteLine("I denne del komme man altid ligegyldigt om der forekommer fejl eller ej!");
}

Console.WriteLine("\nSpg. 9 Class Driver  Klasser og Objekter\n");

Driver d1 = new Driver("Poul Henriksen", "XJ 3434334656");
Driver d2 = new Driver("Charlotte Heegaard", "GH 909009409545");
Driver d3 = new Driver("Mikkel Krarup", "KL 65656645467");
Driver d4 = new Driver("Vibeke Sandau", "JK 54545235645");
Console.WriteLine(d1);
Console.WriteLine(d2);
Console.WriteLine(d3);
Console.WriteLine(d4);

//Spg. 11 DriverRepository med List 
Console.WriteLine("\nSpg. 11 DriverRepository med List \n");
IDriverRepository driverRepo = new DriverRepositoryList();

//Spg. 14 DriverRepository med Dictionary
//Console.WriteLine("\nSpg. 14 DriverRepository med Dictionary\n");
//IDriverRepository driverRepo = new DriverRepositoryDictionary();

driverRepo.AddDriver(d1);
driverRepo.AddDriver(d2);
driverRepo.AddDriver(d3);
driverRepo.AddDriver(d4);

Console.WriteLine("\nTest getAll \n");
List<Driver> allDrivers = driverRepo.GetAll();
foreach(Driver driv in allDrivers)
{
    Console.WriteLine(driv);
}
int noDrivers = driverRepo.Count;
Console.WriteLine($"Antal drivers {noDrivers}");
Driver driverFound = driverRepo.GetDriver("KL 65656645467"); 
if (driverFound != null)
{
    Console.WriteLine($"GetDriver found { driverFound}");
}
Console.WriteLine("\nDelete driver KL 65656645467\n");
driverRepo.DeleteDriver("KL 65656645467");
allDrivers = driverRepo.GetAll();
foreach (Driver driv in allDrivers)
{
    Console.WriteLine(driv);
}
Console.WriteLine("\nUpdate driver Poul Henrik Henriksen  XJ 3434334656\n");
Driver driverNew = new Driver("Poul Henrik Henriksen", "XJ 3434334656");
driverRepo.UpdateDriver(driverNew, "XJ 3434334656");
allDrivers = driverRepo.GetAll();
foreach (Driver driv in allDrivers)
{
    Console.WriteLine(driv);
}

Console.WriteLine("Found driverByName");
List<Driver> driversByName = driverRepo.FindAllDriversByName("Poul Henriksen"); 
foreach(Driver driver in driversByName)
{
    Console.WriteLine(driver);
}


Console.WriteLine("\nSpg 12 DriverExistException\n");
Driver driverDublet; 
try
{
    driverDublet = new Driver("Vibeke Sandau", "JK 54545235645");
    driverRepo.AddDriver(driverDublet);
    Console.WriteLine("\ndriverDublet added with success!\n");
}
catch(DriverExistException dee)
{
    Console.WriteLine(dee.Message);
} 
catch(Exception exp)
{
    Console.WriteLine(exp.Message);
}

Console.WriteLine("\nSpg. 13 Add Driver to Car\n");
c1.AddDriverToCar(d1);
Console.WriteLine(c1);
c2.AddDriverToCar(d2);
Console.WriteLine(c2);

