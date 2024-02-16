using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class Visitor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b2fe02ee-d469-475e-86ff-610f9d1de365"));

            migrationBuilder.CreateTable(
                name: "Visitors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAgent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleVisitors",
                columns: table => new
                {
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VisitorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleVisitors", x => new { x.ArticleId, x.VisitorId });
                    table.ForeignKey(
                        name: "FK_ArticleVisitors_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleVisitors_Visitors_VisitorId",
                        column: x => x.VisitorId,
                        principalTable: "Visitors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("e1f43848-56ca-4891-b34e-670aa0ae71c0"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 22, 12, 41, 20, 174, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[] { new Guid("133f8b0f-0f7f-4ea8-bab2-7cdad48165f5"), new Guid("447c1313-f516-432b-bab7-7f2df36dbf8d"), "Visual Studio bla bla bla", "Admin Test", new DateTime(2023, 10, 22, 12, 41, 20, 174, DateTimeKind.Local).AddTicks(8369), null, null, new Guid("3f668c57-4b9b-4a24-a8fe-356732d57be8"), false, null, null, "Visual Studio Deneme Makalesi 1", new Guid("4473b6bc-3be0-4bb0-a39f-3426cec6fb03"), 15 });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2a3484dd-8956-4fd2-942f-3e0c9d201c27"),
                column: "ConcurrencyStamp",
                value: "219322c4-918a-44e9-9b31-a1c3a32cdf23");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("dcb8d312-868b-4910-a055-76230497233f"),
                column: "ConcurrencyStamp",
                value: "6e5b8dfc-b263-43a1-9231-608ca9b9ec0f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fadadacb-b4d3-4f81-a7f9-a97cb46ddce5"),
                column: "ConcurrencyStamp",
                value: "e41d484e-e4df-4795-a9d7-745056a329f8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4473b6bc-3be0-4bb0-a39f-3426cec6fb03"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a6b1ca4-ad07-4ba7-b042-442d6b7caae3", "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEFAgHWBf7oWHFV6zipzXRb3dmo8kuGxBz8/JqTuLCihkhBskX5b8cXgXgnDNHjrg2Q==", "48f570a3-faaa-45bc-929a-5e81f7ed8c36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ff1dc87b-7f05-4e15-a11b-ce5b8a448dac"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "283d1c10-2297-42e8-8d9c-26f752b9fd2b", "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEO2EQCgDmC+kI1WLI3W9Tf6iHmw2UgsvxPmr1e+5kuZ6HN5rDvxW5dEqiKBHrrQiSQ==", "774b4692-050b-4f91-a437-f6174023f895" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("447c1313-f516-432b-bab7-7f2df36dbf8d"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 22, 12, 41, 20, 175, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e1f43848-56ca-4891-b34e-670aa0ae71c0"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 22, 12, 41, 20, 175, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3f668c57-4b9b-4a24-a8fe-356732d57be8"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 22, 12, 41, 20, 175, DateTimeKind.Local).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("773d14fc-26c8-4f54-b311-868d6dc32e4b"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 22, 12, 41, 20, 175, DateTimeKind.Local).AddTicks(528));

            migrationBuilder.CreateIndex(
                name: "IX_ArticleVisitors_VisitorId",
                table: "ArticleVisitors",
                column: "VisitorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleVisitors");

            migrationBuilder.DropTable(
                name: "Visitors");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("133f8b0f-0f7f-4ea8-bab2-7cdad48165f5"));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("e1f43848-56ca-4891-b34e-670aa0ae71c0"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 16, 15, 55, 850, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[] { new Guid("b2fe02ee-d469-475e-86ff-610f9d1de365"), new Guid("447c1313-f516-432b-bab7-7f2df36dbf8d"), "Visual Studio bla bla bla", "Admin Test", new DateTime(2023, 7, 27, 16, 15, 55, 850, DateTimeKind.Local).AddTicks(4506), null, null, new Guid("3f668c57-4b9b-4a24-a8fe-356732d57be8"), false, null, null, "Visual Studio Deneme Makalesi 1", new Guid("4473b6bc-3be0-4bb0-a39f-3426cec6fb03"), 15 });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2a3484dd-8956-4fd2-942f-3e0c9d201c27"),
                column: "ConcurrencyStamp",
                value: "7444b8a1-e722-4248-acdb-af4e59343512");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("dcb8d312-868b-4910-a055-76230497233f"),
                column: "ConcurrencyStamp",
                value: "02b1258c-8138-4bdd-b97e-6024934781b1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fadadacb-b4d3-4f81-a7f9-a97cb46ddce5"),
                column: "ConcurrencyStamp",
                value: "ada86541-64c1-48ed-8a7a-46da9343619d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4473b6bc-3be0-4bb0-a39f-3426cec6fb03"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3474c04f-2090-4383-b3fe-a8632a548325", "ADMIN@GMAİL.COM", "ADMIN@GMAİL.COM", "AQAAAAEAACcQAAAAEMMcxH8ZPt8CRhMpInDD+xXho3IxwQNzBavLOr0kgLCezZ+y6aYWY94VaCtkrtLlEA==", "50435540-e34f-4fc6-9bbc-ca80b7b65110" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ff1dc87b-7f05-4e15-a11b-ce5b8a448dac"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65c2f66a-40eb-49de-955d-692c530a554d", "SUPERADMIN@GMAİL.COM", "SUPERADMIN@GMAİL.COM", "AQAAAAEAACcQAAAAELNeflfH1TQzPcwVSJ72k+wnnjjhKr1731w1gdg+ymB6GDKmOZeMAu5YdyTzMrhFbQ==", "5737de71-717a-4e92-aafd-a5dafe1bddd2" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("447c1313-f516-432b-bab7-7f2df36dbf8d"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 16, 15, 55, 850, DateTimeKind.Local).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e1f43848-56ca-4891-b34e-670aa0ae71c0"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 16, 15, 55, 850, DateTimeKind.Local).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3f668c57-4b9b-4a24-a8fe-356732d57be8"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 16, 15, 55, 850, DateTimeKind.Local).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("773d14fc-26c8-4f54-b311-868d6dc32e4b"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 16, 15, 55, 850, DateTimeKind.Local).AddTicks(5013));
        }
    }
}
