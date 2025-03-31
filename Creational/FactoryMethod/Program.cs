/*
    Init:Factory Method is a creational design pattern that provides an interface for creating objects in a superclass,
         but allows subclasses to alter the type of objects that will be created.
*/




using FactoryMethod;


NotificationFactory notificationFactory;
INotification notification;

//Using Email
notificationFactory = new EmailNotificationFactory();
notification = notificationFactory.GetNotification();

notification.Notify("Hello via Email;");

//Using SMS
notificationFactory = new SmsNotificationFactory();
notification = notificationFactory.GetNotification();
notification.Notify("Hello via SMS;");


//using Instagram class

notificationFactory = new InstagramNotificationFactory();
notification = notificationFactory.GetNotification();
notification.Notify("photo is uploaded");
