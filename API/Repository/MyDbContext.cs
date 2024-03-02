using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Repository
{
    public class MyDbContext : DbContext
    {

        public MyDbContext() { }

        public MyDbContext(DbContextOptions<MyDbContext> options) :base(options){}

        public DbSet<Client> Clients { get; set; }
    }
}
