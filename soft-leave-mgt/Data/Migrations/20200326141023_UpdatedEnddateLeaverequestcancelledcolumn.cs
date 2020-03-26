using Microsoft.EntityFrameworkCore.Migrations;

namespace soft_leave_mgt.Data.Migrations
{
    public partial class UpdatedEnddateLeaverequestcancelledcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Cancelled",
                table: "LeaveRequests",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cancelled",
                table: "LeaveRequests");
        }
    }
}
