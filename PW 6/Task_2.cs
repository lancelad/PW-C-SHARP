class Vehicle
{
    public string Name { get; set; }
    public int MaxSpeed { get; set; }

    public Vehicle(string name, int maxSpeed)
    {
        Name = name;
        MaxSpeed = maxSpeed;
    }
}

class PolytechCar : Vehicle 
{
    public PolytechCar(string name, int maxSpeed) : base(name, maxSpeed)
    {
    }

    public void PlayBadMusic()
    {
        Console.WriteLine($"{Name} включает громкую и плохую музыку.");
    }
}

class Airplane : Vehicle
{
    public Airplane(string name, int maxSpeed) : base(name, maxSpeed)
    {
    }

    public void PollinateField()
    {
        Console.WriteLine($"{Name} опыляет поле.");
    }
}

class ConcreteMixer : Vehicle
{
    public ConcreteMixer(string name, int maxSpeed) : base(name, maxSpeed)
    {
    }

    public void MixConcrete()
    {
        Console.WriteLine($"{Name} мешает бетон.");
    }
}

class Program
{
    static void Main()
    {
        PolytechCar polytechCar = new PolytechCar("Политех-машина", 120);
        Airplane airplane = new Airplane("Самолёт", 800);
        ConcreteMixer concreteMixer = new ConcreteMixer("Бетономешалка", 40);

        polytechCar.PlayBadMusic();
        airplane.PollinateField();
        concreteMixer.MixConcrete();

        Console.ReadKey(true);
    }
}
