using Microsoft.EntityFrameworkCore.Migrations;

namespace GenericRepositoryDemo.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras ut leo eu tortor pretium malesuada.", "Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 2, "Vestibulum nec magna eu tortor ullamcorper iaculis. Vivamus faucibus volutpat varius. ", "Dolor Sit" });

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 3, "Ut ultricies sollicitudin nibh, sit amet ultricies orci faucibus eu. Duis eu nisl dolor. Vestibulum quam velit, aliquam id dictum a, rutrum eu sem. ", "Consectetur" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Documents");
        }
    }
}
