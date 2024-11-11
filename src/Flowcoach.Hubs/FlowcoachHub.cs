using FlowCoach.Entities;
using Microsoft.AspNetCore.SignalR;

namespace Flowcoach.Hubs
{
    public class FlowcoachHub : Hub
    {
        public FlowcoachHub() { }

        public async Task<List<FlowcoachCard>> GetModeCards()
        {
            List<FlowcoachCard> modeCards = new List<FlowcoachCard>
            {
                new FlowcoachCard
                {
                    Image = "/images/FC1.jpg",
                    Title = "Forandring",
                    Description = "Kom væk fra den negative følelse",
                    Path = "/forandring"
                },
                new FlowcoachCard
                {
                    Image = "/images/FC2.jpg",
                    Title = "Selvomsorg",
                    Description = "Det sikre sted, øvelse m.m.",
                    Path = "/selvomsorg"
                }
            };

            return modeCards;
        }
    }
}
