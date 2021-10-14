using System;
using System.Collections.Generic;

namespace PairPraactice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> CarList = new List<Car>
            {
               new Car("Mitsubishi", "3000GT", 1995, 89000)
            };


            foreach(Car m in CarList)
            {
                Console.WriteLine(m.ToString());
            }
        }
    }
}
