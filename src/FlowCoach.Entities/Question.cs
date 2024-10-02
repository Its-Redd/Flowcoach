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

        public int Id { get => id; set => id = value; }
        public string QuestionText { get => questionText; set => questionText = value; }
        public QuestionCategory Category { get => category; set => category = value; }
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
