using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography.X509Certificates; 

namespace CarLotSimulator
{
    class Car
    {
        public Car()
        {

        }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            //Car shall have the following properties: 
            //Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;

        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        //Car shall have the following methods: 
        //MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter:
        //the respective noise property

        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine(engineNoise);
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine(honkNoise);
        }
    }
}
