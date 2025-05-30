using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PlakDukkaniYonetimi.Core.Migrations
{
    /// <inheritdoc />
    public partial class InitProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albumler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbumAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sanatci = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CikisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IndirimOrani = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SatisDevamMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albumler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Yoneticiler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yoneticiler", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Albumler",
                columns: new[] { "Id", "AlbumAdi", "CikisTarihi", "Fiyat", "IndirimOrani", "Sanatci", "SatisDevamMi" },
                values: new object[,]
                {
                    { 1, "Opus Eponymous", new DateTime(2010, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 120m, null, "Ghost", false },
                    { 2, "Infestissumam", new DateTime(2013, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 130m, null, "Ghost", true },
                    { 3, "Meliora", new DateTime(2015, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 140m, null, "Ghost", true },
                    { 4, "Prequelle", new DateTime(2018, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 150m, 10m, "Ghost", true },
                    { 5, "Impera", new DateTime(2022, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 160m, null, "Ghost", true },
                    { 6, "Rite Here Rite Now", new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 170m, null, "Ghost", true },
                    { 7, "The Frail Tide", new DateTime(2007, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 110m, null, "Be'lakor", false },
                    { 8, "Stone's Reach", new DateTime(2009, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 120m, null, "Be'lakor", true },
                    { 9, "Of Breath and Bone", new DateTime(2012, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 130m, null, "Be'lakor", true },
                    { 10, "Vessels", new DateTime(2016, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 140m, 10m, "Be'lakor", true },
                    { 11, "Coherence", new DateTime(2021, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 150m, null, "Be'lakor", true },
                    { 12, "Väsen", new DateTime(2024, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 160m, null, "Be'lakor", true },
                    { 13, "Lunar Strain", new DateTime(1994, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100m, null, "In Flames", false },
                    { 14, "The Jester Race", new DateTime(1996, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 110m, null, "In Flames", false },
                    { 15, "Whoracle", new DateTime(1997, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 120m, null, "In Flames", false },
                    { 16, "Colony", new DateTime(1999, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 130m, null, "In Flames", true },
                    { 17, "Clayman", new DateTime(2000, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 140m, null, "In Flames", true },
                    { 18, "Reroute to Remain", new DateTime(2002, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 150m, null, "In Flames", true },
                    { 19, "Soundtrack to Your Escape", new DateTime(2004, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 160m, null, "In Flames", true },
                    { 20, "Come Clarity", new DateTime(2006, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 170m, null, "In Flames", true },
                    { 21, "A Sense of Purpose", new DateTime(2008, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 180m, null, "In Flames", true },
                    { 22, "Sounds of a Playground Fading", new DateTime(2011, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 190m, null, "In Flames", true },
                    { 23, "Siren Charms", new DateTime(2014, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 200m, 10m, "In Flames", true },
                    { 24, "Battles", new DateTime(2016, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 190m, null, "In Flames", true },
                    { 25, "I, the Mask", new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 180m, null, "In Flames", true },
                    { 26, "Foregone", new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 170m, null, "In Flames", true },
                    { 27, "Dance of December Souls", new DateTime(1993, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 100m, null, "Katatonia", false },
                    { 28, "Brave Murder Day", new DateTime(1996, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 110m, null, "Katatonia", false },
                    { 29, "Discouraged Ones", new DateTime(1998, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 120m, null, "Katatonia", true },
                    { 30, "Tonight's Decision", new DateTime(1999, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 130m, null, "Katatonia", true },
                    { 31, "Last Fair Deal Gone Down", new DateTime(2001, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 140m, null, "Katatonia", true },
                    { 32, "Viva Emptiness", new DateTime(2003, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 150m, null, "Katatonia", true },
                    { 33, "The Great Cold Distance", new DateTime(2006, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 160m, null, "Katatonia", true },
                    { 34, "Night Is the New Day", new DateTime(2009, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 170m, null, "Katatonia", true },
                    { 35, "Dead End Kings", new DateTime(2012, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 180m, null, "Katatonia", true },
                    { 36, "The Fall of Hearts", new DateTime(2016, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 190m, 10m, "Katatonia", true },
                    { 37, "City Burials", new DateTime(2020, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 200m, null, "Katatonia", true },
                    { 38, "Sky Void of Stars", new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 190m, null, "Katatonia", true },
                    { 39, "Nightmares as Extensions of the Waking State", new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 180m, null, "Katatonia", true }
                });

            migrationBuilder.InsertData(
                table: "Yoneticiler",
                columns: new[] { "Id", "KullaniciAdi", "Sifre" },
                values: new object[] { 1, "admin", "8C6976E5B5410415BDE908BD4DEE15DFB167A9C873FC4BB8A81F6F2AB448A918" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albumler");

            migrationBuilder.DropTable(
                name: "Yoneticiler");
        }
    }
}
