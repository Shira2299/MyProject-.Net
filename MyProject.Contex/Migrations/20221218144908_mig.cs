using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.Contex.Migrations
{
    public partial class mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "epolicy",
                table: "Claims",
                newName: "Policy");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Claims_PermissionId",
                table: "Claims",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Claims_RoleId",
                table: "Claims",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Claims_Permissions_PermissionId",
                table: "Claims",
                column: "PermissionId",
                principalTable: "Permissions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Claims_Roles_RoleId",
                table: "Claims",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Claims_Permissions_PermissionId",
                table: "Claims");

            migrationBuilder.DropForeignKey(
                name: "FK_Claims_Roles_RoleId",
                table: "Claims");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Claims_PermissionId",
                table: "Claims");

            migrationBuilder.DropIndex(
                name: "IX_Claims_RoleId",
                table: "Claims");

            migrationBuilder.RenameColumn(
                name: "Policy",
                table: "Claims",
                newName: "epolicy");
        }
    }
}
