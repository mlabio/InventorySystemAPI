using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InventorySystemAPI.Migrations
{
    public partial class AddedbrandsAttributesAttribute_valueCategoriesCompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attribute_values",
                columns: table => new
                {
                    attribute_value_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    attribute_value_desc = table.Column<string>(type: "varchar(255)", nullable: true),
                    atrribute_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attribute_values", x => x.attribute_value_id);
                });

            migrationBuilder.CreateTable(
                name: "Attributes",
                columns: table => new
                {
                    attribute_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    attribute_name = table.Column<string>(type: "varchar(255)", nullable: true),
                    attribute_status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attributes", x => x.attribute_id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    brand_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brand_name = table.Column<string>(type: "varchar(255)", nullable: true),
                    brand_status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.brand_id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    category_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    category_name = table.Column<string>(type: "varchar(255)", nullable: true),
                    category_status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.category_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attribute_values");

            migrationBuilder.DropTable(
                name: "Attributes");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
