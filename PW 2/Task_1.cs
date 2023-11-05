class QuadraticEquation
{
    private double firstValue;
    private double secondValue;
    private double thirdValue;
    private double discriminant;
    private double firstRoot;
    private double secondRoot;

    public QuadraticEquation(double firstValue, double secondValue, double thirdValue)
    {
        this.firstValue = firstValue;
        this.secondValue = secondValue;
        this.thirdValue = thirdValue;
    }

    private void CalculateDiscriminant()
    {
        discriminant = (secondValue * secondValue) - 4 * firstValue * thirdValue;
    }

    public void CalculateRoots()
    {
        CalculateDiscriminant();

        if (discriminant > 0)
        {
            firstRoot = (-secondValue + Math.Sqrt(discriminant)) / (2 * firstValue);
            secondRoot = (-secondValue - Math.Sqrt(discriminant)) / (2 * firstValue);
            Console.WriteLine("Корни уравнения: {0}, {1}", firstRoot, secondRoot);
        }
        else if (discriminant == 0)
        {
            firstRoot = -secondValue / (2 * firstValue);
            Console.WriteLine("Уравнение имеет корень: {0}", firstRoot);
        }
        else
        {
            Console.WriteLine("Уравнение не имеет корней.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите коэффициенты уравнения:");
        double firstValue = double.Parse(Console.ReadLine());
        double secondValue = double.Parse(Console.ReadLine());
        double thirdValue = double.Parse(Console.ReadLine());

        QuadraticEquation Solution = new QuadraticEquation(firstValue, secondValue, thirdValue);
        Solution.CalculateRoots();

        Console.ReadKey(true);
    }
}