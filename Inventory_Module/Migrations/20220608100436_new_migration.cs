using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory_Module.Migrations
{
    public partial class new_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client_tbl",
                columns: table => new
                {
                    client_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    global_id = table.Column<int>(type: "int", nullable: false),
                    client_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    client_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    client_business_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    client_GSTNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    client_contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    client_reference_contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    client_reference_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    client_business_description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pincode = table.Column<int>(type: "int", nullable: false),
                    country_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    country_id = table.Column<int>(type: "int", nullable: false),
                    state_id = table.Column<int>(type: "int", nullable: false),
                    city_id = table.Column<int>(type: "int", nullable: false),
                    client_logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pan_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<int>(type: "int", nullable: false),
                    Client_Enrollment_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Subscription_period = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client_tbl", x => x.client_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client_tbl");
        }
    }
}
