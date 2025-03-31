//Init: Observer is a behavioral design pattern that lets you define a subscription mechanism to notify multiple objects
// about any events that happen to the object they’re observing.

//The Observer pattern suggests that you add a subscription mechanism to the publisher class
//  so individual objects can subscribe to or unsubscribe from a stream of events coming from that publisher.

//!!! The Example is very Simple and not very useful, but it shows the concept of Observer Pattern

using Observer;

YoutubeChannel channel = new YoutubeChannel("Khan Academy");
channel.AddVideo("Liner Algebra");

User user1 = new User{Email = "User1@gmail.com"};
User user2 = new User{Email = "SoloUser@gmail.com"};
User user3 = new User{Email = "Metaverse@gmail.com"};

channel.Subscribe(user1);
channel.Subscribe(user2);

channel.AddVideo("Calculus");

channel.Unsubscribe(user1);
channel.Unsubscribe(user2);


channel.Subscribe(user3);



channel.AddVideo("Database Internals");




channel = new("Design Patterns Channel");

System.Console.WriteLine("\n\n");

channel.Subscribe(user1);
channel.Subscribe(user2);
channel.Subscribe(user3);

System.Console.WriteLine("\n\n");
channel.AddVideo("Observer Pattern");

System.Console.WriteLine("\n\n");
channel.AddVideo("Strategy");

System.Console.WriteLine("\n\n");
channel.AddVideo("Factory Method");