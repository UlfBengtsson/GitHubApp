using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppGitHub.Model
{
    public class Car
    {
        public static int idCounter = 0;

        public int Id { get; set; }
        public string Brand { get; set; }
        public string ModelName { get; set; }

        public Car()
        {
            Id = ++idCounter;
        }
    }
}
