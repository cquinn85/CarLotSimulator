using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    //Create a CarLot class

    class CarLot
    {
        public CarLot()
        {

        }

        //It should have at least one property: a List of cars
        public List<Car> Cars = new List<Car>();

        /* static field called numberOfCars. 
         * Have this number only increment when in our program 
         * we create a new Car. From there create 3 cars in the Main() 
         * and then each time you create a car, do a Console.WriteLine() 
         * printing the current number of cars in the car lot. */
        public static int numberOfCars;
    }
}
