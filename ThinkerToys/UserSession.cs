public class UserSession
{
    private static UserSession _instance;

    public string Username { get; set; }  // Changed from private set to public set
    public int Coins { get; set; }
    public string Email { get; private set; }
    public string ID { get; private set; }
    public DateTime SignupDate { get; private set; }
    public string Gender { get; private set; }
    public Dictionary<string, int> Purchases { get; set; } = new Dictionary<string, int>();
    public int UnlockedHebrewLevels { get; set; }

    private UserSession() { }

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

    public void Initialize(string username, int coins, string email, string id, DateTime signupDate, string gender)
    {
        Username = username;
        Coins = coins;
        Email = email;
        ID = id;
        SignupDate = signupDate;
        Gender = gender;
    }

    public void Clear()
    {
        Username = null;
        Coins = 0;
        Email = null;
        ID = null;
        SignupDate = DateTime.MinValue;
        Gender = null;
        Purchases.Clear();
        UnlockedHebrewLevels = 0;
    }
}