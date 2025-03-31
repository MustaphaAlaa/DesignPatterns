namespace AbstractFactory.Database;

public class MySqlConnection : IDatabaseConnection
{
    public void Open()
    {
        System.Console.WriteLine("MySql connection opened.");
    }
}
