namespace FlowCoach.Entities
{
    public class FlowcoachCard : Card
    {
        private string description;
        private string path;

        public string Description
        {
            get => description;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(Description), "Description cannot be null.");
                }
                description = value;
            }
        }

        public string Path
        {
            get => path;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(Path), "Path cannot be null.");
                }
                path = value;
            }
        }

        public FlowcoachCard(int id, string image, string title, string description, string path) : base(id, image, title)
        {
            Description = description;
            Path = path;
        }

        public FlowcoachCard() : base(0, "", "")
        {
        }
    }
}
