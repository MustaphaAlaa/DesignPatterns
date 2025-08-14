


using SingletonDP;



var s1 = Database.getInstance();
var s2 = Database.getInstance();

if(s1 == s2)
System.Console.WriteLine("Singleton works");