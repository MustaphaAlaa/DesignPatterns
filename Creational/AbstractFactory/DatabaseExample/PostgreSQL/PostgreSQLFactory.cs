namespace AbstractFactory.Database;

public class PostgreSQLFactory : IDatabaseFactory
{
    public IDatabaseConnection CreateConnection()
    {
        return new PostgreSQLConnection();
    }

    public IUserRepository CreateUserRepository()
    {
        return new UserRepositoryPostgreSQL();
    }
}