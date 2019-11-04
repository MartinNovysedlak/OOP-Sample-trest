using System;
using System.Collections.Generic;
using System.Text;

namespace CarShop
{
    class Car
    {
        public Car (string brand, string type, string color, int power)
        {
            Brand = brand;
            Type = type;
            Color = color;
            Power = power;
        }
        public string Brand { get; }
        public string Type { get; }
        public string Color { get; }
        public int Power { get; }
    }
}
