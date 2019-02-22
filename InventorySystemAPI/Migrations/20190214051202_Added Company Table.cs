using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InventorySystemAPI.Migrations
{
    public partial class AddedCompanyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    company_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    company_name = table.Column<string>(type: "varchar(100)", nullable: true),
                    service_charge_valie = table.Column<string>(type: "varchar(100)", nullable: true),
                    vat_charge_value = table.Column<string>(type: "varchar(100)", nullable: true),
                    address = table.Column<string>(type: "varchar(100)", nullable: true),
                    phone = table.Column<string>(type: "varchar(100)", nullable: true),
                    country = table.Column<string>(type: "varchar(100)", nullable: true),
                    message = table.Column<string>(type: "varchar(100)", nullable: true),
                    currency = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.company_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
