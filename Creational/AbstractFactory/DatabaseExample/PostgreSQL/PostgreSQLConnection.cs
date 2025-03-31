namespace AbstractFactory.Database;

public class PostgreSQLConnection : IDatabaseConnection
{
    public void Open()
    {
        System.Console.WriteLine("PostgreSQL connection opened.");
    }
}
