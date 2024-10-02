namespace FlowCoach.Entities
{
    public class SelfcareCard : Card
    {
        private int selfcareArticleId;

        public int SelfcareArticleId { get => selfcareArticleId; set => selfcareArticleId = value; }

        public SelfcareCard(int id, string image, string title, int selfcareArticleId) : base(id, image, title)
        {
            SelfcareArticleId = selfcareArticleId;
        }

        public SelfcareCard() : base(0, "", "")
        {
        }
    }
}
