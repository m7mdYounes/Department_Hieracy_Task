using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeptHieracy.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Depts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeptNameName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parent_Dept_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Depts_Depts_Parent_Dept_id",
                        column: x => x.Parent_Dept_id,
                        principalTable: "Depts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Depts_Parent_Dept_id",
                table: "Depts",
                column: "Parent_Dept_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Depts");
        }
    }
}
