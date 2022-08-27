using System;

namespace Autoinspection
{
    class Program
    {
        static void Main()
        {
            Car[] cars = new Car[5];
            cars[0] = new Car("Mercedes-Benz", "AMG GT", 2020, 2020);
            cars[1] = new Car("Audi", "R8", 2018, 2021);
            cars[2] = new Car("Toyota", "Mirai", 2019, 2021);
            cars[3] = new Car("BMW", "i8", 2017, 2022);
            cars[4] = new Car("Mercedes-Benz", "E-Klasse", 2019, 2022);

            Console.WriteLine("Bitte geben Sie einen Suchbegriff ein:");
            string searchTerm = Console.ReadLine();
            Console.WriteLine("Ihr Suchbegriff lautet: " + searchTerm);
            Console.WriteLine("Folgende Autos wurden gefunden: ");

            foreach(Car car in cars)
            {
                if (car.carName.Contains(searchTerm))
                {
                    Console.WriteLine(car.carName + " " + car.carModel + " Baujahr: " + car.constructionYear +
                        "Letzte Inspection: " + car.lastInspectionYear);
                    car.Inspect();
                    Console.WriteLine("Neues Inspektionsjahr: " + car.lastInspectionYear);
                }
            }

            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
