using System.Reflection.Metadata.Ecma335;

namespace AbstractFactory.Database;

public interface IDatabaseFactory
{
    IDatabaseConnection CreateConnection();
    IUserRepository CreateUserRepository();
}
