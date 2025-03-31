namespace AbstractFactory.Database;

public class UserRepositoryMySql : IUserRepository
{
    public void AddUser(User user)
    {
        System.Console.WriteLine($"\t\t{user}");
        System.Console.WriteLine($"\t\t\tAdded in MySql");
    }
}
