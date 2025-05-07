using System;
using PlanetLib;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Скільки планет ви хочете ввести? ");
        int count = int.Parse(Console.ReadLine());
        Planet[] planets = new Planet[count];

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"\n--- Планета #{i + 1} ---");
            Planet p = new Planet();

            Console.Write("Назва планети: ");
            p.Name = Console.ReadLine();

            Console.Write("Назва зоряної системи: ");
            p.StarSystem = Console.ReadLine();

            Console.Write("Маса (у земних масах): ");
            p.Mass = double.Parse(Console.ReadLine());

            Console.Write("Діаметр (у км): ");
            p.Diameter = double.Parse(Console.ReadLine());

            Console.Write("Відстань до зірки (у млн км): ");
            p.DistanceFromSun = double.Parse(Console.ReadLine());

            Console.Write("Чи є життя на планеті? (введіть 'і' для так): ");
            p.HasLife = Console.ReadKey().KeyChar == 'і';
            Console.WriteLine();

            Console.Write("Кількість супутників: ");
            p.NumberOfMoons = int.Parse(Console.ReadLine());

            Console.Write("Орбітальний період (в земних роках): ");
            p.OrbitalPeriod = double.Parse(Console.ReadLine());

            planets[i] = p;
        }

        Console.WriteLine("\n=== Інформація про планети ===");
        foreach (Planet p in planets)
        {
            Console.WriteLine($"\n--- {p.Name} ---");
            Console.WriteLine($"Зоряна система: {p.StarSystem}");
            Console.WriteLine($"Маса: {p.Mass} земних мас");
            Console.WriteLine($"Діаметр: {p.Diameter} км");
            Console.WriteLine($"Відстань: {p.DistanceFromSun} млн км");
            Console.WriteLine($"Життя: {(p.HasLife ? "так" : "ні")}");
            Console.WriteLine($"Супутники: {p.NumberOfMoons}");
            Console.WriteLine($"Орбітальний період: {p.OrbitalPeriod} років");
            Console.WriteLine($"Густина: {p.Density:F2} кг/м³");
        }

        Console.ReadKey();
    }
}