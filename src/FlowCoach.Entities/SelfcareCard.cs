namespace FlowCoach.Entities
{
    public class SelfcareCard : Card
    {
        private SelfCareArticle selfCareArticle;

        public SelfCareArticle SelfCareArticle
        {
            get => selfCareArticle;
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("SelfCareArticle cannot be null.");
                }
                selfCareArticle = value;
            }
        }

        public SelfcareCard(int id, string image, string title, SelfCareArticle selfCareArticle) : base(id, image, title)
        {
            SelfCareArticle = selfCareArticle;
        }

        public SelfcareCard() : base(0, "", "")
        {
        }
    }
}
