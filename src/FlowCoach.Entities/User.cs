namespace FlowCoach.Entities
{
    public class User
    {
        private int id;
        private string fullName;
        private string email;
        private string password;
        private List<JournalEntry> journalEntries;

        public int Id { get => id; set => id = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
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