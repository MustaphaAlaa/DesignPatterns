/*
Intent
    Abstract Factory is a creational design pattern that
        lets you produce families of related objects without specifying their concrete classes.
*/


using AbstractFactory;
using AbstractFactory.Database;

IDatabaseFactory database;

Console.WriteLine("Choose Your Database");
Console.WriteLine("\t\t1: SQLServer");
Console.WriteLine("\t\t2: PostgreSQL (default)");
Console.WriteLine("\t\t3: MySQL");

string? option = Console.ReadLine()?.Trim();
DatabaseClientCode dbClient;
switch (option)
{
    case "1":
        database = new SQLServerFactory();
        dbClient = new(database);
        break;
    case "3":
        database = new MySqlFactory();
        dbClient = new(database);
        break;
    default:
        database = new PostgreSQLFactory();
        dbClient = new(database);
        break;

}

User user = new() { Name = "John Doe", Email = "john@example.com" };

dbClient.Run(user);

