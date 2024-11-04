namespace FlowCoach.Entities
{
    public class BodyFlowCard : Card
    {
        private BodyFlowArticle bodyFlowArticle;

        public BodyFlowArticle BodyFlowArticle
        {
            get => bodyFlowArticle;
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("BodyFlowArticle cannot be null.");
                }
                bodyFlowArticle = value;
            }
        }

        public BodyFlowCard(int id, string image, string title, BodyFlowArticle bodyFlowArticle) : base(id, image, title)
        {
            BodyFlowArticle = bodyFlowArticle;
        }

        public BodyFlowCard() : base(0, "", "")
        {
        }
    }
}
