using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo_Company_API.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agents",
                columns: table => new
                {
                    AGENT_CODE = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AGENT_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WORKING_AREA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    COMMISSION = table.Column<int>(type: "int", nullable: false),
                    PHONE_NO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    COUNTRY = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agents", x => x.AGENT_CODE);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agents");
        }
    }
}
