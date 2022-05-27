using System;



namespace Airplan
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] realData = File.ReadAllLines("airplan2.dat");
            var result = Flight.Calculate(realData, true);

            Console.WriteLine("start");
        }

    }
}