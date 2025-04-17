using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lockd.Core.Migrations
{
    /// <inheritdoc />
    public partial class ChangedPasswordName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Records",
                newName: "PasswordHash");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "Records",
                newName: "Password");
        }
    }
}
