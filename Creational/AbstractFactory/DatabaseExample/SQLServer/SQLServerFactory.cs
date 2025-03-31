namespace AbstractFactory.Database;

public class SQLServerFactory : IDatabaseFactory
{
    public IDatabaseConnection CreateConnection()
    {
        return new SQLServerConnection();
    }

    public IUserRepository CreateUserRepository()
    {
        return new UserRepositorySQLServer();
    }
}
