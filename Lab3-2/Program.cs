﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.Make = "BMW";
            c1.Model = "M5";
            c1.CurrentSpeed = 0;
            c1.EngineSize = 1.8;

            Car c2 = new Car();
            c2.Make = "Opel";
            c2.Model = "Astra";
            c2.CurrentSpeed = 0;
            c2.EngineSize = 1.2;

            c1.DisplayCarInfo();

          Console.WriteLine(c2);

            for (int i = 0; i < 10; i++)
            {
                c1.Accelerate();
            }

            Console.WriteLine(c1);


            //Console.WriteLine($"The {c1.Make} {c1.Model}, engine size {c1.EngineSize}L is currently travelling at {c1.CurrentSpeed} km/h ");

            //Console.WriteLine($"The {c2.Make} {c2.Model}, engine size {c2.EngineSize}L is currently travelling at {c2.CurrentSpeed}km/h ");
        }
    }
}
