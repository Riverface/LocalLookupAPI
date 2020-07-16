using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalLookupAPI.Migrations
{
    public partial class youreanallstar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "Address", "Blurb", "CityId", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 30, "Nothing", "All that glitters is gold", 30, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 139, "Nothing", "Only shooting stars break the mold", 139, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 140, "Nothing", "All that glitters is gold", 140, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 141, "Nothing", "Only shooting stars break the mold", 141, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 142, "Nothing", "All that glitters is gold", 142, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 143, "Nothing", "Only shooting stars break the mold", 143, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 144, "Nothing", "All that glitters is gold", 144, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 145, "Nothing", "Only shooting stars break the mold", 145, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 146, "Nothing", "All that glitters is gold", 146, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 147, "Nothing", "Only shooting stars break the mold", 147, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 148, "Nothing", "All that glitters is gold", 148, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 149, "Nothing", "Only shooting stars break the mold", 149, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 150, "Nothing", "All that glitters is gold", 150, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 151, "Nothing", "Only shooting stars break the mold", 151, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 152, "Nothing", "All that glitters is gold", 152, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 153, "Nothing", "Only shooting stars break the mold", 153, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 154, "Nothing", "All that glitters is gold", 154, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 155, "Nothing", "Only shooting stars break the mold", 155, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 138, "Nothing", "All that glitters is gold", 138, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 137, "Nothing", "Only shooting stars break the mold", 137, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 136, "Nothing", "All that glitters is gold", 136, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 135, "Nothing", "Only shooting stars break the mold", 135, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 117, "Nothing", "Only shooting stars break the mold", 117, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 118, "Nothing", "All that glitters is gold", 118, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 119, "Nothing", "Only shooting stars break the mold", 119, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 120, "Nothing", "All that glitters is gold", 120, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 121, "Nothing", "Only shooting stars break the mold", 121, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 122, "Nothing", "All that glitters is gold", 122, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 123, "Nothing", "Only shooting stars break the mold", 123, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 124, "Nothing", "All that glitters is gold", 124, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 156, "Nothing", "All that glitters is gold", 156, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 125, "Nothing", "Only shooting stars break the mold", 125, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 127, "Nothing", "Only shooting stars break the mold", 127, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 128, "Nothing", "All that glitters is gold", 128, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 129, "Nothing", "Only shooting stars break the mold", 129, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 130, "Nothing", "All that glitters is gold", 130, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 131, "Nothing", "Only shooting stars break the mold", 131, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 132, "Nothing", "All that glitters is gold", 132, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 133, "Nothing", "Only shooting stars break the mold", 133, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 134, "Nothing", "All that glitters is gold", 134, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 126, "Nothing", "All that glitters is gold", 126, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 116, "Nothing", "All that glitters is gold", 116, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 157, "Nothing", "Only shooting stars break the mold", 157, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 159, "Nothing", "Only shooting stars break the mold", 159, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 182, "Nothing", "All that glitters is gold", 182, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 183, "Nothing", "Only shooting stars break the mold", 183, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 184, "Nothing", "All that glitters is gold", 184, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 185, "Nothing", "Only shooting stars break the mold", 185, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 186, "Nothing", "All that glitters is gold", 186, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 187, "Nothing", "Only shooting stars break the mold", 187, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 188, "Nothing", "All that glitters is gold", 188, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 189, "Nothing", "Only shooting stars break the mold", 189, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 190, "Nothing", "All that glitters is gold", 190, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 191, "Nothing", "Only shooting stars break the mold", 191, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 192, "Nothing", "All that glitters is gold", 192, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 193, "Nothing", "Only shooting stars break the mold", 193, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 194, "Nothing", "All that glitters is gold", 194, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 195, "Nothing", "Only shooting stars break the mold", 195, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 196, "Nothing", "All that glitters is gold", 196, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 197, "Nothing", "Only shooting stars break the mold", 197, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 198, "Nothing", "All that glitters is gold", 198, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 181, "Nothing", "Only shooting stars break the mold", 181, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 180, "Nothing", "All that glitters is gold", 180, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 179, "Nothing", "Only shooting stars break the mold", 179, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 178, "Nothing", "All that glitters is gold", 178, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 160, "Nothing", "All that glitters is gold", 160, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 161, "Nothing", "Only shooting stars break the mold", 161, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 162, "Nothing", "All that glitters is gold", 162, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 163, "Nothing", "Only shooting stars break the mold", 163, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 164, "Nothing", "All that glitters is gold", 164, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 165, "Nothing", "Only shooting stars break the mold", 165, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 166, "Nothing", "All that glitters is gold", 166, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 167, "Nothing", "Only shooting stars break the mold", 167, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 158, "Nothing", "All that glitters is gold", 158, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 168, "Nothing", "All that glitters is gold", 168, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 170, "Nothing", "All that glitters is gold", 170, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 171, "Nothing", "Only shooting stars break the mold", 171, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 172, "Nothing", "All that glitters is gold", 172, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 173, "Nothing", "Only shooting stars break the mold", 173, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 174, "Nothing", "All that glitters is gold", 174, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 175, "Nothing", "Only shooting stars break the mold", 175, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 176, "Nothing", "All that glitters is gold", 176, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 177, "Nothing", "Only shooting stars break the mold", 177, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 169, "Nothing", "Only shooting stars break the mold", 169, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 115, "Nothing", "Only shooting stars break the mold", 115, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 199, "Nothing", "Only shooting stars break the mold", 199, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 113, "Nothing", "Only shooting stars break the mold", 113, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 53, "Nothing", "Only shooting stars break the mold", 53, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 54, "Nothing", "All that glitters is gold", 54, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 55, "Nothing", "Only shooting stars break the mold", 55, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 56, "Nothing", "All that glitters is gold", 56, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 57, "Nothing", "Only shooting stars break the mold", 57, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 58, "Nothing", "All that glitters is gold", 58, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 59, "Nothing", "Only shooting stars break the mold", 59, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 60, "Nothing", "All that glitters is gold", 60, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 61, "Nothing", "Only shooting stars break the mold", 61, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 62, "Nothing", "All that glitters is gold", 62, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 63, "Nothing", "Only shooting stars break the mold", 63, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 64, "Nothing", "All that glitters is gold", 64, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 65, "Nothing", "Only shooting stars break the mold", 65, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 66, "Nothing", "All that glitters is gold", 66, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 67, "Nothing", "Only shooting stars break the mold", 67, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 68, "Nothing", "All that glitters is gold", 68, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 69, "Nothing", "Only shooting stars break the mold", 69, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 114, "Nothing", "All that glitters is gold", 114, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 51, "Nothing", "Only shooting stars break the mold", 51, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 50, "Nothing", "All that glitters is gold", 50, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 49, "Nothing", "Only shooting stars break the mold", 49, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 31, "Nothing", "Only shooting stars break the mold", 31, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 32, "Nothing", "All that glitters is gold", 32, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 33, "Nothing", "Only shooting stars break the mold", 33, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 34, "Nothing", "All that glitters is gold", 34, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 35, "Nothing", "Only shooting stars break the mold", 35, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 36, "Nothing", "All that glitters is gold", 36, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 37, "Nothing", "Only shooting stars break the mold", 37, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 38, "Nothing", "All that glitters is gold", 38, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 70, "Nothing", "All that glitters is gold", 70, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 39, "Nothing", "Only shooting stars break the mold", 39, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 41, "Nothing", "Only shooting stars break the mold", 41, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 42, "Nothing", "All that glitters is gold", 42, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 43, "Nothing", "Only shooting stars break the mold", 43, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 44, "Nothing", "All that glitters is gold", 44, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 45, "Nothing", "Only shooting stars break the mold", 45, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 46, "Nothing", "All that glitters is gold", 46, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 47, "Nothing", "Only shooting stars break the mold", 47, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 48, "Nothing", "All that glitters is gold", 48, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 40, "Nothing", "All that glitters is gold", 40, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 71, "Nothing", "Only shooting stars break the mold", 71, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 52, "Nothing", "All that glitters is gold", 52, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 73, "Nothing", "Only shooting stars break the mold", 73, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 96, "Nothing", "All that glitters is gold", 96, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 97, "Nothing", "Only shooting stars break the mold", 97, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 98, "Nothing", "All that glitters is gold", 98, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 99, "Nothing", "Only shooting stars break the mold", 99, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 100, "Nothing", "All that glitters is gold", 100, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 101, "Nothing", "Only shooting stars break the mold", 101, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 103, "Nothing", "Only shooting stars break the mold", 103, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 104, "Nothing", "All that glitters is gold", 104, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 105, "Nothing", "Only shooting stars break the mold", 105, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 106, "Nothing", "All that glitters is gold", 106, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 107, "Nothing", "Only shooting stars break the mold", 107, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 108, "Nothing", "All that glitters is gold", 108, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 109, "Nothing", "Only shooting stars break the mold", 109, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 110, "Nothing", "All that glitters is gold", 110, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 111, "Nothing", "Only shooting stars break the mold", 111, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 112, "Nothing", "All that glitters is gold", 112, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 72, "Nothing", "All that glitters is gold", 72, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 95, "Nothing", "Only shooting stars break the mold", 95, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 94, "Nothing", "All that glitters is gold", 94, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 102, "Nothing", "All that glitters is gold", 102, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 92, "Nothing", "All that glitters is gold", 92, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 93, "Nothing", "Only shooting stars break the mold", 93, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 75, "Nothing", "Only shooting stars break the mold", 75, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 76, "Nothing", "All that glitters is gold", 76, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 77, "Nothing", "Only shooting stars break the mold", 77, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 78, "Nothing", "All that glitters is gold", 78, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 79, "Nothing", "Only shooting stars break the mold", 79, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 80, "Nothing", "All that glitters is gold", 80, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 81, "Nothing", "Only shooting stars break the mold", 81, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 82, "Nothing", "All that glitters is gold", 82, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 74, "Nothing", "All that glitters is gold", 74, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 84, "Nothing", "All that glitters is gold", 84, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 83, "Nothing", "Only shooting stars break the mold", 83, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 90, "Nothing", "All that glitters is gold", 90, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 89, "Nothing", "Only shooting stars break the mold", 89, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 88, "Nothing", "All that glitters is gold", 88, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 91, "Nothing", "Only shooting stars break the mold", 91, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 86, "Nothing", "All that glitters is gold", 86, "aNd tHey dOnT sToP cOMiNg", "Nothing" },
                    { 85, "Nothing", "Only shooting stars break the mold", 85, "AnD ThEY DoNt StOp ComInG", "Nothing" },
                    { 87, "Nothing", "Only shooting stars break the mold", 87, "AnD ThEY DoNt StOp ComInG", "Nothing" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "Name", "ZipCode" },
                values: new object[,]
                {
                    { 144, "It's a cool place", 94829 },
                    { 139, "It's a cool place", 94829 },
                    { 140, "It's a cool place", 94829 },
                    { 141, "It's a cool place", 94829 },
                    { 142, "It's a cool place", 94829 },
                    { 138, "It's a cool place", 94829 },
                    { 143, "It's a cool place", 94829 },
                    { 145, "It's a cool place", 94829 },
                    { 150, "It's a cool place", 94829 },
                    { 147, "It's a cool place", 94829 },
                    { 148, "It's a cool place", 94829 },
                    { 149, "It's a cool place", 94829 },
                    { 151, "It's a cool place", 94829 },
                    { 152, "It's a cool place", 94829 },
                    { 153, "It's a cool place", 94829 },
                    { 154, "It's a cool place", 94829 },
                    { 137, "It's a cool place", 94829 },
                    { 146, "It's a cool place", 94829 },
                    { 136, "It's a cool place", 94829 },
                    { 116, "It's a cool place", 94829 },
                    { 134, "It's a cool place", 94829 },
                    { 117, "It's a cool place", 94829 },
                    { 118, "It's a cool place", 94829 },
                    { 119, "It's a cool place", 94829 },
                    { 120, "It's a cool place", 94829 },
                    { 121, "It's a cool place", 94829 },
                    { 122, "It's a cool place", 94829 },
                    { 123, "It's a cool place", 94829 },
                    { 124, "It's a cool place", 94829 },
                    { 125, "It's a cool place", 94829 },
                    { 126, "It's a cool place", 94829 },
                    { 127, "It's a cool place", 94829 },
                    { 128, "It's a cool place", 94829 },
                    { 129, "It's a cool place", 94829 },
                    { 130, "It's a cool place", 94829 },
                    { 131, "It's a cool place", 94829 },
                    { 132, "It's a cool place", 94829 },
                    { 133, "It's a cool place", 94829 },
                    { 135, "It's a cool place", 94829 },
                    { 155, "It's a cool place", 94829 },
                    { 197, "It's a cool place", 94829 },
                    { 157, "It's a cool place", 94829 },
                    { 180, "It's a cool place", 94829 },
                    { 181, "It's a cool place", 94829 },
                    { 182, "It's a cool place", 94829 },
                    { 183, "It's a cool place", 94829 },
                    { 184, "It's a cool place", 94829 },
                    { 185, "It's a cool place", 94829 },
                    { 186, "It's a cool place", 94829 },
                    { 187, "It's a cool place", 94829 },
                    { 179, "It's a cool place", 94829 },
                    { 188, "It's a cool place", 94829 },
                    { 190, "It's a cool place", 94829 },
                    { 191, "It's a cool place", 94829 },
                    { 192, "It's a cool place", 94829 },
                    { 193, "It's a cool place", 94829 },
                    { 194, "It's a cool place", 94829 },
                    { 195, "It's a cool place", 94829 },
                    { 196, "It's a cool place", 94829 },
                    { 115, "It's a cool place", 94829 },
                    { 189, "It's a cool place", 94829 },
                    { 156, "It's a cool place", 94829 },
                    { 178, "It's a cool place", 94829 },
                    { 176, "It's a cool place", 94829 },
                    { 158, "It's a cool place", 94829 },
                    { 159, "It's a cool place", 94829 },
                    { 160, "It's a cool place", 94829 },
                    { 161, "It's a cool place", 94829 },
                    { 162, "It's a cool place", 94829 },
                    { 163, "It's a cool place", 94829 },
                    { 164, "It's a cool place", 94829 },
                    { 165, "It's a cool place", 94829 },
                    { 177, "It's a cool place", 94829 },
                    { 166, "It's a cool place", 94829 },
                    { 168, "It's a cool place", 94829 },
                    { 169, "It's a cool place", 94829 },
                    { 170, "It's a cool place", 94829 },
                    { 171, "It's a cool place", 94829 },
                    { 172, "It's a cool place", 94829 },
                    { 173, "It's a cool place", 94829 },
                    { 174, "It's a cool place", 94829 },
                    { 175, "It's a cool place", 94829 },
                    { 167, "It's a cool place", 94829 },
                    { 114, "It's a cool place", 94829 },
                    { 72, "It's a cool place", 94829 },
                    { 112, "It's a cool place", 94829 },
                    { 51, "It's a cool place", 94829 },
                    { 52, "It's a cool place", 94829 },
                    { 53, "It's a cool place", 94829 },
                    { 54, "It's a cool place", 94829 },
                    { 55, "It's a cool place", 94829 },
                    { 56, "It's a cool place", 94829 },
                    { 57, "It's a cool place", 94829 },
                    { 58, "It's a cool place", 94829 },
                    { 59, "It's a cool place", 94829 },
                    { 60, "It's a cool place", 94829 },
                    { 61, "It's a cool place", 94829 },
                    { 62, "It's a cool place", 94829 },
                    { 63, "It's a cool place", 94829 },
                    { 64, "It's a cool place", 94829 },
                    { 65, "It's a cool place", 94829 },
                    { 66, "It's a cool place", 94829 },
                    { 67, "It's a cool place", 94829 },
                    { 50, "It's a cool place", 94829 },
                    { 49, "It's a cool place", 94829 },
                    { 48, "It's a cool place", 94829 },
                    { 47, "It's a cool place", 94829 },
                    { 198, "It's a cool place", 94829 },
                    { 30, "It's a cool place", 94829 },
                    { 31, "It's a cool place", 94829 },
                    { 32, "It's a cool place", 94829 },
                    { 33, "It's a cool place", 94829 },
                    { 34, "It's a cool place", 94829 },
                    { 35, "It's a cool place", 94829 },
                    { 36, "It's a cool place", 94829 },
                    { 68, "It's a cool place", 94829 },
                    { 37, "It's a cool place", 94829 },
                    { 39, "It's a cool place", 94829 },
                    { 40, "It's a cool place", 94829 },
                    { 41, "It's a cool place", 94829 },
                    { 42, "It's a cool place", 94829 },
                    { 43, "It's a cool place", 94829 },
                    { 44, "It's a cool place", 94829 },
                    { 45, "It's a cool place", 94829 },
                    { 46, "It's a cool place", 94829 },
                    { 38, "It's a cool place", 94829 },
                    { 113, "It's a cool place", 94829 },
                    { 69, "It's a cool place", 94829 },
                    { 71, "It's a cool place", 94829 },
                    { 95, "It's a cool place", 94829 },
                    { 96, "It's a cool place", 94829 },
                    { 97, "It's a cool place", 94829 },
                    { 98, "It's a cool place", 94829 },
                    { 99, "It's a cool place", 94829 },
                    { 100, "It's a cool place", 94829 },
                    { 101, "It's a cool place", 94829 },
                    { 102, "It's a cool place", 94829 },
                    { 103, "It's a cool place", 94829 },
                    { 104, "It's a cool place", 94829 },
                    { 105, "It's a cool place", 94829 },
                    { 106, "It's a cool place", 94829 },
                    { 107, "It's a cool place", 94829 },
                    { 108, "It's a cool place", 94829 },
                    { 109, "It's a cool place", 94829 },
                    { 110, "It's a cool place", 94829 },
                    { 111, "It's a cool place", 94829 },
                    { 94, "It's a cool place", 94829 },
                    { 93, "It's a cool place", 94829 },
                    { 92, "It's a cool place", 94829 },
                    { 91, "It's a cool place", 94829 },
                    { 73, "It's a cool place", 94829 },
                    { 74, "It's a cool place", 94829 },
                    { 75, "It's a cool place", 94829 },
                    { 76, "It's a cool place", 94829 },
                    { 77, "It's a cool place", 94829 },
                    { 78, "It's a cool place", 94829 },
                    { 79, "It's a cool place", 94829 },
                    { 80, "It's a cool place", 94829 },
                    { 70, "It's a cool place", 94829 },
                    { 81, "It's a cool place", 94829 },
                    { 83, "It's a cool place", 94829 },
                    { 84, "It's a cool place", 94829 },
                    { 85, "It's a cool place", 94829 },
                    { 86, "It's a cool place", 94829 },
                    { 87, "It's a cool place", 94829 },
                    { 88, "It's a cool place", 94829 },
                    { 89, "It's a cool place", 94829 },
                    { 90, "It's a cool place", 94829 },
                    { 82, "It's a cool place", 94829 },
                    { 199, "It's a cool place", 94829 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 199);

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "Address", "Blurb", "CityId", "Name", "PhoneNumber" },
                values: new object[] { 2, "Nothing", "We buy butts", 1, "Nothing", "Nothing" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "Name", "ZipCode" },
                values: new object[] { 1, "Nothing", 94829 });
        }
    }
}
