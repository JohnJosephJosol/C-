using System;
using System.Collections.Generic;

namespace Act2{
    public class Car{
        public string Brand { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            List<Car> list = new List<Car>();

            while (true)
            {
                Console.WriteLine("Enter new data? Y/N");

                if (Console.ReadLine().ToUpper() == "N")
                {
                    break;
                }
                Car car1 = new Car();

                Console.WriteLine("Enter Car Brand");
                car1.Brand = Console.ReadLine();


                Console.WriteLine("Enter Car Color");
                car1.Color = Console.ReadLine();


                Console.WriteLine("Enter Car Price");
                car1.Price = int.Parse(Console.ReadLine());

                list.Add(car1);

            }
            list.ForEach(x =>
            {
                Console.WriteLine(x.Brand);
                Console.WriteLine(x.Color);
                Console.WriteLine(x.Price);
                Console.WriteLine("\n=======================\n");
            });
        }
    }
}
