using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory_Module.Migrations
{
    public partial class add_new_log_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Log_Maintain_tbl",
                columns: table => new
                {
                    error_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    error_line_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    error_trace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    error_messege = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    error_inner_exception = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    error_data = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log_Maintain_tbl", x => x.error_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Log_Maintain_tbl");
        }
    }
}
