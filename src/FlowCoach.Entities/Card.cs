namespace FlowCoach.Entities
{
    public class Card
    {
        private int id;
        private string image;
        private string title;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Id must be a positive integer.");
                }
                id = value;

            }
        }

        public string Image
        {
            get
            {
                return image;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Image cannot be null or empty.");
                }
                image = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Title cannot be null or empty.");
                }
            }
        }

        public Card(int id, string image, string title)
        {
            Id = id;
            Image = image;
            Title = title;
        }

        public Card()
        {
        }
    }
}
