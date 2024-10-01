namespace FlowCoach.Entities
{
    public class Card
    {
        private int id;
        private string image;
        private string title;

        public int Id { get => id; set => id = value; }
        public string Image { get => image; set => image = value; }
        public string Title { get => title; set => title = value; }

        public Card(int id, string image, string title)
        {
            this.id = id;
            this.image = image;
            this.title = title;
        }
    }
}
