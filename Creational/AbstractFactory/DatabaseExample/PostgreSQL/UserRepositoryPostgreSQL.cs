namespace AbstractFactory.Database;

public class UserRepositoryPostgreSQL : IUserRepository
{
    public void AddUser(User user)
    {
        System.Console.WriteLine($"\t\t{user}");
        System.Console.WriteLine($"\t\t\tAdded in PostgreSQL");
    }
}
