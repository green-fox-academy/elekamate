using Microsoft.EntityFrameworkCore.Migrations;

namespace _01ListingTodos.Migrations
{
    public partial class AddingAssigneeTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignees_ToDos_ToDoId",
                table: "Assignees");

            migrationBuilder.DropIndex(
                name: "IX_Assignees_ToDoId",
                table: "Assignees");

            migrationBuilder.DropColumn(
                name: "ToDoId",
                table: "Assignees");

            migrationBuilder.AddColumn<long>(
                name: "AssigneeId",
                table: "ToDos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ToDos_AssigneeId",
                table: "ToDos",
                column: "AssigneeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ToDos_Assignees_AssigneeId",
                table: "ToDos",
                column: "AssigneeId",
                principalTable: "Assignees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDos_Assignees_AssigneeId",
                table: "ToDos");

            migrationBuilder.DropIndex(
                name: "IX_ToDos_AssigneeId",
                table: "ToDos");

            migrationBuilder.DropColumn(
                name: "AssigneeId",
                table: "ToDos");

            migrationBuilder.AddColumn<long>(
                name: "ToDoId",
                table: "Assignees",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Assignees_ToDoId",
                table: "Assignees",
                column: "ToDoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignees_ToDos_ToDoId",
                table: "Assignees",
                column: "ToDoId",
                principalTable: "ToDos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
