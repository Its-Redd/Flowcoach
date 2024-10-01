namespace FlowCoach.Entities
{
    public class EmotionCard : Card
    {
        private int coachId;
        public int CoachId { get => coachId; set => coachId = value; }
        public EmotionCard(int id, string image, string title, int coachId) : base(id, image, title)
        {
            CoachId = coachId;
        }
    }
}
