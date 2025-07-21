/*
Mediator is a behavioral design pattern that lets you reduce chaotic dependencies between objects.
 The pattern restricts direct communications between the objects and forces them to collaborate only via a mediator object.
*/
 
//Components : each component  reference to the mediator interface not the class; 
//Mediator: 
//ConcreteMediator


using System;
using System.Collections.Generic;

// Mediator Interface
public interface IMediator
{
    void Notify(object sender, string eventMessage);
}

// Concrete Mediator
public class ChatRoom : IMediator
{
    private List<User> _users = new List<User>();

    public void RegisterUser(User user)
    {
        _users.Add(user);
        user.SetMediator(this);
    }

    public void Notify(object sender, string eventMessage)
    {
        foreach (var user in _users)
        {
            if (user != sender)
            {
                user.ReceiveMessage(eventMessage);
            }
        }
    }
}

// Component
public abstract class User
{
    protected IMediator _mediator;

    public void SetMediator(IMediator mediator)
    {
        _mediator = mediator;
    }

    public abstract void SendMessage(string message);
    public abstract void ReceiveMessage(string message);
}

// Concrete Component
public class ConcreteUser : User
{
    private string _name;

    public ConcreteUser(string name)
    {
        _name = name;
    }

    public override void SendMessage(string message)
    {
        Console.WriteLine($"{_name} sends: {message}");
        _mediator.Notify(this, message);
    }

    public override void ReceiveMessage(string message)
    {
        Console.WriteLine($"{_name} receives: {message}");
    }
}

// Client Code
class Program
{
    static void Main(string[] args)
    {
        ChatRoom chatRoom = new ChatRoom();

        User user1 = new ConcreteUser("Alice");
        User user2 = new ConcreteUser("Bob");
        User user3 = new ConcreteUser("Charlie");

        chatRoom.RegisterUser(user1);
        chatRoom.RegisterUser(user2);
        chatRoom.RegisterUser(user3);

        user1.SendMessage("Hello, everyone!");
        user2.SendMessage("Hi Alice!");
        user3.SendMessage("Hey folks!");
    }
}