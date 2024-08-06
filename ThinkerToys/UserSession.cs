public class UserSession
{
    private static UserSession _instance;

    public string Username { get; private set; }
    public int Coins { get; set; } // Changed setter to public


    // hashtable for the purchases (string,int = name, quantity )
    public Dictionary<string, int> Purchases { get; set; } = new Dictionary<string, int>();

    // Private constructor to prevent direct instantiation
    private UserSession() { }

    // Get the singleton instance
    public static UserSession Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new UserSession();
            }
            return _instance;
        }
    }

    // Method to initialize the session
    public void Initialize(string username, int coins)
    {
        Username = username;
        Coins = coins;
    }

    // Method to clear the session
    public void Clear()
    {
        Username = null;
        Coins = 0;
    }
}
