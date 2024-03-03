using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class InitialVersion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    EmailAddress = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    FirstName = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    MiddleName = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    PasswordHash = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    Pronouns = table.Column<string>(type: "NVARCHAR2(21)", maxLength: 21, nullable: false),
                    UserWatcher = table.Column<bool>(type: "NUMBER(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.EmailAddress);
                });

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Title = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "NVARCHAR2(1000)", maxLength: 1000, nullable: false),
                    Priority = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    SentAt = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    RecipientUserEmailAddress = table.Column<string>(type: "NVARCHAR2(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emails_Users_RecipientUserEmailAddress",
                        column: x => x.RecipientUserEmailAddress,
                        principalTable: "Users",
                        principalColumn: "EmailAddress",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Followings",
                columns: table => new
                {
                    FollowerUserEmailAddress = table.Column<string>(type: "NVARCHAR2(255)", nullable: false),
                    FollowedUserEmailAddress = table.Column<string>(type: "NVARCHAR2(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Followings", x => new { x.FollowedUserEmailAddress, x.FollowerUserEmailAddress });
                    table.ForeignKey(
                        name: "FK_Followings_Users_FollowedUserEmailAddress",
                        column: x => x.FollowedUserEmailAddress,
                        principalTable: "Users",
                        principalColumn: "EmailAddress",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Followings_Users_FollowerUserEmailAddress",
                        column: x => x.FollowerUserEmailAddress,
                        principalTable: "Users",
                        principalColumn: "EmailAddress",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Poetries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Content = table.Column<string>(type: "NVARCHAR2(1000)", maxLength: 1000, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserEmailAddress = table.Column<string>(type: "NVARCHAR2(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poetries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Poetries_Users_CreatorUserEmailAddress",
                        column: x => x.CreatorUserEmailAddress,
                        principalTable: "Users",
                        principalColumn: "EmailAddress",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Content = table.Column<string>(type: "NVARCHAR2(1000)", maxLength: 1000, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Location = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: true),
                    CreatorUserEmailAddress = table.Column<string>(type: "NVARCHAR2(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Users_CreatorUserEmailAddress",
                        column: x => x.CreatorUserEmailAddress,
                        principalTable: "Users",
                        principalColumn: "EmailAddress",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WatchList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    From = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Until = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    StalkedEmailAddress = table.Column<string>(type: "NVARCHAR2(255)", nullable: false),
                    StalkerEmailAddress = table.Column<string>(type: "NVARCHAR2(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WatchList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WatchList_Users_StalkedEmailAddress",
                        column: x => x.StalkedEmailAddress,
                        principalTable: "Users",
                        principalColumn: "EmailAddress",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WatchList_Users_StalkerEmailAddress",
                        column: x => x.StalkerEmailAddress,
                        principalTable: "Users",
                        principalColumn: "EmailAddress",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Content = table.Column<string>(type: "NVARCHAR2(1000)", maxLength: 1000, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserEmailAddress = table.Column<string>(type: "NVARCHAR2(255)", nullable: false),
                    CommentedOnPostId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    CommentedOnPoetryId = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Poetries_CommentedOnPoetryId",
                        column: x => x.CommentedOnPoetryId,
                        principalTable: "Poetries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_CommentedOnPoetryId",
                        column: x => x.CommentedOnPoetryId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Users_CreatorUserEmailAddress",
                        column: x => x.CreatorUserEmailAddress,
                        principalTable: "Users",
                        principalColumn: "EmailAddress",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Engagements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    CreationDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserEmailAddress = table.Column<string>(type: "NVARCHAR2(255)", nullable: false),
                    EngagedWithPostId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    EngagedWithPoetryId = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engagements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Engagements_Poetries_EngagedWithPoetryId",
                        column: x => x.EngagedWithPoetryId,
                        principalTable: "Poetries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Engagements_Posts_EngagedWithPostId",
                        column: x => x.EngagedWithPostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Engagements_Users_CreatorUserEmailAddress",
                        column: x => x.CreatorUserEmailAddress,
                        principalTable: "Users",
                        principalColumn: "EmailAddress",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CommentedOnPoetryId",
                table: "Comments",
                column: "CommentedOnPoetryId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CreatorUserEmailAddress",
                table: "Comments",
                column: "CreatorUserEmailAddress");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_RecipientUserEmailAddress",
                table: "Emails",
                column: "RecipientUserEmailAddress");

            migrationBuilder.CreateIndex(
                name: "IX_Engagements_CreatorUserEmailAddress",
                table: "Engagements",
                column: "CreatorUserEmailAddress");

            migrationBuilder.CreateIndex(
                name: "IX_Engagements_EngagedWithPoetryId",
                table: "Engagements",
                column: "EngagedWithPoetryId");

            migrationBuilder.CreateIndex(
                name: "IX_Engagements_EngagedWithPostId",
                table: "Engagements",
                column: "EngagedWithPostId");

            migrationBuilder.CreateIndex(
                name: "IX_Followings_FollowerUserEmailAddress",
                table: "Followings",
                column: "FollowerUserEmailAddress");

            migrationBuilder.CreateIndex(
                name: "IX_Poetries_CreatorUserEmailAddress",
                table: "Poetries",
                column: "CreatorUserEmailAddress");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CreatorUserEmailAddress",
                table: "Posts",
                column: "CreatorUserEmailAddress");

            migrationBuilder.CreateIndex(
                name: "IX_WatchList_StalkedEmailAddress",
                table: "WatchList",
                column: "StalkedEmailAddress");

            migrationBuilder.CreateIndex(
                name: "IX_WatchList_StalkerEmailAddress",
                table: "WatchList",
                column: "StalkerEmailAddress");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "Engagements");

            migrationBuilder.DropTable(
                name: "Followings");

            migrationBuilder.DropTable(
                name: "WatchList");

            migrationBuilder.DropTable(
                name: "Poetries");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
