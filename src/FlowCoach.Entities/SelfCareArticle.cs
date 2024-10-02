namespace FlowCoach.Entities
{
    public class SelfCareArticle
    {
        private int id;
        private List<string> content;
        private string soundFile;
        private List<Question> question;

        public int Id { get => id; set => id = value; }
        public List<string> Content { get => content; set => content = value; }
        public string SoundFile { get => soundFile; set => soundFile = value; }
        public List<Question> Question { get => question; set => question = value; }

        public SelfCareArticle(int id, List<string> content, string soundFile, List<Question> question)
        {
            Id = id;
            Content = content;
            SoundFile = soundFile;
            Question = question;
        }

        public SelfCareArticle()
        {
        }
    }
}
