﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public Car() { }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool IsDriveable = false)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
        }

        public void MakeEngineNoise() { Console.WriteLine($"{EngineNoise}"); }
        public void MakeHonkNoise() { Console.WriteLine($"{HonkNoise} {HonkNoise}"); }



    }        
}
