namespace FlowCoach.Entities
{
    public class CoachingSession
    {
        private int id;
        private string title;
        private List<string> content;
        private List<Question> questions;

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public List<string> Content { get => content; set => content = value; }
        public List<Question> Questions { get => questions; set => questions = value; }

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
