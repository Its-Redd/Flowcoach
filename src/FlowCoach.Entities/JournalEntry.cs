namespace FlowCoach.Entities
{
    public class JournalEntry
    {
        private int id;
        private Question question;
        private string answer;
        private DateOnly date;

        public int Id { get => id; set => id = value; }
        public Question Question { get => question; set => question = value; }
        public string Answer { get => answer; set => answer = value; }
        public DateOnly Date { get => date; set => date = value; }

        public JournalEntry(int id, Question question, string answer, DateOnly date)
        {
            Id = id;
            Question = question;
            Answer = answer;
            Date = date;
        }

        public JournalEntry()
        {
        }
    }
}
