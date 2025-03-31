namespace AbstractFactory.Database;

public class User
{
    public string Name { get; set; }
    public string Email { get; set; }

    public override string ToString()
    => $"Username: {Name}, Email: {Email}";
}
