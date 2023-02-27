using FamilyTree.Migrations;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("DBConnetion");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDbFunction(() => GrandMotherGreatGrandson(default));

            modelBuilder.Entity<PeopleModel>().HasData(
                // 4 уровень =>

                // 1 семья =>
                new PeopleModel { Id = 1, Surname = "Калашников", Name = "Святослав", Patronymic = "Донатович", Gender = "Муж" },
                new PeopleModel { Id = 2, Surname = "Калашникова", Name = "Фанни", Patronymic = "Игнатьевна", Gender = "Жен" },

                // 2 семья =>
                new PeopleModel { Id = 3, Surname = "Мамонтов", Name = "Кондрат", Patronymic = "Натальевич", Gender = "Муж" },
                new PeopleModel { Id = 4, Surname = "Мамонтова", Name = "Раиса", Patronymic = "Давидовна", Gender = "Жен" },

                // 3 семья =>
                new PeopleModel { Id = 5, Surname = "Суворов", Name = "Иван", Patronymic = "Наумович", Gender = "Муж" },
                new PeopleModel { Id = 6, Surname = "Суворова", Name = "Магдалина", Patronymic = "Романовна", Gender = "Жен" },

                // 4 семья =>
                new PeopleModel { Id = 7, Surname = "Котов", Name = "Константин", Patronymic = "Владимирович", Gender = "Муж" },
                new PeopleModel { Id = 8, Surname = "Котова", Name = "Женевьева", Patronymic = "Степановна", Gender = "Жен" },

                // 3 уровень =>

                // 5 семья =>

                // Ребенок от 1-ой семьи
                new PeopleModel { Id = 9, Surname = "Калашников", Name = "Донат", Patronymic = "Святославич", Gender = "Муж" },

                // Ребенок от 2-ой семьи
                new PeopleModel { Id = 10, Surname = "Мамонтова", Name = "Эллина", Patronymic = "Кондратовна", Gender = "Жен" },

                // 6 семья =>

                // Ребенок от 3-ой семьи
                new PeopleModel { Id = 11, Surname = "Суворов", Name = "Павел", Patronymic = "Ивановна", Gender = "Муж" },

                // Ребенок от 4-ей семьи
                new PeopleModel { Id = 12, Surname = "Котова", Name = "Эллина", Patronymic = "Константинович", Gender = "Жен" },

                // 2 уровень =>

                // 7 семья =>

                // Ребенок от 5-ой семьи
                new PeopleModel { Id = 13, Surname = "Калашников", Name = "Михаил", Patronymic = "Донатович", Gender = "Муж" },

                // Ребенок от 6-ой семьи
                new PeopleModel { Id = 14, Surname = "Суворова", Name = "Гражина", Patronymic = "Павловна", Gender = "Жен" },

                // 1 уровень =>

                // Дети (правнуки) => 
                new PeopleModel { Id = 15, Surname = "Калашников", Name = "Гурий", Patronymic = "Михайлович", Gender = "Муж" },
                new PeopleModel { Id = 16, Surname = "Калашников", Name = "Алексей", Patronymic = "Михайлович", Gender = "Муж" },
                new PeopleModel { Id = 17, Surname = "Калашникова", Name = "Римма", Patronymic = "Михайловна", Gender = "Жен" }
            );

            modelBuilder.Entity<LinkModel>().HasData(
                new LinkModel { Id = 1, PeopleId = 1, PeopleChildID = 9, Level = 1 },
                new LinkModel { Id = 2, PeopleId = 2, PeopleChildID = 9, Level = 1 },
                new LinkModel { Id = 3, PeopleId = 3, PeopleChildID = 10, Level = 1 },
                new LinkModel { Id = 4, PeopleId = 4, PeopleChildID = 10, Level = 1 },
                new LinkModel { Id = 5, PeopleId = 5, PeopleChildID = 11, Level = 1 },
                new LinkModel { Id = 6, PeopleId = 6, PeopleChildID = 11, Level = 1 },
                new LinkModel { Id = 7, PeopleId = 7, PeopleChildID = 12, Level = 1 },
                new LinkModel { Id = 8, PeopleId = 8, PeopleChildID = 12, Level = 1 },
                new LinkModel { Id = 9, PeopleId = 9, PeopleChildID = 13, Level = 2 },
                new LinkModel { Id = 10, PeopleId = 10, PeopleChildID = 13, Level = 2 },
                new LinkModel { Id = 11, PeopleId = 11, PeopleChildID = 14, Level = 2 },
                new LinkModel { Id = 12, PeopleId = 12, PeopleChildID = 14, Level = 2 },
                new LinkModel { Id = 13, PeopleId = 13, PeopleChildID = 15, Level = 3 },
                new LinkModel { Id = 14, PeopleId = 14, PeopleChildID = 15, Level = 3 },
                new LinkModel { Id = 15, PeopleId = 13, PeopleChildID = 16, Level = 3 },
                new LinkModel { Id = 16, PeopleId = 14, PeopleChildID = 16, Level = 3 },
                new LinkModel { Id = 17, PeopleId = 13, PeopleChildID = 17, Level = 3 },
                new LinkModel { Id = 18, PeopleId = 14, PeopleChildID = 17, Level = 3 },
                new LinkModel { Id = 19, PeopleId = 15, PeopleChildID = null, Level = 4 },
                new LinkModel { Id = 20, PeopleId = 16, PeopleChildID = null, Level = 4 },
                new LinkModel { Id = 21, PeopleId = 17, PeopleChildID = null, Level = 4 }
            );
        }

        public DbSet<PeopleModel> People { get; set; } = null!;
        public DbSet<LinkModel> Link { get; set; } = null!;

        public IQueryable<GrandMotherGreatGrandsonModel> GrandMotherGreatGrandson(int personID) => FromExpression(() => GrandMotherGreatGrandson(personID));
    }
}
