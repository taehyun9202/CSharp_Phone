using System;
using Phone.Models;
using Phone.Interfaces;
namespace Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            IPhone iphone8 = new IPhone("iPhone 8",80 ,"T-Mobile", "Bring a ding ring ring");
            Console.WriteLine(iphone8.Ring());
            Console.WriteLine(iphone8.Snap());
            Console.WriteLine(iphone8.Unlock());
            Console.WriteLine(iphone8.Ring());
            Console.WriteLine(iphone8.Ring());
            Console.WriteLine(iphone8.Ring());
            Console.WriteLine(iphone8.Ring());
            Console.WriteLine(iphone8.Ring());
            Console.WriteLine(iphone8.Ring());
            Console.WriteLine(iphone8.Ring());

            Console.WriteLine(iphone8.BatteryPercentage);
            Console.WriteLine(iphone8.Charge());
            Console.WriteLine(iphone8.Charge());
            Console.WriteLine(iphone8.Charge());
            Console.WriteLine(iphone8.Charge());
            Console.WriteLine(iphone8.Charge());
            Console.WriteLine(iphone8.Charge());
            Console.WriteLine(iphone8.Charge());
            Console.WriteLine(iphone8.Charge());
            Console.WriteLine(iphone8.Charge());
            Console.WriteLine(iphone8.Charge());
            Console.WriteLine(iphone8.Charge());
            Console.WriteLine(iphone8.Charge());
            Phone Samsung = new Phone("Galaxy 9", 100, "AT&T", "BEEEEEEEEAAP");
            List<IRingable> rings = new List<IRingable>();
            rings.Add(iphone8);
        }
    }
}
