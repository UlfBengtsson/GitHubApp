using ConsoleAppGitHub.Model;
using System;

namespace ConsoleAppGitHub
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Car static counter: " + Car.idCounter);
            
            Car car1 = new Car();
            Console.WriteLine("Car static counter: " + Car.idCounter);
            
            Car car2 = new Car();
            Console.WriteLine("Car static counter: " + Car.idCounter);
            
            Car car3 = new Car();
            Console.WriteLine("Car static counter: " + Car.idCounter);

            Console.WriteLine("Car with id: " + car1.Id);
            Console.WriteLine("Car with id: " + car2.Id);
            Console.WriteLine("Car with id: " + car3.Id);
        }
    }
}
