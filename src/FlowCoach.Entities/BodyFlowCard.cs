namespace FlowCoach.Entities
{
    public class BodyFlowCard : Card
    {
        private int bodyflowArticleId;

        public int BodyflowArticleId { get => bodyflowArticleId; set => bodyflowArticleId = value; }

        public BodyFlowCard(int id, string image, string title, int bodyflowArticleId) : base(id, image, title)
        {
            BodyflowArticleId = bodyflowArticleId;
        }
    }
}
