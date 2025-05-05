using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityMaster.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Blog",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PostTags",
                columns: table => new
                {
                    Tagsid = table.Column<int>(type: "int", nullable: false),
                    postsid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTags", x => new { x.Tagsid, x.postsid });
                    table.ForeignKey(
                        name: "FK_PostTags_Posts_postsid",
                        column: x => x.postsid,
                        principalTable: "Posts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTags_Tags_Tagsid",
                        column: x => x.Tagsid,
                        principalTable: "Tags",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_id",
                table: "Posts",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_Blog_id",
                table: "Blog",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_PostTags_postsid",
                table: "PostTags",
                column: "postsid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostTags");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Posts_id",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Blog_id",
                table: "Blog");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
