using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PetShopAlgebraProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "AspNetUsers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "AspNetUsers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PetCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    PetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PetCategory_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PetCategory_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PetStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PetId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Sold = table.Column<bool>(type: "bit", nullable: false),
                    Reserved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PetStatus_AspNetUsers_StatusId",
                        column: x => x.StatusId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PetStatus_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "31e5c1c0-4ded-4516-bedf-f2a252c47ea8", null, "Admin", "ADMIN" },
                    { "f440c61c-4424-49de-acd7-2150783336b8", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "Mačka" },
                    { 2, "Pas" },
                    { 3, "Slon" },
                    { 4, "Iguana" },
                    { 5, "Čimpanza" },
                    { 6, "Gorila" },
                    { 7, "Lav" },
                    { 8, "Žohar" },
                    { 9, "Kameleon" },
                    { 10, "Činčila" },
                    { 11, "Hrčak" }
                });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Description", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Teritorijalna, nije dobra s drugim životinjama", "Felix.jpg", "Felix", 25.50m },
                    { 2, "Živahan i veseo mačak", "Tom.jpg", "Tom", 30m },
                    { 3, "Umiljat, prelijepog krzna", "Sylvester.jpg", "Sylvester", 28m },
                    { 4, "Mirna životinja", "Dumbo.jpg", "Dumbo", 650m },
                    { 5, "Razigran i pametan ljubimac", "Karlo.jpg", "Karlo", 200m },
                    { 6, "Samo za stručne vlasnike", "Goran.jpg", "Goran", 300m },
                    { 7, "Vjeran i drag", "Smoki.jpg", "Smoki", 20m },
                    { 8, "Odrastao u divljini, nezahtjevan a privržen", "Floki.jpg", "Floki", 15m },
                    { 9, "Razigrana čivava", "Bobi.jpg", "Bobi", 45m },
                    { 10, "Prekrasne zelene boje", "Sebastijan.jpg", "Sebastijan", 70m },
                    { 11, "Now you see him...", "John_Cena.jpg", "John Cena", 130m },
                    { 12, "Uzgojen za prehranu", "Alain.jpg", "Alain", 2m },
                    { 13, "Jako veseo i razigran hrčak", "Pero.jpg", "Pero", 10m },
                    { 14, "Draga životinja, osobito djeci, ali voli ugristi", "Charlie.jpg", "Charlie", 30m },
                    { 15, "Samo uz predodžbu potrebnih dozvola", "Baltazar.jpg", "Baltazar", 450m }
                });

            migrationBuilder.InsertData(
                table: "PetCategory",
                columns: new[] { "Id", "CategoryId", "PetId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 4, 2, 7 },
                    { 5, 2, 8 },
                    { 6, 2, 9 },
                    { 7, 3, 4 },
                    { 8, 4, 10 },
                    { 9, 5, 5 },
                    { 10, 6, 6 },
                    { 11, 7, 15 },
                    { 12, 8, 12 },
                    { 13, 9, 11 },
                    { 14, 10, 14 },
                    { 15, 11, 13 }
                });

            migrationBuilder.InsertData(
                table: "PetStatus",
                columns: new[] { "Id", "PetId", "Reserved", "Sold", "StatusId" },
                values: new object[,]
                {
                    { 1, 1, false, false, null },
                    { 2, 2, false, false, null },
                    { 3, 3, false, false, null },
                    { 4, 4, false, false, null },
                    { 5, 5, false, false, null },
                    { 6, 6, false, false, null },
                    { 7, 7, false, false, null },
                    { 8, 8, false, false, null },
                    { 9, 9, false, false, null },
                    { 10, 10, false, false, null },
                    { 11, 11, false, false, null },
                    { 12, 12, false, false, null },
                    { 13, 13, false, false, null },
                    { 14, 14, false, false, null },
                    { 15, 15, false, false, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PetCategory_CategoryId",
                table: "PetCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PetCategory_PetId",
                table: "PetCategory",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_PetStatus_PetId",
                table: "PetStatus",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_PetStatus_StatusId",
                table: "PetStatus",
                column: "StatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PetCategory");

            migrationBuilder.DropTable(
                name: "PetStatus");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31e5c1c0-4ded-4516-bedf-f2a252c47ea8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f440c61c-4424-49de-acd7-2150783336b8");

            migrationBuilder.DropColumn(
                name: "Adress",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "AspNetUsers");
        }
    }
}
