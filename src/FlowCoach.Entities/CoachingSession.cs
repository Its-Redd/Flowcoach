namespace FlowCoach.Entities
{
    public class CoachingSession
    {
        private int id;
        private string title;
        private List<string> content;
        private List<Question> questions;

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

        public string Title
        {
            get => title;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Title cannot be null or empty.");
                }
                title = value;
            }
        }

        public List<string> Content
        {
            get => content;
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Content cannot be null.");
                }
                content = value;
            }
        }

        public List<Question> Questions
        {
            get => questions;
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Questions cannot be null.");
                }
                questions = value;
            }
        }

        public CoachingSession(int id, string title, List<string> content, List<Question> questions)
        {
            Id = id;
            Title = title;
            Content = content;
            Questions = questions;
        }

        public CoachingSession()
        {
        }
    }
}
