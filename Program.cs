using System;

class Planet
{
    public string Name;
    public string StarSystem;
    public double Mass; 
    public double Diameter; 
    public double DistanceFromSun; 
    public bool HasLife;
    public int NumberOfMoons;
    public double OrbitalPeriod; 

    public double GetDensity()
    {
        double volume = (4.0 / 3.0) * Math.PI * Math.Pow(Diameter / 2, 3); 
        double earthMassInKg = 5.972e24;
        double massInKg = Mass * earthMassInKg;
        double volumeInM3 = volume * 1e9; 
        return massInKg / volumeInM3; 
    }
}

class Program
{
    static void Main(string[] args)
    {
        Planet myPlanet = new Planet();

        Console.Write("Введіть назву планети: ");
        myPlanet.Name = Console.ReadLine();

        Console.Write("Введіть назву зоряної системи: ");
        myPlanet.StarSystem = Console.ReadLine();

        Console.Write("Введіть масу планети (у земних масах): ");
        myPlanet.Mass = double.Parse(Console.ReadLine());

        Console.Write("Введіть діаметр планети (у км): ");
        myPlanet.Diameter = double.Parse(Console.ReadLine());

        Console.Write("Введіть відстань до зірки (у млн км): ");
        myPlanet.DistanceFromSun = double.Parse(Console.ReadLine());

        Console.Write("Чи є життя на планеті? (y/n): ");
        myPlanet.HasLife = Console.ReadKey().Key == ConsoleKey.Y;
        Console.WriteLine();

        Console.Write("Скільки супутників має планета? ");
        myPlanet.NumberOfMoons = int.Parse(Console.ReadLine());

        Console.Write("Введіть орбітальний період (в земних роках): ");
        myPlanet.OrbitalPeriod = double.Parse(Console.ReadLine());

        double density = myPlanet.GetDensity();

        Console.WriteLine("\n--- Інформація про планету ---");
        Console.WriteLine($"Назва: {myPlanet.Name}");
        Console.WriteLine($"Зоряна система: {myPlanet.StarSystem}");
        Console.WriteLine($"Маса: {myPlanet.Mass} земних мас");
        Console.WriteLine($"Діаметр: {myPlanet.Diameter} км");
        Console.WriteLine($"Відстань до зірки: {myPlanet.DistanceFromSun} млн км");
        Console.WriteLine($"Життя: {(myPlanet.HasLife ? "так" : "ні")}");
        Console.WriteLine($"Кількість супутників: {myPlanet.NumberOfMoons}");
        Console.WriteLine($"Орбітальний період: {myPlanet.OrbitalPeriod} років");
        Console.WriteLine($"Середня густина: {density:F2} кг/м³");

        Console.ReadKey();
    }
}
