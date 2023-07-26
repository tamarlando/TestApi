using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class TestContext : DbContext
    {
        public TestContext(DbContextOptions<TestContext> options)
            : base(options)
        {
        }

        public DbSet<ChatDetails> ChatDetails { get; set; };
        public DbSet<User> Users { get; set; };
   
    }
}
