class MyIntList
{
    private List<int> numbersList = new List<int>();
    public List<int> NumbersList
    {
        get { return numbersList; }
    }

    public double Average
    {
        get
        {
            return CalculateAverage();
        }
    }
    public void AddNubmer(int number)
    {
        numbersList.Add(number);
    }
    public void RemoveNumber(int number)
    {
        numbersList.Remove(number);
    }
    private double CalculateAverage()
    {
        int sum = 0;

        foreach (var number in numbersList)
        {
            sum += number;
        }
        return sum / (double)numbersList.Count;
    }

}
class Program
{
    static void Main()
    {
        MyIntList numbers = new MyIntList();
        numbers.AddNubmer(1);
        numbers.AddNubmer(2);
        numbers.AddNubmer(8);

        Console.WriteLine(numbers.Average);

        Console.ReadKey();
    }
}