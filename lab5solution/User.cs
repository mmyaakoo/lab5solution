// Class representing a user
class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public List<string> PurchaseHistory { get; set; }

    public User(string username, string password)
    {
        Username = username;
        Password = password;
        PurchaseHistory = new List<string>();
    }
}