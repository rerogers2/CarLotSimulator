using System;
using System.Net.Http.Headers;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot lot = new CarLot(); // declared the Lot list of cars

            // Standard method for initialization

            // Car1,Car4,Car7: 2019 Honda CRV
            // Car2,Car5,Car8: 2005 Ford Focus
            // Car3,Car6,Car9: 1969 Chevrolet Corvette
            Car Car1 = new Car();
            Car Car2 = new Car();
            Car Car3 = new Car();

            // First car
            Car1.Year = 2019;
            Car1.Make = "Honda";
            Car1.Model = "CRV";
            Car1.EngineNoise = "Vroom";
            Car1.HonkNoise = "Honk";
            Car1.IsDriveable= true;
            lot.CarList.Add(Car1);
            CarLot.numberOfCars++;
            Console.WriteLine($"The number of cars in the carlot is currently: {CarLot.numberOfCars}");

            Car1.MakeEngineNoise();
            Car1.MakeHonkNoise();

            // Second car
            Car2.Year = 2005;
            Car2.Make = "Ford";
            Car2.Model = "Focus";
            Car2.EngineNoise = "grrrrrr";
            Car2.HonkNoise = "beep";
            Car2.IsDriveable = false;
            lot.CarList.Add(Car2);
            CarLot.numberOfCars++;
            Console.WriteLine($"The number of cars in the carlot is currently: {CarLot.numberOfCars}");

            Car2.MakeEngineNoise();
            Car2.MakeHonkNoise();

            // Third car
            Car3.Year = 1969;
            Car3.Make = "Chevrolet";
            Car3.Model = "Corvette";
            Car3.EngineNoise = "pitterpatter";
            Car3.HonkNoise = "meeeeeeep";
            Car3.IsDriveable = true;
            lot.CarList.Add(Car3);
            CarLot.numberOfCars++;
            Console.WriteLine($"The number of cars in the carlot is currently: {CarLot.numberOfCars}");

            Car3.MakeEngineNoise();
            Car3.MakeHonkNoise();

            // Object initializer syntax
            // re-initialized all 3 cars with new variable names on one line
            Car Car4 = new Car() { Year = 2019, Make = "Honda", Model = "CRV", EngineNoise = "Vroom", HonkNoise = "Honk", IsDriveable = true};
            lot.CarList.Add(Car4);
            CarLot.numberOfCars++;
            Console.WriteLine($"The number of cars in the carlot is currently: {CarLot.numberOfCars}");
            Car Car5 = new Car() { Year = 2005, Make = "Ford", Model = "Focus", EngineNoise = "grrrrrr", HonkNoise = "beep", IsDriveable = false };
            lot.CarList.Add(Car5);
            CarLot.numberOfCars++;
            Console.WriteLine($"The number of cars in the carlot is currently: {CarLot.numberOfCars}");
            Car Car6 = new Car() { Year = 1969, Make = "Chevrolet", Model = "Corvette", EngineNoise = "pitterpatter", HonkNoise = "meeeeeeep", IsDriveable = true };
            lot.CarList.Add(Car6);
            CarLot.numberOfCars++;
            Console.WriteLine($"The number of cars in the carlot is currently: {CarLot.numberOfCars}");

            Car4.MakeEngineNoise();
            Car4.MakeHonkNoise();
            Car5.MakeEngineNoise();
            Car5.MakeHonkNoise();
            Car6.MakeEngineNoise();
            Car6.MakeHonkNoise();

            // Constructor Initialization
            Car Car7 = new Car(2019,"Honda","CRV","Vroom","Honk",true);
            lot.CarList.Add(Car7);
            CarLot.numberOfCars++;
            Console.WriteLine($"The number of cars in the carlot is currently: {CarLot.numberOfCars}");
            Car Car8 = new Car(2005, "Ford", "Focus", "grrrrrr", "beep", false);
            lot.CarList.Add(Car8);
            CarLot.numberOfCars++;
            Console.WriteLine($"The number of cars in the carlot is currently: {CarLot.numberOfCars}");
            Car Car9 = new Car(1969, "Chevrolet", "Corvette", "pitterpatter", "meeeeeeep", true);
            lot.CarList.Add(Car9);
            CarLot.numberOfCars++;
            Console.WriteLine($"The number of cars in the carlot is currently: {CarLot.numberOfCars}");

            Car7.MakeEngineNoise();
            Car7.MakeHonkNoise();
            Car8.MakeEngineNoise();
            Car8.MakeHonkNoise();
            Car9.MakeEngineNoise();
            Car9.MakeHonkNoise();

            // iterate the list of cars in the carlot
            Console.WriteLine("\nWelcome to the Car Lot. Here is a list of our cars:");
            foreach (var vehicle in lot.CarList)
            {
                Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model}");
            }

            //TODO

            //Create a seperate class file called Car 
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
