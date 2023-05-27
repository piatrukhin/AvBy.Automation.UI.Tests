namespace AvBy.Automation.Common.Configuration.Models
{
    public class User
    {
        public User(int setId, string phoneNumber, string password)
        {
            SetId = setId;
            PhoneNumber = phoneNumber;
            Password = password;
        }

        public User(int setId, string phoneNumber, string eMail, string password)
        {
            SetId = setId;
            PhoneNumber = phoneNumber;
            EMail = eMail;
            Password = password;
        }

        public int SetId { get; set; }
        public string PhoneNumber { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
    }
}
