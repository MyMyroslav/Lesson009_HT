using System;

namespace Lesson009_HT
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Address address1 = new Address();
            address1.Country = "Ukraine";
            address1.Index = 14235;
            address1.Street = "Lvivska";
            address1.House = 2;
            address1.Apartment = 36;
            Console.WriteLine($"{address1.Country}, {address1.Index}, {address1.Street}, {address1.House}, {address1.Apartment}");
        }
    }
}
