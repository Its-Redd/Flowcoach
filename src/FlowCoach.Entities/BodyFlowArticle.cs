namespace FlowCoach.Entities
{
    public class BodyFlowArticle
    {
        private int id;
        private string title;
        private List<string> content;
        private List<string> images;

        public int Id
        {
            get => id;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Id must be a positive integer.");
                }
                id = value;
            }
        }

        public string Title
        {
            get => title;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
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
                if (value == null || value.Count == 0)
                {
                    throw new ArgumentException("Content cannot be null or empty.");
                }
                content = value;
            }
        }

        public List<string> Images
        {
            get => images;
            set
            {
                if (value == null || value.Count == 0)
                {
                    throw new ArgumentException("Images cannot be null or empty.");
                }

                images = value;
            }
        }

        public BodyFlowArticle(int id, string title, List<string> content, List<string> images)
        {
            Id = id;
            Title = title;
            Content = content;
            Images = images;
        }

        public BodyFlowArticle()
        {
        }
    }
}
