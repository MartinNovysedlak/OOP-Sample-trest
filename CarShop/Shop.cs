using System;
using System.Collections.Generic;
using System.Text;

namespace CarShop
{
    class Shop
    {
        public List<Car> Cars;

        public Shop()
        {
            Cars = new List<Car>
            {
                new Car("Nisan", "sedan", "black", 50),
                new Car("Citroen", "coupe", "white", 68),
                new Car("Porsche", "supercar", "red", 134),
                new Car("Ford", "pickup", "black", 92)
            };
        }
    }
}
