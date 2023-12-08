public class Package
{
    public string Description { get; set; } 
    public double Weight { get; set; }      

    public Package(string description, double weight)
    {
        Description = description;
        Weight = weight;
    }
}

public class ShippingService
{
    private double weightLimit; 
    private double totalWeight; 

    public double WeightLimit
    {
        get { return weightLimit; }
        set { weightLimit = value; }
    }

    public ShippingService(double weightLimit)
    {
        WeightLimit = weightLimit;
        totalWeight = 0; 
    }

    public void SendPackage(Package package)
    {
        if (totalWeight + package.Weight > weightLimit)
        {
            Console.WriteLine("Ошибка: Превышен лимит веса отправленных посылок. Пожалуйста, проверьте вес посылки!");
            return; 
        }
        else { 
        Console.WriteLine($"Посылка успешно отправлена: {package.Description}, Вес: {package.Weight} кг");

        totalWeight += package.Weight;
        }
    }
}

class Program
{
    static void Main()
    {
        ShippingService shippingService = new ShippingService(10);

        Package firstPackage = new Package("Комплектубщие", 5);
        Package secendoryPackage = new Package("Книги", 1);
        Package thirdPackage = new Package("Посуда", 3);

        shippingService.SendPackage(firstPackage);
        shippingService.SendPackage(secendoryPackage);
        shippingService.SendPackage(thirdPackage);

        Package overweightPackage = new Package("Что-то тяжелое", 12);
        shippingService.SendPackage(overweightPackage);

        Console.ReadLine();
    }
}
