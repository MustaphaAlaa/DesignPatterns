namespace AbstractFactory.Database;

public class MySqlFactory : IDatabaseFactory
{
    public IDatabaseConnection CreateConnection()
    {
        return new MySqlConnection();
    }

    public IUserRepository CreateUserRepository()
    {
        return new UserRepositoryMySql();
    }
}