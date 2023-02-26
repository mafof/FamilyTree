using FamilyTree.Models;
using Microsoft.EntityFrameworkCore;

namespace FamilyTree.Services
{
    public class PeopleService : DbContext
    {
        public PeopleService()
        { }

        public PeopleService(DbContextOptions<PeopleService> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=localhost\\MSSQLSERVER01;Database=test;User Id=mafof;password=mafof;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=False;TrustServerCertificate=False;");
        }

        public DbSet<PeopleModel> People { get; set; } = null!;
        public DbSet<LinkModel> Link { get; set; } = null!;
    }
}
