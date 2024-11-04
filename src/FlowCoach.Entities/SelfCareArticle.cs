namespace FlowCoach.Entities
{
    public class SelfCareArticle
    {
        private int id;
        private List<string> content;
        private string soundFile;
        private List<Question> question;

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

        public List<string> Content
        {
            get => content;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Content cannot be null.");
                }
                content = value;
            }
        }

        public string SoundFile
        {
            get => soundFile;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("SoundFile cannot be null or empty.");
                }
                soundFile = value;
            }
        }

        public List<Question> Question
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
