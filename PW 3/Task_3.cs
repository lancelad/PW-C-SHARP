public class SQLCommand
{
    private string commandText;

    public string CommandText
    {
        get { return commandText; }
        set { commandText = value.ToUpper(); }
    }
}

class Program
{
    static void Main()
    {
        SQLCommand sqlCommand = new SQLCommand();

        sqlCommand.CommandText = "select * from tables";
        Console.WriteLine(sqlCommand.CommandText);
        Console.ReadKey();
    }
}
