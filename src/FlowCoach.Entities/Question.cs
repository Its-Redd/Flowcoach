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
        private string question;
        private QuestionCategory category;
        private bool isSaveable;
    }
}
