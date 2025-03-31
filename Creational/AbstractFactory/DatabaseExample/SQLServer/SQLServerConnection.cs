namespace AbstractFactory.Database;

public class SQLServerConnection : IDatabaseConnection
{
    public void Open()
    {
        System.Console.WriteLine("SQLServer connection opened.");
    }
}
