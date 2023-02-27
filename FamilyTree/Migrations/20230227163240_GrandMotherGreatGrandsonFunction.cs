using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FamilyTree.Migrations
{
    /// <inheritdoc />
    public partial class GrandMotherGreatGrandsonFunction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
				CREATE FUNCTION GrandMotherGreatGrandson
				(
					@idPeopleID int
				)
				RETURNS @returntable TABLE
				(
					IdGrandmother int,
					IdGreatGrandson int,
					FullnameGrandmother nvarchar(MAX),
					FullnameGreatGrandson nvarchar(MAX)
				)
				AS
				BEGIN
					INSERT @returntable

					SELECT DISTINCT
						Link.PeopleId AS IdGrandmother,
						GreatGrandson.PeopleId AS IdGreatGrandson,
						CONCAT(GrandmotherPeople.Surname, ' ', GrandmotherPeople.Name, ' ', GrandmotherPeople.Patronymic) AS  FullnameGrandmother,
						CONCAT(GreatGrandsonPeople.Surname, ' ', GreatGrandsonPeople.Name, ' ', GreatGrandsonPeople.Patronymic) AS  FullnameGreatGrandson
					FROM Link
					INNER JOIN Link AS GrandmotherChildren -- Дети бабушки
						ON GrandmotherChildren.PeopleId = Link.PeopleChildID
					INNER JOIN Link AS Grandson -- Внуки бабушки
						ON Grandson.PeopleId = GrandmotherChildren.PeopleChildID
					INNER JOIN Link AS GreatGrandson -- Правнуки бабушки
						ON GreatGrandson.PeopleId = Grandson.PeopleChildID
					INNER JOIN People AS GreatGrandsonPeople -- ФИО внука
						ON GreatGrandson.PeopleId = GreatGrandsonPeople.Id
					INNER JOIN People AS GrandmotherPeople -- ФИО бабушки
						ON Link.PeopleID = GrandmotherPeople.Id
					WHERE 
						Link.PeopleId IN((
							SELECT DISTINCT
								Grandmother.PeopleId
							FROM Link
							INNER JOIN Link AS Grandmother
								ON Grandmother.PeopleChildID = Link.PeopleId
							INNER JOIN People
								ON People.Id = Grandmother.PeopleId AND People.Gender = 'Жен'
							WHERE Link.PeopleChildID = @idPeopleID
						)) AND
						(GreatGrandson.Level = Link.Level + 3);

					RETURN
				END
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
