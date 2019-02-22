using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InventorySystemAPI.Migrations
{
    public partial class AddedStoresandProductstables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    product_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    product_name = table.Column<string>(type: "varchar(255)", nullable: true),
                    product_sku = table.Column<string>(type: "varchar(255)", nullable: true),
                    product_price = table.Column<string>(type: "varchar(255)", nullable: true),
                    product_qty = table.Column<string>(type: "varchar(255)", nullable: true),
                    product_image = table.Column<string>(type: "text", nullable: true),
                    product_description = table.Column<string>(type: "text", nullable: true),
                    attribute_value_id = table.Column<string>(type: "text", nullable: true),
                    brand_id = table.Column<string>(type: "text", nullable: true),
                    category_id = table.Column<string>(type: "text", nullable: true),
                    store_id = table.Column<int>(nullable: false),
                    availability = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.product_id);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    store_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    store_name = table.Column<string>(type: "varchar(255)", nullable: true),
                    store_status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.store_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Stores");
        }
    }
}
