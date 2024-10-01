namespace FlowCoach.Entities
{
    public class FlowcoachCard : Card
    {
        private string description;
        private string path;

        public string Description { get => description; set => description = value; }
        public string Path { get => path; set => path = value; }

        public FlowcoachCard(int id, string image, string title, string description, string path) : base(id, image, title)
        {
            Description = description;
            Path = path;
        }
    }
}
