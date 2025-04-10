using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Language", "Overview", "PosterUrl", "Rating", "ReleaseDate", "Runtime", "Title" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), "Comedy,Romance", "Spanish", "Overview for popular movie 1. It's quite an interesting film about many things.", "/posters/popular1.jpg", 1, new DateTime(2016, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 121, "Popular Movie Title 1" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "Drama,Thriller", "English", "Overview for popular movie 2. It's quite an interesting film about many things.", "/posters/popular2.jpg", 2, new DateTime(2017, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, "Popular Movie Title 2" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "Action,Adventure", "Spanish", "Overview for popular movie 3. It's quite an interesting film about many things.", "/posters/popular3.jpg", 3, new DateTime(2018, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 123, "Popular Movie Title 3" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), "Comedy,Romance", "English", "Overview for popular movie 4. It's quite an interesting film about many things.", "/posters/popular4.jpg", 4, new DateTime(2019, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 124, "Popular Movie Title 4" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), "Drama,Thriller", "Spanish", "Overview for popular movie 5. It's quite an interesting film about many things.", "/posters/popular5.jpg", 5, new DateTime(2020, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 125, "Popular Movie Title 5" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), "Action,Adventure", "English", "Overview for popular movie 6. It's quite an interesting film about many things.", "/posters/popular6.jpg", 6, new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 126, "Popular Movie Title 6" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), "Comedy,Romance", "Spanish", "Overview for popular movie 7. It's quite an interesting film about many things.", "/posters/popular7.jpg", 7, new DateTime(2022, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 127, "Popular Movie Title 7" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), "Drama,Thriller", "English", "Overview for popular movie 8. It's quite an interesting film about many things.", "/posters/popular8.jpg", 8, new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 128, "Popular Movie Title 8" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), "Action,Adventure", "Spanish", "Overview for popular movie 9. It's quite an interesting film about many things.", "/posters/popular9.jpg", 9, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 129, "Popular Movie Title 9" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), "Comedy,Romance", "English", "Overview for popular movie 10. It's quite an interesting film about many things.", "/posters/popular10.jpg", 10, new DateTime(2015, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 130, "Popular Movie Title 10" },
                    { new Guid("00000000-0000-0000-0000-000000000011"), "Drama,Thriller", "Spanish", "Overview for popular movie 11. It's quite an interesting film about many things.", "/posters/popular11.jpg", 0, new DateTime(2016, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 131, "Popular Movie Title 11" },
                    { new Guid("00000000-0000-0000-0000-000000000012"), "Action,Adventure", "English", "Overview for popular movie 12. It's quite an interesting film about many things.", "/posters/popular12.jpg", 1, new DateTime(2017, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 132, "Popular Movie Title 12" },
                    { new Guid("00000000-0000-0000-0000-000000000013"), "Comedy,Romance", "Spanish", "Overview for popular movie 13. It's quite an interesting film about many things.", "/posters/popular13.jpg", 2, new DateTime(2018, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 133, "Popular Movie Title 13" },
                    { new Guid("00000000-0000-0000-0000-000000000014"), "Drama,Thriller", "English", "Overview for popular movie 14. It's quite an interesting film about many things.", "/posters/popular14.jpg", 3, new DateTime(2019, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 134, "Popular Movie Title 14" },
                    { new Guid("00000000-0000-0000-0000-000000000015"), "Action,Adventure", "Spanish", "Overview for popular movie 15. It's quite an interesting film about many things.", "/posters/popular15.jpg", 4, new DateTime(2020, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 135, "Popular Movie Title 15" },
                    { new Guid("00000000-0000-0000-0000-000000000016"), "Comedy,Romance", "English", "Overview for popular movie 16. It's quite an interesting film about many things.", "/posters/popular16.jpg", 5, new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 136, "Popular Movie Title 16" },
                    { new Guid("00000000-0000-0000-0000-000000000017"), "Drama,Thriller", "Spanish", "Overview for popular movie 17. It's quite an interesting film about many things.", "/posters/popular17.jpg", 6, new DateTime(2022, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 137, "Popular Movie Title 17" },
                    { new Guid("00000000-0000-0000-0000-000000000018"), "Action,Adventure", "English", "Overview for popular movie 18. It's quite an interesting film about many things.", "/posters/popular18.jpg", 7, new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 138, "Popular Movie Title 18" },
                    { new Guid("00000000-0000-0000-0000-000000000019"), "Comedy,Romance", "Spanish", "Overview for popular movie 19. It's quite an interesting film about many things.", "/posters/popular19.jpg", 8, new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 139, "Popular Movie Title 19" },
                    { new Guid("00000000-0000-0000-0000-000000000020"), "Drama,Thriller", "English", "Overview for popular movie 20. It's quite an interesting film about many things.", "/posters/popular20.jpg", 9, new DateTime(2015, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 140, "Popular Movie Title 20" },
                    { new Guid("00000000-0000-0000-0000-000000000021"), "Action,Adventure", "Spanish", "Overview for popular movie 21. It's quite an interesting film about many things.", "/posters/popular21.jpg", 10, new DateTime(2016, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 141, "Popular Movie Title 21" },
                    { new Guid("00000000-0000-0000-0000-000000000022"), "Comedy,Romance", "English", "Overview for popular movie 22. It's quite an interesting film about many things.", "/posters/popular22.jpg", 0, new DateTime(2017, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 142, "Popular Movie Title 22" },
                    { new Guid("00000000-0000-0000-0000-000000000023"), "Drama,Thriller", "Spanish", "Overview for popular movie 23. It's quite an interesting film about many things.", "/posters/popular23.jpg", 1, new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 143, "Popular Movie Title 23" },
                    { new Guid("00000000-0000-0000-0000-000000000024"), "Action,Adventure", "English", "Overview for popular movie 24. It's quite an interesting film about many things.", "/posters/popular24.jpg", 2, new DateTime(2019, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 144, "Popular Movie Title 24" },
                    { new Guid("00000000-0000-0000-0000-000000000025"), "Comedy,Romance", "Spanish", "Overview for popular movie 25. It's quite an interesting film about many things.", "/posters/popular25.jpg", 3, new DateTime(2020, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 145, "Popular Movie Title 25" },
                    { new Guid("00000000-0000-0000-0000-000000000026"), "Drama,Thriller", "English", "Overview for popular movie 26. It's quite an interesting film about many things.", "/posters/popular26.jpg", 4, new DateTime(2021, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 146, "Popular Movie Title 26" },
                    { new Guid("00000000-0000-0000-0000-000000000027"), "Action,Adventure", "Spanish", "Overview for popular movie 27. It's quite an interesting film about many things.", "/posters/popular27.jpg", 5, new DateTime(2022, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 147, "Popular Movie Title 27" },
                    { new Guid("00000000-0000-0000-0000-000000000028"), "Comedy,Romance", "English", "Overview for popular movie 28. It's quite an interesting film about many things.", "/posters/popular28.jpg", 6, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 148, "Popular Movie Title 28" },
                    { new Guid("00000000-0000-0000-0000-000000000029"), "Drama,Thriller", "Spanish", "Overview for popular movie 29. It's quite an interesting film about many things.", "/posters/popular29.jpg", 7, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 149, "Popular Movie Title 29" },
                    { new Guid("00000000-0000-0000-0000-000000000030"), "Action,Adventure", "English", "Overview for popular movie 30. It's quite an interesting film about many things.", "/posters/popular30.jpg", 8, new DateTime(2015, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 120, "Popular Movie Title 30" },
                    { new Guid("00000000-0000-0000-0000-000000000031"), "Comedy,Romance", "Spanish", "Overview for popular movie 31. It's quite an interesting film about many things.", "/posters/popular31.jpg", 9, new DateTime(2016, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 121, "Popular Movie Title 31" },
                    { new Guid("00000000-0000-0000-0000-000000000032"), "Drama,Thriller", "English", "Overview for popular movie 32. It's quite an interesting film about many things.", "/posters/popular32.jpg", 10, new DateTime(2017, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 122, "Popular Movie Title 32" },
                    { new Guid("00000000-0000-0000-0000-000000000033"), "Action,Adventure", "Spanish", "Overview for popular movie 33. It's quite an interesting film about many things.", "/posters/popular33.jpg", 0, new DateTime(2018, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 123, "Popular Movie Title 33" },
                    { new Guid("00000000-0000-0000-0000-000000000034"), "Comedy,Romance", "English", "Overview for popular movie 34. It's quite an interesting film about many things.", "/posters/popular34.jpg", 1, new DateTime(2019, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 124, "Popular Movie Title 34" },
                    { new Guid("00000000-0000-0000-0000-000000000035"), "Drama,Thriller", "Spanish", "Overview for popular movie 35. It's quite an interesting film about many things.", "/posters/popular35.jpg", 2, new DateTime(2020, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 125, "Popular Movie Title 35" },
                    { new Guid("00000000-0000-0000-0000-000000000036"), "Action,Adventure", "English", "Overview for popular movie 36. It's quite an interesting film about many things.", "/posters/popular36.jpg", 3, new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 126, "Popular Movie Title 36" },
                    { new Guid("00000000-0000-0000-0000-000000000037"), "Comedy,Romance", "Spanish", "Overview for popular movie 37. It's quite an interesting film about many things.", "/posters/popular37.jpg", 4, new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 127, "Popular Movie Title 37" },
                    { new Guid("00000000-0000-0000-0000-000000000038"), "Drama,Thriller", "English", "Overview for popular movie 38. It's quite an interesting film about many things.", "/posters/popular38.jpg", 5, new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 128, "Popular Movie Title 38" },
                    { new Guid("00000000-0000-0000-0000-000000000039"), "Action,Adventure", "Spanish", "Overview for popular movie 39. It's quite an interesting film about many things.", "/posters/popular39.jpg", 6, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 129, "Popular Movie Title 39" },
                    { new Guid("00000000-0000-0000-0000-000000000040"), "Comedy,Romance", "English", "Overview for popular movie 40. It's quite an interesting film about many things.", "/posters/popular40.jpg", 7, new DateTime(2015, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 130, "Popular Movie Title 40" },
                    { new Guid("00000000-0000-0000-0000-000000000041"), "Drama,Thriller", "Spanish", "Overview for popular movie 41. It's quite an interesting film about many things.", "/posters/popular41.jpg", 8, new DateTime(2016, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 131, "Popular Movie Title 41" },
                    { new Guid("00000000-0000-0000-0000-000000000042"), "Action,Adventure", "English", "Overview for popular movie 42. It's quite an interesting film about many things.", "/posters/popular42.jpg", 9, new DateTime(2017, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 132, "Popular Movie Title 42" },
                    { new Guid("00000000-0000-0000-0000-000000000043"), "Comedy,Romance", "Spanish", "Overview for popular movie 43. It's quite an interesting film about many things.", "/posters/popular43.jpg", 10, new DateTime(2018, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 133, "Popular Movie Title 43" },
                    { new Guid("00000000-0000-0000-0000-000000000044"), "Drama,Thriller", "English", "Overview for popular movie 44. It's quite an interesting film about many things.", "/posters/popular44.jpg", 0, new DateTime(2019, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 134, "Popular Movie Title 44" },
                    { new Guid("00000000-0000-0000-0000-000000000045"), "Action,Adventure", "Spanish", "Overview for popular movie 45. It's quite an interesting film about many things.", "/posters/popular45.jpg", 1, new DateTime(2020, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 135, "Popular Movie Title 45" },
                    { new Guid("00000000-0000-0000-0000-000000000046"), "Comedy,Romance", "English", "Overview for popular movie 46. It's quite an interesting film about many things.", "/posters/popular46.jpg", 2, new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 136, "Popular Movie Title 46" },
                    { new Guid("00000000-0000-0000-0000-000000000047"), "Drama,Thriller", "Spanish", "Overview for popular movie 47. It's quite an interesting film about many things.", "/posters/popular47.jpg", 3, new DateTime(2022, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 137, "Popular Movie Title 47" },
                    { new Guid("00000000-0000-0000-0000-000000000048"), "Action,Adventure", "English", "Overview for popular movie 48. It's quite an interesting film about many things.", "/posters/popular48.jpg", 4, new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 138, "Popular Movie Title 48" },
                    { new Guid("00000000-0000-0000-0000-000000000049"), "Comedy,Romance", "Spanish", "Overview for popular movie 49. It's quite an interesting film about many things.", "/posters/popular49.jpg", 5, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 139, "Popular Movie Title 49" },
                    { new Guid("00000000-0000-0000-0000-000000000050"), "Drama,Thriller", "English", "Overview for popular movie 50. It's quite an interesting film about many things.", "/posters/popular50.jpg", 6, new DateTime(2015, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 140, "Popular Movie Title 50" },
                    { new Guid("00000000-0000-0000-0000-000000000051"), "Action,Adventure", "Spanish", "Overview for popular movie 51. It's quite an interesting film about many things.", "/posters/popular51.jpg", 7, new DateTime(2016, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 141, "Popular Movie Title 51" },
                    { new Guid("00000000-0000-0000-0000-000000000052"), "Comedy,Romance", "English", "Overview for popular movie 52. It's quite an interesting film about many things.", "/posters/popular52.jpg", 8, new DateTime(2017, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 142, "Popular Movie Title 52" },
                    { new Guid("00000000-0000-0000-0000-000000000053"), "Drama,Thriller", "Spanish", "Overview for popular movie 53. It's quite an interesting film about many things.", "/posters/popular53.jpg", 9, new DateTime(2018, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 143, "Popular Movie Title 53" },
                    { new Guid("00000000-0000-0000-0000-000000000054"), "Action,Adventure", "English", "Overview for popular movie 54. It's quite an interesting film about many things.", "/posters/popular54.jpg", 10, new DateTime(2019, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 144, "Popular Movie Title 54" },
                    { new Guid("00000000-0000-0000-0000-000000000055"), "Comedy,Romance", "Spanish", "Overview for popular movie 55. It's quite an interesting film about many things.", "/posters/popular55.jpg", 0, new DateTime(2020, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 145, "Popular Movie Title 55" },
                    { new Guid("00000000-0000-0000-0000-000000000056"), "Drama,Thriller", "English", "Overview for popular movie 56. It's quite an interesting film about many things.", "/posters/popular56.jpg", 1, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 146, "Popular Movie Title 56" },
                    { new Guid("00000000-0000-0000-0000-000000000057"), "Action,Adventure", "Spanish", "Overview for popular movie 57. It's quite an interesting film about many things.", "/posters/popular57.jpg", 2, new DateTime(2022, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 147, "Popular Movie Title 57" },
                    { new Guid("00000000-0000-0000-0000-000000000058"), "Comedy,Romance", "English", "Overview for popular movie 58. It's quite an interesting film about many things.", "/posters/popular58.jpg", 3, new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 148, "Popular Movie Title 58" },
                    { new Guid("00000000-0000-0000-0000-000000000059"), "Drama,Thriller", "Spanish", "Overview for popular movie 59. It's quite an interesting film about many things.", "/posters/popular59.jpg", 4, new DateTime(2024, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 149, "Popular Movie Title 59" },
                    { new Guid("00000000-0000-0000-0000-000000000060"), "Action,Adventure", "English", "Overview for popular movie 60. It's quite an interesting film about many things.", "/posters/popular60.jpg", 5, new DateTime(2015, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 120, "Popular Movie Title 60" },
                    { new Guid("0d297f3c-b3fd-4425-9f34-a028c463e27c"), "Adventure,Action,Thriller", "English", "A police officer is brought out of suspended animation in prison to pursue.", "/posters/DemolitionMan.jpg", 6, new DateTime(1993, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 115, "Demolition Man" },
                    { new Guid("21564b30-2e22-4b32-b139-d831218ae401"), "Adventure,Action,Thriller", "English", " deadly threat from Earth's history reappears and a hunt for a lost artifact takes place.", "/posters/TransformersTheLastKnight.jpg", 5, new DateTime(2017, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 155, "Transformers: The Last Knight" },
                    { new Guid("de9f6727-6d75-49ae-a6df-7e4d827dfc25"), "Adventure,Action,Comedy", "English", "When Guy, a bank teller, learns that he is a non-player character in a bloodthirsty,.", "/posters/FreeGuy.jpg", 7, new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 115, "Free Guy" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000034"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000035"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000036"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000037"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000038"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000039"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000041"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000042"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000043"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000044"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000045"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000046"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000047"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000048"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000049"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000051"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000052"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000053"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000054"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000055"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000056"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000057"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000058"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000059"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000060"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("0d297f3c-b3fd-4425-9f34-a028c463e27c"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("21564b30-2e22-4b32-b139-d831218ae401"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("de9f6727-6d75-49ae-a6df-7e4d827dfc25"));
        }
    }
}
