namespace ClassLibTime;

public class UserData
{
    public string userId { get; set; }
    public string nickname { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public DateTime registrationDate { get; set; }
    public DateTime? lastSeenDate { get; set; }
    public bool isOnline { get; set; }
    
}