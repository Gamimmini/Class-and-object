using System;
namespace ClassFan
{
    class Program
    {
        static void Main(string[] args)
        {
            Fan fan1 = new Fan()
            {
                Speed = Fan.FAST,
                Radius = 10,
                Color = "yellow",
                On = true
            };

            Fan fan2 = new Fan()
            {
                Speed = Fan.MEDIUM,
                Radius = 5,
                Color = "blue",
                On = false
            };

            Console.WriteLine(fan1.GetFanInfo());
            Console.WriteLine(fan2.GetFanInfo());
        }
    }
}