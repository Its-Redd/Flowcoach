namespace FlowCoach.Entities
{
    public class EmotionCard : Card
    {
        private CoachingSession coachingSession;

        public CoachingSession CoachingSession
        {
            get => coachingSession;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "CoachingSession cannot be null.");
                }
                coachingSession = value;
            }
        }

        public EmotionCard(int id, string image, string title, CoachingSession coachingSession) : base(id, image, title)
        {
            CoachingSession = coachingSession;
        }

        public EmotionCard() : base(0, "", "")
        {
        }
    }
}
