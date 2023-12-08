class Vehicle
{
    public string Type { get; set; }
    public int Year { get; set; }

    public Vehicle(string type, int year)
    {
        Type = type;
        Year = year;
    }

    public void Start()
    {
        Console.WriteLine($"{Type} запущен.");
    }

    public void Stop()
    {
        Console.WriteLine($"{Type} остановлен.");
    }
}

class Car : Vehicle
{
    public string Model { get; set; }

    public Car(string type, int year, string model)
        : base(type, year)
    {
        Model = model;
    }

    public void Honk()
    {
        Console.WriteLine($"{Type} сигналит.");
    }
}

class Motorcycle : Vehicle
{
    public string Brand { get; set; }

    public Motorcycle(string type, int year, string brand)
        : base(type, year)
    {
        Brand = brand;
    }

    public void Faster()
    {
        Console.WriteLine($"{Type} разгоняется.");
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car("Легковое авто", 2022, "Toyota Camry");
        myCar.Start();
        myCar.Honk();
        myCar.Stop();

        Motorcycle myMotorcycle = new Motorcycle("Мотоцикл", 2021, "Harley Davidson");
        myMotorcycle.Start();
        myMotorcycle.Faster();
        myMotorcycle.Stop();

        Console.ReadKey(true);
    }
}
