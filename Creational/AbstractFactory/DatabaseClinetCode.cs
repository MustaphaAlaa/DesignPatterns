using System.Data;
using AbstractFactory.Database;

namespace AbstractFactory;

public class DatabaseClientCode
{
    private readonly IDatabaseConnection _dbConnection;
    private readonly IUserRepository _userRepository;

    public DatabaseClientCode(IDatabaseFactory factory)
    {
        _dbConnection = factory.CreateConnection();
        _userRepository = factory.CreateUserRepository();
    }


    public void Run(User user)
    {
        this._dbConnection.Open();
        this._userRepository.AddUser(user);
    }
}