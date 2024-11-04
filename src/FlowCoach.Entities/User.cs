namespace FlowCoach.Entities
{
    public class User
    {
        private int id;
        private string fullName;
        private string email;
        private string password;
        private List<JournalEntry> journalEntries;

        public int Id
        {
            get => id;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Id cannot be negative.");
                }
                id = value;
            }
        }

        public string FullName
        {
            get => fullName;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("FullName cannot be null or empty.");
                }
                fullName = value;
            }
        }

        public string Email
        {
            get => email;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Email cannot be null or empty.");
                }
                email = value;
            }
        }

        public string Password
        {
            get => password;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Password cannot be null or empty.");
                }
                password = value;
            }
        }

        public List<JournalEntry> JournalEntries { get => journalEntries; set => journalEntries = value; }

        public User(int id, string fullName, string email, string password, List<JournalEntry> journalEntries)
        {
            Id = id;
            FullName = fullName;
            Email = email;
            Password = password;
            JournalEntries = journalEntries;
        }

        public User()
        {
        }
    }
}