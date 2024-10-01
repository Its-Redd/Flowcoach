namespace FlowCoach.Entities
{
    public class BodyFlowArticle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<string> Content { get; set; }
        public List<string> Images { get; set; }

        public BodyFlowArticle(int id, string title, List<string> content, List<string> images)
        {
            Id = id;
            Title = title;
            Content = content;
            Images = images;
        }

    }
}
