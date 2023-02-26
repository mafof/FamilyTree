using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FamilyTree.Migrations
{
    /// <inheritdoc />
    public partial class people : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Patronymic = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Link",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PeopleId = table.Column<int>(type: "int", nullable: true),
                    PeopleChildID = table.Column<int>(type: "int", nullable: true),
                    Level = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Link", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Link_People_PeopleChildID",
                        column: x => x.PeopleChildID,
                        principalTable: "People",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Link_People_PeopleId",
                        column: x => x.PeopleId,
                        principalTable: "People",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Name", "Patronymic", "Surname" },
                values: new object[,]
                {
                    { 1, "Святослав", "Донатович", "Калашников" },
                    { 2, "Фанни", "Игнатьевна", "Калашникова" },
                    { 3, "Кондрат", "Натальевич", "Мамонтов" },
                    { 4, "Раиса", "Давидовна", "Мамонтова" },
                    { 5, "Иван", "Наумович", "Суворов" },
                    { 6, "Магдалина", "Романовна", "Суворова" },
                    { 7, "Константин", "Владимирович", "Котов" },
                    { 8, "Женевьева", "Степановна", "Котова" },
                    { 9, "Донат", "Святославич", "Калашников" },
                    { 10, "Эллина", "Кондратовна", "Мамонтова" },
                    { 11, "Павел", "Ивановна", "Суворов" },
                    { 12, "Эллина", "Константинович", "Котова" },
                    { 13, "Михаил", "Донатович", "Калашников" },
                    { 14, "Гражина", "Павловна", "Суворова" },
                    { 15, "Гурий", "Михайлович", "Калашников" },
                    { 16, "Алексей", "Михайлович", "Калашников" },
                    { 17, "Римма", "Михайловна", "Калашников" }
                });

            migrationBuilder.InsertData(
                table: "Link",
                columns: new[] { "Id", "Level", "PeopleChildID", "PeopleId" },
                values: new object[,]
                {
                    { 1, 1, 9, 1 },
                    { 2, 1, 9, 2 },
                    { 3, 1, 10, 3 },
                    { 4, 1, 10, 4 },
                    { 5, 1, 11, 5 },
                    { 6, 1, 11, 6 },
                    { 7, 1, 12, 7 },
                    { 8, 1, 12, 8 },
                    { 9, 2, 13, 9 },
                    { 10, 2, 13, 10 },
                    { 11, 2, 14, 11 },
                    { 12, 2, 14, 12 },
                    { 13, 3, 15, 13 },
                    { 14, 3, 15, 14 },
                    { 15, 3, 16, 13 },
                    { 16, 3, 16, 14 },
                    { 17, 3, 17, 13 },
                    { 18, 3, 17, 14 },
                    { 19, 4, null, 15 },
                    { 20, 4, null, 16 },
                    { 21, 4, null, 17 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Link_PeopleChildID",
                table: "Link",
                column: "PeopleChildID");

            migrationBuilder.CreateIndex(
                name: "IX_Link_PeopleId",
                table: "Link",
                column: "PeopleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Link");

            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
