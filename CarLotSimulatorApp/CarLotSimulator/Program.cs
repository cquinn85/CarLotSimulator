using System;
using System.Data.SqlTypes;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //DONE: Create a seperate class file called Car
            //DONE: Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //DONE: Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //DONE: The methods should take one string parameter: the respective noise property

            //Instanciate the a Carlot at the beginning of the program 
            //and as you create a car add the car to the list.
            var lot = new CarLot();

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //Instantiate 1 (using Dot Notation)
            var myCar = new Car();
            myCar.Make = "Nissan";
            myCar.Model = "Rogue";
            myCar.Year = 2010;
            myCar.EngineNoise = "vroom";

            myCar.HonkNoise = "beep beep";
            myCar.IsDriveable = true;

            lot.Cars.Add(myCar);

            //Instaniation 2 (object initializer syntax)
            var joansCar = new Car()
            {
                Year = 2019,
                Make = "Hyundai",
                Model = "Kona",
                EngineNoise = "...",
                HonkNoise = "beep",
                IsDriveable = false

            };
            lot.Cars.Add(joansCar);

            //Instantiate 3 (using the contructor to allow parameter values to be placed inside properties)
            var mikesCar = new Car(2015, "Honda", "Civic", "vrooom", "meep meep", true);
            lot.Cars.Add(mikesCar);

            //Call methods

            myCar.MakeEngineNoise(myCar.EngineNoise);
            mikesCar.MakeEngineNoise(mikesCar.EngineNoise);
            joansCar.MakeEngineNoise(joansCar.EngineNoise);



            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars

            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}.");
            }
        }
    }
}


            