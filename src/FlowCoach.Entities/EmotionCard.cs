namespace FlowCoach.Entities
{
    public class EmotionCard : Card
    {
        private CoachingSession coachingSession;

        public CoachingSession CoachingSession { get => coachingSession; set => coachingSession = value; }

        public EmotionCard(int id, string image, string title, CoachingSession coachingSession) : base(id, image, title)
        {
            CoachingSession = coachingSession;
        }

        public EmotionCard() : base(0, "", "")
        {
        }
    }
}
