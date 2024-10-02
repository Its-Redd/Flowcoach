namespace FlowCoach.Entities
{
    public class BodyFlowArticle
    {
        private int id;
        private string title;
        private List<string> content;
        private List<string> images;

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public List<string> Content { get => content; set => content = value; }
        public List<string> Images { get => images; set => images = value; }

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
