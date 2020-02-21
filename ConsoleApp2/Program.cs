using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    interface ICar
    {
        int speed { get; set; }
        int Move(int distance);
    }
    interface IPerson
    {
        string country { get; set; }
        int eat(int toplivo);
    }
    class BMW : ICar, IPerson
    {
        public string country { get; set; }
        public int speed { get; set; }
        
        public string Model { get; set; }
        public void info()
        {
            Console.WriteLine(Model);
        }
        public int Move(int distance)
        {
            return distance / speed;
        }

        public int eat(int toplivo)
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BMW car = new BMW();
            car.speed = 120;
            car.Model = "i8";
            car.country = "Китай";
               
            Console.WriteLine(car.Move(480));
            Console.WriteLine(car.country);

            Console.ReadLine();
        }
    }
}
