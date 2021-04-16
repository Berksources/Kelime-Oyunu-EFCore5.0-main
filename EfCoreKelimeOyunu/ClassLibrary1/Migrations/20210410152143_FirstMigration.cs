using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity.KelimeOyunu.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EightWords",
                columns: table => new
                {
                    EightWordID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EightWordQuestion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EightWordAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EightWordData = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EightWordScore = table.Column<int>(type: "int", nullable: false),
                    DataGuidID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EightWords", x => x.EightWordID);
                });

            migrationBuilder.CreateTable(
                name: "FifthWords",
                columns: table => new
                {
                    FifthWordID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FifthWordQuestion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FifthWordAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FifthWordData = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FifthWordScore = table.Column<int>(type: "int", nullable: false),
                    DataGuidID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FifthWords", x => x.FifthWordID);
                });

            migrationBuilder.CreateTable(
                name: "FourWords",
                columns: table => new
                {
                    FourWordID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FourWordQuestion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FourWordAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FourWordData = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FourWordScore = table.Column<int>(type: "int", nullable: false),
                    DataGuidID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FourWords", x => x.FourWordID);
                });

            migrationBuilder.CreateTable(
                name: "NineWords",
                columns: table => new
                {
                    NineWordID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NineWordQuestion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NineWordAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NineWordData = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NineWordScore = table.Column<int>(type: "int", nullable: false),
                    DataGuidID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NineWords", x => x.NineWordID);
                });

            migrationBuilder.CreateTable(
                name: "SevenWords",
                columns: table => new
                {
                    SevenWordID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SevenWordQuestion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SevenWordAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SevenWordData = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SevenWordScore = table.Column<int>(type: "int", nullable: false),
                    DataGuidID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SevenWords", x => x.SevenWordID);
                });

            migrationBuilder.CreateTable(
                name: "SixthWords",
                columns: table => new
                {
                    SixthWordID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SixthWordQuestion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SixthWordAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SixthWordData = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SixthWordScore = table.Column<int>(type: "int", nullable: false),
                    DataGuidID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SixthWords", x => x.SixthWordID);
                });

            migrationBuilder.CreateTable(
                name: "TenWords",
                columns: table => new
                {
                    TenWordID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenWordQuestion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenWordAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenWordData = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenWordScore = table.Column<int>(type: "int", nullable: false),
                    DataGuidID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TenWords", x => x.TenWordID);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserRoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserRoleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataGuidID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.UserRoleID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserRoleID = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserSurname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEMail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserLastScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserIsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIsEmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    UserToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataGuidID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_Users_UserRoles_UserRoleID",
                        column: x => x.UserRoleID,
                        principalTable: "UserRoles",
                        principalColumn: "UserRoleID");
                });

            migrationBuilder.CreateTable(
                name: "ScoreTables",
                columns: table => new
                {
                    ScoreTableID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    ScoreData = table.Column<int>(type: "int", nullable: false),
                    DataGuidID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScoreTables", x => x.ScoreTableID);
                    table.ForeignKey(
                        name: "FK_ScoreTables_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserRoleID", "CreatedDate", "DataGuidID", "ModifiedDate", "UserRoleName" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7b952c84-fc68-4f72-bc45-cee6324cd862"), null, "Admin" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserRoleID", "CreatedDate", "DataGuidID", "ModifiedDate", "UserRoleName" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ea1a4bda-a4dc-49ad-9d3d-4f593dce19ff"), null, "Oyuncu" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "CreatedDate", "DataGuidID", "ModifiedDate", "UserEMail", "UserIsActive", "UserIsEmailConfirmed", "UserLastScore", "UserName", "UserPassword", "UserRoleID", "UserSurname", "UserToken" },
                values: new object[] { 1, new DateTime(2021, 4, 10, 18, 21, 42, 802, DateTimeKind.Local).AddTicks(1286), new Guid("e193b1b7-1cbe-460c-bc4f-06006baa4888"), null, "berk.garip@hbksoftware.com", true, true, null, "Berk", "berk2222", 1, "Garip", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "CreatedDate", "DataGuidID", "ModifiedDate", "UserEMail", "UserIsActive", "UserIsEmailConfirmed", "UserLastScore", "UserName", "UserPassword", "UserRoleID", "UserSurname", "UserToken" },
                values: new object[] { 2, new DateTime(2021, 4, 10, 18, 21, 42, 804, DateTimeKind.Local).AddTicks(1439), new Guid("e14798ca-71b1-432d-8de6-c08414cd7893"), null, "Kullanici@gmail.com", true, true, null, "Kullanici", "berk2222", 2, "Kullanici", null });

            migrationBuilder.CreateIndex(
                name: "IX_ScoreTables_UserID",
                table: "ScoreTables",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserRoleID",
                table: "Users",
                column: "UserRoleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EightWords");

            migrationBuilder.DropTable(
                name: "FifthWords");

            migrationBuilder.DropTable(
                name: "FourWords");

            migrationBuilder.DropTable(
                name: "NineWords");

            migrationBuilder.DropTable(
                name: "ScoreTables");

            migrationBuilder.DropTable(
                name: "SevenWords");

            migrationBuilder.DropTable(
                name: "SixthWords");

            migrationBuilder.DropTable(
                name: "TenWords");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserRoles");
        }
    }
}
