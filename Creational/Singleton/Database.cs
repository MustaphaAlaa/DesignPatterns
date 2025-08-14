namespace SingletonDP;

public sealed class Database
{
    private static Database _instance;
    private static readonly object _lock = new object();

    private Database()
    {

    }

    public static Database getInstance()
    {
        if (_instance == null)
        {
            _instance = new Database();

        }
        return _instance;
    }
    
     
}