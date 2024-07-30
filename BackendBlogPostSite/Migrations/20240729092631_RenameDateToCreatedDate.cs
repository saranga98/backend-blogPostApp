using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendBlogPostSite.Migrations
{
    /// <inheritdoc />
    public partial class RenameDateToCreatedDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Posts",
                newName: "ImagePath");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Posts",
                newName: "CreatedDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImagePath",
                table: "Posts",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Posts",
                newName: "Date");
        }
    }
}
