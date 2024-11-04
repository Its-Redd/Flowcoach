namespace FlowCoach.Entities
{
    public class JournalEntry
    {
        private int id;
        private Question question;
        private string answer;
        private DateOnly date;

        public int Id
        {
            get => id;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Id must be a non-negative value.");
                }
                id = value;
            }
        }

        public Question Question
        {
            get => question;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Question cannot be null.");
                }
                question = value;
            }
        }

        public string Answer
        {
            get => answer;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Answer cannot be null or empty.");
                }

                answer = value;
            }
        }

        public DateOnly Date
        {
            get => date;
            set
            {
                if (value == default)
                {
                    throw new ArgumentException("Date cannot be the default value.");
                }
                if (value > DateOnly.FromDateTime(DateTime.Now))
                {
                    throw new ArgumentException("Date cannot be in the future.");
                }
                date = value;
            }
        }

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
