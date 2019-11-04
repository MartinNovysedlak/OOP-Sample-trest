using System;

namespace CarShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop(); 
            Console.WriteLine("You can buy");
            foreach (var car in shop.Cars)
            {
               
                Console.WriteLine($"{car.Brand}, {car.Type}, {car.Color}, {car.Power}");
            }
            
        }
    }
}
