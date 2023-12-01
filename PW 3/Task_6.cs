public class RandomNumberGenerator
{
    private List<double> numbers;
    private bool isCached;

    public RandomNumberGenerator()
    {
        numbers = new List<double>();
        isCached = false;
    }

    public void GenerateRandomNumbers(int length)
    {
        Random random = new Random();

        numbers.Clear();
        for (int i = 0; i < length; i++)
        {
            numbers.Add(random.NextDouble());
        }

        isCached = false;
    }

    public double GetVariance()
    {
        if (!isCached)
            CacheStatistics();

        double mean = numbers.Average();
        double variance = numbers.Sum(num => Math.Pow(num - mean, 2)) / numbers.Count;

        return variance;
    }

    public double GetStandardDeviation()
    {
        if (!isCached)
            CacheStatistics();

        double variance = GetVariance();
        double standardDeviation = Math.Sqrt(variance);

        return standardDeviation;
    }

    public double GetMedian()
    {
        if (!isCached)
            CacheStatistics();

        List<double> sortedNumbers = numbers.OrderBy(n => n).ToList();
        int middle = sortedNumbers.Count / 2;
        double median = (sortedNumbers.Count % 2 == 0)
            ? (sortedNumbers[middle - 1] + sortedNumbers[middle]) / 2
            : sortedNumbers[middle];

        return median;
    }

    private void CacheStatistics()
    {
        GetVariance();
        GetStandardDeviation();
        GetMedian();

        isCached = true;
    }
}

class Program
{
    static void Main()
    {
        RandomNumberGenerator rng = new RandomNumberGenerator();

        rng.GenerateRandomNumbers(1000);

        Console.WriteLine($"Variance: {rng.GetVariance()}");
        Console.WriteLine($"Standard Deviation: {rng.GetStandardDeviation()}");
        Console.WriteLine($"Median: {rng.GetMedian()}");

        Console.ReadKey();
    }
}
