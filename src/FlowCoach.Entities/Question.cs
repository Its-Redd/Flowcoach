namespace FlowCoach.Entities
{

    public enum QuestionCategory
    {
        Current,
        Wanted,
        Barrier,
        Solution,
        Futureproof,
        Selfcare
    }

    public class Question
    {
        private int id;
        private string questionText;
        private QuestionCategory category;
        private bool isSaveable;

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

        public string QuestionText
        {
            get => questionText;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("QuestionText cannot be null or empty.");
                }
                questionText = value;
            }
        }

        public QuestionCategory Category
        {
            get => category;
            set
            {
                if (!Enum.IsDefined(typeof(QuestionCategory), value))
                {
                    throw new ArgumentException("Invalid QuestionCategory value.");
                }
                category = value;
            }
        }

        public bool IsSaveable { get => isSaveable; set => isSaveable = value; }

        public Question(int id, string questionText, QuestionCategory category, bool isSaveable)
        {
            Id = id;
            QuestionText = questionText;
            Category = category;
            IsSaveable = isSaveable;
        }

        public Question()
        {
        }
    }

}
