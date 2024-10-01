using FlowCoach.Entities;
using Microsoft.EntityFrameworkCore;

namespace FlowCoach.DataAccess
{
    public class DataContext : DbContext
    {
        private readonly string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FlowcoachDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<EmotionCard> EmotionCards { get; set; }
        public DbSet<FlowcoachCard> FlowcoachCards { get; set; }
        public DbSet<SelfcareCard> SelfcareCards { get; set; }
        public DbSet<BodyFlowCard> BodyFlowCards { get; set; }
        public DbSet<BodyFlowArticle> BodyFlowArticles { get; set; }
        public DbSet<SelfCareArticle> SelfcareArticles { get; set; }
        public DbSet<CoachingSession> CoachingSessions { get; set; }
        public DbSet<JournalEntry> JournalEntries { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<User> Users { get; set; }




    }
}
