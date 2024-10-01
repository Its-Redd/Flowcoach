using FlowCoach.Entities;
using Microsoft.EntityFrameworkCore;

namespace FlowCoach.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Card> Cards { get; set; }

    }
}
