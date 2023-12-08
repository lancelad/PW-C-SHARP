class Orc
{
    private static int totalGold = 0; 
    private int GoldPreOrc = 2; 

    public int Gold { get; private set; } 

    public Orc()
    {
        Gold = GoldPreOrc;
        totalGold += GoldPreOrc;

        if (totalGold > 5 * GoldPreOrc)
        {
            Gold -= 2;
            totalGold -= 2;
        }
    }

    public static int GetTotalGold()
    {
        return totalGold;
    }
}

class Program
{
    static void Main()
    {
        Orc firstOrc = new Orc();
        Orc secendOrc = new Orc();
        Orc thirdOrc = new Orc();
        Orc fourthOrc = new Orc();
        Orc fifthOrc = new Orc();
        Orc sixThorc = new Orc(); 

        Console.WriteLine($"Первый орк: {firstOrc.Gold} золота");
        Console.WriteLine($"Второй орк: {secendOrc.Gold} золота");
        Console.WriteLine($"Третий орк: {thirdOrc.Gold} золота");
        Console.WriteLine($"Четвертый орк: {fourthOrc.Gold} золота");
        Console.WriteLine($"Пятый орк: {fifthOrc.Gold} золота");
        Console.WriteLine($"Шестой орк: {sixThorc.Gold} золота");
        Console.WriteLine($"Общее количество золота у орков: {Orc.GetTotalGold()}");

        Console.ReadKey(true);
    }
}
