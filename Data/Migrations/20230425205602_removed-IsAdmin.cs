using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class removedIsAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6e711d1c-25b2-448f-9567-c49abfc365df"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("960b4ae1-cd43-452c-bc15-c947e804b475"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6215b842-ab4d-4940-a28e-a5c21d9ea1ec"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("8bc5d17c-0401-4ef9-b295-8a1a607c1000"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("025c3c8b-7ca8-40b6-8ba4-d4f4164e49fa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("10a71ac3-9e3c-42af-a1c5-ee05aff80dc4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3de2e2bb-d0fb-46b2-8ce2-5a324f18e41e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("505d8e4b-f37d-431c-a5a5-450cff959a1a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a67b958d-0d2d-4886-abf4-48ef535f37ad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba4e4226-7788-470a-9af4-07adacffaaf3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bce20b2e-8f3a-4aae-81e7-85967c9ef9fc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d02f6a5c-c0d4-4868-9bb1-3bde112f6fca"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("1e82b789-54fd-4a94-bb4b-5f47732cb152"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("3ac76f2d-24d3-4a3a-a8bf-eb218d65a0e7"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("828d6d61-2320-4863-9dbd-7b2468aede7e"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("97605215-0e59-4d1b-b980-b8379fb1db10"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("a8e48c56-5033-4b7a-8333-aac523d1297a"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("aa663b93-712f-4021-b38b-804c85455ec7"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("b66d646c-b79e-476b-91a3-a0e813c2baee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11273c30-ff1f-4b50-9663-8a57eed70c9f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5365b64f-f746-4da3-989f-16b2ba071976"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e2763412-0851-4187-a9ad-fe9b89689f96"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fe7cc45d-4b3c-4b58-a7e8-2b5b83a2ee61"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a206db4f-2fdd-40b4-88ef-2c14f85c97be"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cdf7870a-7d49-4180-ae2c-e5df90c9b062"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ebe977a7-1773-4b23-a677-b7f3200599ba"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("223ef92a-5335-4937-ae06-79cb496751be"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("570afee0-edd2-46d9-8367-1d8f2fbd4170"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("93d982fb-1ae1-4d40-aef4-39e42baec339"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("d885770e-f4cd-449a-bd8b-05872ffba755"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("633efeda-466b-4302-aa7a-9c192f4a3c9a"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("8289ce7e-053a-448d-b95e-e6c2e03334b9"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("8a54d209-31a2-4c4f-8ae9-e2e7658b1ebd"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("c1e011fc-3d3c-4264-a0a1-ea9aea2d727f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("42b2a4d1-f4db-4460-a5f0-3a7e781fc94b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4b31f369-2831-4395-8a82-da860c087cbe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("56cf1149-4439-4d8e-8fe3-915b0cc92c9c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eed6b2dd-2cb4-4837-8577-76afef6d4d84"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a02beb2-8b06-49db-9ba1-f27e82661e76"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d3910333-fe03-42d7-8e3d-ac8f2d09df25"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1d10f377-df33-496d-8193-592e60af558f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8b0a1921-8b16-4e62-a043-a50635d3d76c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fd837fab-fa42-4800-93c5-51849f7dc753"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("34c69446-cc0a-425c-8fb7-ef6c78a478f8"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("89ce41d1-aff7-4585-800c-3e838e8ec568"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("aeab178a-eecd-4f2d-908c-44cb0a58801c"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("eaa0f6db-db14-4c14-8260-5ceb6774629d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2004586a-e34a-48a1-8068-598559b2be37"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("611b1eb0-1aff-4f21-b497-1e697ce67c19"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("77e6eedf-891d-45af-9888-8dff22b9018d"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "Schema" },
                values: new object[,]
                {
                    { new Guid("0943faab-f029-44c3-bfb3-3bf1bdf490d1"), "Furniture for sitting", "Furniture", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"name\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"color\": {\r\n      \"type\": \"string\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("1fd7ac59-6f1d-439d-a6a1-3a94316110c6"), "Food for eating", "Food", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"name\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"ingredients\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("363f235a-cba6-4e3f-ba07-53ce7ee633d5"), "Books for reading", "Books", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"name\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"author\": {\r\n      \"type\": \"string\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("70ae5aad-4f35-4823-8ad4-c05b3f146155"), "Electronics for using", "Electronics", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"name\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"voltage\": {\r\n      \"type\": \"string\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("cee2cf25-7860-426d-b37f-caebe546f678"), "Clothes for wearing", "Clothes", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"name\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"size\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("d5a18a1e-3f0b-4f06-acd1-569bf58960ab"), "Vehicles for driving", "Vehicles", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"name\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"color\": {\r\n      \"type\": \"string\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("f1e5eac1-9598-4dd8-bd67-17fb9b45dc1e"), "Toys for playing", "Toys", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"name\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"aimedFor\": {\r\n      \"type\": \"string\"\r\n    }\r\n  }\r\n}" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { new Guid("37f5fa7a-d3af-479b-96cf-27b5b65edc04"), "https://www.countryflags.io/hr/flat/64.png", "Croatia" },
                    { new Guid("46316c03-a146-4488-a187-008a1aeb7749"), "https://www.countryflags.io/ba/flat/64.png", "Bosnia and Herzegovina" },
                    { new Guid("4bad97a8-b9c6-4606-bdca-097f437f5caf"), "https://www.countryflags.io/al/flat/64.png", "Albania" },
                    { new Guid("c88fa1f4-9729-4cc4-ab0b-34cc2c8d4b3c"), "https://www.countryflags.io/mk/flat/64.png", "Macedonia" },
                    { new Guid("db65ccb6-d5e0-47a6-b206-1e71e8d16182"), "https://www.countryflags.io/si/flat/64.png", "Slovenia" },
                    { new Guid("fa1ad28c-9505-4685-a7ea-92ff64f60ae4"), "https://www.countryflags.io/rs/flat/64.png", "Serbia" },
                    { new Guid("fb91669a-73c0-4af6-bea0-e4376d1acf68"), "https://www.countryflags.io/me/flat/64.png", "Montenegro" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "CountryId", "Latitude", "Longitude", "Name" },
                values: new object[,]
                {
                    { new Guid("0c54faa4-0677-4047-b5de-4dbc22b94afc"), new Guid("fb91669a-73c0-4af6-bea0-e4376d1acf68"), 46.056946m, 14.505751m, "Ljubljana" },
                    { new Guid("17154c23-eae3-44cf-ac01-da549bb09d49"), new Guid("37f5fa7a-d3af-479b-96cf-27b5b65edc04"), 45.815010m, 15.981919m, "Zagreb" },
                    { new Guid("233ff0c5-8e2b-438b-a042-3f3492d9dfd2"), new Guid("fa1ad28c-9505-4685-a7ea-92ff64f60ae4"), 45.251667m, 19.836944m, "Novi Sad" },
                    { new Guid("2c05a698-a94f-42b3-8d99-f221f7a4941b"), new Guid("37f5fa7a-d3af-479b-96cf-27b5b65edc04"), 42.460201m, 19.259995m, "Podgorica" },
                    { new Guid("afd8bb36-3881-4bb0-a61a-8f2bf2a78a49"), new Guid("fa1ad28c-9505-4685-a7ea-92ff64f60ae4"), 44.786568m, 20.448921m, "Belgrade" },
                    { new Guid("bb8dc4af-fc43-4966-96b8-2b15d5900f27"), new Guid("fa1ad28c-9505-4685-a7ea-92ff64f60ae4"), 43.856258m, 18.413076m, "Sarajevo" },
                    { new Guid("cfde2a17-4ab2-4eab-85c8-ce723f93199c"), new Guid("db65ccb6-d5e0-47a6-b206-1e71e8d16182"), 20.056946m, 4.505751m, "othertown" },
                    { new Guid("d5624734-40da-4844-bb7d-9810ba1a9a8a"), new Guid("46316c03-a146-4488-a187-008a1aeb7749"), 42.002876m, 21.436935m, "Skopje" },
                    { new Guid("efba08a9-544c-4f50-90c0-5656763cc927"), new Guid("c88fa1f4-9729-4cc4-ab0b-34cc2c8d4b3c"), 40.056946m, 10.505751m, "Town" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Schema" },
                values: new object[,]
                {
                    { new Guid("3adf8410-611e-4f7b-ae6a-48b8248717f6"), new Guid("d5a18a1e-3f0b-4f06-acd1-569bf58960ab"), "Bikes for driving", "Bikes", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"brand\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"handles\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("50112b93-9feb-4301-a294-049883c171d0"), new Guid("cee2cf25-7860-426d-b37f-caebe546f678"), "Pants for wearing", "Pants", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"material\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"shades\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("62a496b4-492d-475d-a26e-2e70bbeb3fe3"), new Guid("363f235a-cba6-4e3f-ba07-53ce7ee633d5"), "Novels for reading", "Novels", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"genre\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"themes\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("6802cf9c-2c75-4424-b723-408f8307ddf9"), new Guid("1fd7ac59-6f1d-439d-a6a1-3a94316110c6"), "Meat for eating", "Meat", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"taste\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"colors\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("8f06b2a1-28c5-4c61-ad8f-193f11966fea"), new Guid("70ae5aad-4f35-4823-8ad4-c05b3f146155"), "Phones for using", "Phones", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"brand\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"colors\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("aa56f432-c8f5-4277-a46a-eaf2d1017aef"), new Guid("70ae5aad-4f35-4823-8ad4-c05b3f146155"), "Laptops for using", "Laptops", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"brand\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"screensizes\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("b26b0570-f741-46c0-b2cf-432f9aeceb0b"), new Guid("363f235a-cba6-4e3f-ba07-53ce7ee633d5"), "Comics for reading", "Comics", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"genre\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"characters\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("b991f2f6-257c-4620-a6aa-19a8e93248e6"), new Guid("cee2cf25-7860-426d-b37f-caebe546f678"), "Shirts for wearing", "Shirts", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"material\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"colors\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("d6ca0d51-c327-4002-8352-e715b6f9070a"), new Guid("1fd7ac59-6f1d-439d-a6a1-3a94316110c6"), "Fruits for eating", "Fruits", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"sweetLevel\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"colors\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("d85089b5-0275-4255-a558-9aa6fc021c44"), new Guid("d5a18a1e-3f0b-4f06-acd1-569bf58960ab"), "Cars for driving", "Cars", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"brand\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"motors\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("f4c2ce93-9705-4711-b3b7-8bdc78de4dc3"), new Guid("1fd7ac59-6f1d-439d-a6a1-3a94316110c6"), "Vegetables for eating", "Vegetables", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"sourLevel\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"colors\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AddressId", "CreatedAt", "Email", "Name", "Password", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("5340d227-9b39-495f-9ac2-7e59d85a899c"), new Guid("bb8dc4af-fc43-4966-96b8-2b15d5900f27"), new DateTime(2023, 4, 25, 20, 56, 2, 181, DateTimeKind.Utc).AddTicks(9565), "admin@gmail.com", "Admin", "123456", new DateTime(2023, 4, 25, 20, 56, 2, 181, DateTimeKind.Utc).AddTicks(9565) },
                    { new Guid("970d35d3-4e85-4c8c-be72-07c5ef2bb419"), new Guid("d5624734-40da-4844-bb7d-9810ba1a9a8a"), new DateTime(2023, 4, 25, 20, 56, 2, 181, DateTimeKind.Utc).AddTicks(9567), "admin2@gmail.com", "Admin2", "123456", new DateTime(2023, 4, 25, 20, 56, 2, 181, DateTimeKind.Utc).AddTicks(9567) },
                    { new Guid("a91c99a8-78ec-458b-98da-543bcbd8c945"), new Guid("afd8bb36-3881-4bb0-a61a-8f2bf2a78a49"), new DateTime(2023, 4, 25, 20, 56, 2, 181, DateTimeKind.Utc).AddTicks(9554), "John@gmail.com", "John", "123456", new DateTime(2023, 4, 25, 20, 56, 2, 181, DateTimeKind.Utc).AddTicks(9556) },
                    { new Guid("c008bba0-8bc1-4058-b071-ae6556d5573f"), new Guid("2c05a698-a94f-42b3-8d99-f221f7a4941b"), new DateTime(2023, 4, 25, 20, 56, 2, 181, DateTimeKind.Utc).AddTicks(9569), "admin3@gmail.com", "Admin3", "123sdda456", new DateTime(2023, 4, 25, 20, 56, 2, 181, DateTimeKind.Utc).AddTicks(9570) },
                    { new Guid("d21381ef-d7d5-48f4-b4b0-9e16586c0f16"), new Guid("0c54faa4-0677-4047-b5de-4dbc22b94afc"), new DateTime(2023, 4, 25, 20, 56, 2, 181, DateTimeKind.Utc).AddTicks(9575), "none@gmail.com", "nonexistant", "123456", new DateTime(2023, 4, 25, 20, 56, 2, 181, DateTimeKind.Utc).AddTicks(9576) },
                    { new Guid("de713641-526d-42af-bc02-49b8b2949787"), new Guid("efba08a9-544c-4f50-90c0-5656763cc927"), new DateTime(2023, 4, 25, 20, 56, 2, 181, DateTimeKind.Utc).AddTicks(9573), "DebyDebyDoo@gmail.com", "DebyDoo", "debugger", new DateTime(2023, 4, 25, 20, 56, 2, 181, DateTimeKind.Utc).AddTicks(9573) },
                    { new Guid("e032fe70-004c-4b9f-a29f-6703a8510f14"), new Guid("cfde2a17-4ab2-4eab-85c8-ce723f93199c"), new DateTime(2023, 4, 25, 20, 56, 2, 181, DateTimeKind.Utc).AddTicks(9578), "duje@gmail.com", "duje", "1111", new DateTime(2023, 4, 25, 20, 56, 2, 181, DateTimeKind.Utc).AddTicks(9578) },
                    { new Guid("fcdda975-2cd7-4156-9fa0-f3a4c15d349c"), new Guid("233ff0c5-8e2b-438b-a042-3f3492d9dfd2"), new DateTime(2023, 4, 25, 20, 56, 2, 181, DateTimeKind.Utc).AddTicks(9560), "Jane@gmail.com", "Jane", "123456", new DateTime(2023, 4, 25, 20, 56, 2, 181, DateTimeKind.Utc).AddTicks(9560) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Created", "Description", "ExtraProperties", "Images", "LocationId", "Name", "Price", "Quantity", "SellerId", "SubCategoryId", "SubProperties" },
                values: new object[,]
                {
                    { new Guid("0ba565df-1d3f-4b60-8ea0-ad28f4912b96"), new Guid("cee2cf25-7860-426d-b37f-caebe546f678"), new DateTime(2023, 4, 25, 20, 56, 2, 181, DateTimeKind.Utc).AddTicks(9851), "Shoes for wearing", "{\r\n  \"material\": \"cotton\",\r\n  \"voltage\": [\r\n    \"250V\",\r\n    \"100V\"\r\n  ]\r\n}", new List<string> { "https://i.imgur.com/1Q1Z1Zm.jpg" }, new Guid("afd8bb36-3881-4bb0-a61a-8f2bf2a78a49"), "Shoes", 30m, 30, new Guid("970d35d3-4e85-4c8c-be72-07c5ef2bb419"), new Guid("50112b93-9feb-4301-a294-049883c171d0"), "{\r\n  \"name\": \"cotton\",\r\n  \"size\": [\r\n    \"red\",\r\n    \"blue\"\r\n  ]\r\n}" },
                    { new Guid("34b3ee0f-afc2-410b-baa8-cd6f921c95d2"), new Guid("70ae5aad-4f35-4823-8ad4-c05b3f146155"), new DateTime(2023, 4, 25, 20, 56, 2, 181, DateTimeKind.Utc).AddTicks(9934), "Laptop for working", "{\r\n  \"name\": \"cotton\",\r\n  \"voltage\": [\r\n    \"250V\",\r\n    \"100V\"\r\n  ]\r\n}", new List<string> { "https://i.imgur.com/1Q1Z1Zm.jpg" }, new Guid("afd8bb36-3881-4bb0-a61a-8f2bf2a78a49"), "Windows Laptop", 500m, 5, new Guid("c008bba0-8bc1-4058-b071-ae6556d5573f"), new Guid("aa56f432-c8f5-4277-a46a-eaf2d1017aef"), "{\r\n  \"brand\": \"cotton\",\r\n  \"screensizes\": [\r\n    \"1000p\",\r\n    \"400p\"\r\n  ]\r\n}" },
                    { new Guid("3b596221-166b-4799-93c7-c2579a7720cd"), new Guid("70ae5aad-4f35-4823-8ad4-c05b3f146155"), new DateTime(2023, 4, 25, 20, 56, 2, 182, DateTimeKind.Utc).AddTicks(113), "Laptop for working", "{\r\n  \"name\": \"asus\",\r\n  \"voltage\": [\r\n    \"250V\",\r\n    \"100V\"\r\n  ]\r\n}", new List<string> { "https://i.imgur.com/1Q1Z1Zm.jpg" }, new Guid("233ff0c5-8e2b-438b-a042-3f3492d9dfd2"), "Asus Laptop", 1000m, 5, new Guid("fcdda975-2cd7-4156-9fa0-f3a4c15d349c"), new Guid("aa56f432-c8f5-4277-a46a-eaf2d1017aef"), "{\r\n  \"brand\": \"asus\",\r\n  \"screensizes\": [\r\n    \"10300p\",\r\n    \"4100p\"\r\n  ]\r\n}" },
                    { new Guid("bd9423c7-0c31-4366-a500-a08bf3f1189e"), new Guid("70ae5aad-4f35-4823-8ad4-c05b3f146155"), new DateTime(2023, 4, 25, 20, 56, 2, 182, DateTimeKind.Utc).AddTicks(341), "Iphone 11 for working", "{\r\n  \"name\": \"iphone\",\r\n  \"voltage\": [\r\n    \"150V\",\r\n    \"100V\"\r\n  ]\r\n}", new List<string> { "https://i.imgur.com/1Q1Z1Zm.jpg" }, new Guid("233ff0c5-8e2b-438b-a042-3f3492d9dfd2"), "Iphone 11", 1000m, 5, new Guid("fcdda975-2cd7-4156-9fa0-f3a4c15d349c"), new Guid("8f06b2a1-28c5-4c61-ad8f-193f11966fea"), "{\r\n  \"brand\": \"apple\",\r\n  \"colors\": [\r\n    \"red\",\r\n    \"blue\"\r\n  ]\r\n}" },
                    { new Guid("c5330fa8-9be0-4734-a9fe-5308036e81f0"), new Guid("cee2cf25-7860-426d-b37f-caebe546f678"), new DateTime(2023, 4, 25, 20, 56, 2, 181, DateTimeKind.Utc).AddTicks(9744), "Jeans for wearing", "{\r\n  \"name\": \"cotton\",\r\n  \"size\": [\r\n    \"red\",\r\n    \"blue\"\r\n  ]\r\n}", new List<string> { "https://i.imgur.com/1Q1Z1Zm.jpg" }, new Guid("afd8bb36-3881-4bb0-a61a-8f2bf2a78a49"), "Jeans", 20m, 20, new Guid("a91c99a8-78ec-458b-98da-543bcbd8c945"), new Guid("50112b93-9feb-4301-a294-049883c171d0"), "{\r\n  \"material\": \"cotton\",\r\n  \"shades\": [\r\n    \"red\",\r\n    \"blue\"\r\n  ]\r\n}" },
                    { new Guid("eee5d1d8-48fb-4a86-9e08-5274d8805f7e"), new Guid("70ae5aad-4f35-4823-8ad4-c05b3f146155"), new DateTime(2023, 4, 25, 20, 56, 2, 182, DateTimeKind.Utc).AddTicks(13), "Laptop for working", "{\r\n  \"name\": \"macbook\",\r\n  \"voltage\": [\r\n    \"250V\",\r\n    \"100V\"\r\n  ]\r\n}", new List<string> { "https://i.imgur.com/1Q1Z1Zm.jpg" }, new Guid("2c05a698-a94f-42b3-8d99-f221f7a4941b"), "MacBook", 1000m, 5, new Guid("970d35d3-4e85-4c8c-be72-07c5ef2bb419"), new Guid("aa56f432-c8f5-4277-a46a-eaf2d1017aef"), "{\r\n  \"brand\": \"apple\",\r\n  \"screensizes\": [\r\n    \"1000p\",\r\n    \"400p\"\r\n  ]\r\n}" },
                    { new Guid("f1d447db-3002-4f0d-8bca-52380dbc160e"), new Guid("cee2cf25-7860-426d-b37f-caebe546f678"), new DateTime(2023, 4, 25, 20, 56, 2, 181, DateTimeKind.Utc).AddTicks(9587), "T-Shirt for wearing", "{\r\n  \"name\": \"cotton\",\r\n  \"size\": [\r\n    \"red\",\r\n    \"blue\"\r\n  ]\r\n}", new List<string> { "https://i.imgur.com/1Q1Z1Zm.jpg" }, new Guid("afd8bb36-3881-4bb0-a61a-8f2bf2a78a49"), "T-Shirt", 10m, 10, new Guid("a91c99a8-78ec-458b-98da-543bcbd8c945"), new Guid("b991f2f6-257c-4620-a6aa-19a8e93248e6"), "{\r\n  \"material\": \"cotton\",\r\n  \"colors\": [\r\n    \"red\",\r\n    \"blue\"\r\n  ]\r\n}" },
                    { new Guid("f3a94acf-ba01-42c1-88d8-d0466e7695e4"), new Guid("70ae5aad-4f35-4823-8ad4-c05b3f146155"), new DateTime(2023, 4, 25, 20, 56, 2, 182, DateTimeKind.Utc).AddTicks(262), "Iphone 12 for working", "{\r\n  \"name\": \"iphone\",\r\n  \"voltage\": [\r\n    \"250V\",\r\n    \"100V\"\r\n  ]\r\n}", new List<string> { "https://i.imgur.com/1Q1Z1Zm.jpg" }, new Guid("233ff0c5-8e2b-438b-a042-3f3492d9dfd2"), "Iphone 12", 1000m, 5, new Guid("fcdda975-2cd7-4156-9fa0-f3a4c15d349c"), new Guid("8f06b2a1-28c5-4c61-ad8f-193f11966fea"), "{\r\n  \"brand\": \"apple\",\r\n  \"colors\": [\r\n    \"red\",\r\n    \"blue\"\r\n  ]\r\n}" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0943faab-f029-44c3-bfb3-3bf1bdf490d1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f1e5eac1-9598-4dd8-bd67-17fb9b45dc1e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4bad97a8-b9c6-4606-bdca-097f437f5caf"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("17154c23-eae3-44cf-ac01-da549bb09d49"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ba565df-1d3f-4b60-8ea0-ad28f4912b96"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("34b3ee0f-afc2-410b-baa8-cd6f921c95d2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3b596221-166b-4799-93c7-c2579a7720cd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bd9423c7-0c31-4366-a500-a08bf3f1189e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c5330fa8-9be0-4734-a9fe-5308036e81f0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eee5d1d8-48fb-4a86-9e08-5274d8805f7e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f1d447db-3002-4f0d-8bca-52380dbc160e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f3a94acf-ba01-42c1-88d8-d0466e7695e4"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("3adf8410-611e-4f7b-ae6a-48b8248717f6"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("62a496b4-492d-475d-a26e-2e70bbeb3fe3"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("6802cf9c-2c75-4424-b723-408f8307ddf9"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("b26b0570-f741-46c0-b2cf-432f9aeceb0b"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("d6ca0d51-c327-4002-8352-e715b6f9070a"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("d85089b5-0275-4255-a558-9aa6fc021c44"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f4c2ce93-9705-4711-b3b7-8bdc78de4dc3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5340d227-9b39-495f-9ac2-7e59d85a899c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d21381ef-d7d5-48f4-b4b0-9e16586c0f16"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("de713641-526d-42af-bc02-49b8b2949787"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e032fe70-004c-4b9f-a29f-6703a8510f14"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1fd7ac59-6f1d-439d-a6a1-3a94316110c6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("363f235a-cba6-4e3f-ba07-53ce7ee633d5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d5a18a1e-3f0b-4f06-acd1-569bf58960ab"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("0c54faa4-0677-4047-b5de-4dbc22b94afc"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("bb8dc4af-fc43-4966-96b8-2b15d5900f27"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("cfde2a17-4ab2-4eab-85c8-ce723f93199c"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("efba08a9-544c-4f50-90c0-5656763cc927"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("50112b93-9feb-4301-a294-049883c171d0"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("8f06b2a1-28c5-4c61-ad8f-193f11966fea"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("aa56f432-c8f5-4277-a46a-eaf2d1017aef"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("b991f2f6-257c-4620-a6aa-19a8e93248e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("970d35d3-4e85-4c8c-be72-07c5ef2bb419"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a91c99a8-78ec-458b-98da-543bcbd8c945"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c008bba0-8bc1-4058-b071-ae6556d5573f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fcdda975-2cd7-4156-9fa0-f3a4c15d349c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("70ae5aad-4f35-4823-8ad4-c05b3f146155"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cee2cf25-7860-426d-b37f-caebe546f678"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c88fa1f4-9729-4cc4-ab0b-34cc2c8d4b3c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("db65ccb6-d5e0-47a6-b206-1e71e8d16182"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fb91669a-73c0-4af6-bea0-e4376d1acf68"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("233ff0c5-8e2b-438b-a042-3f3492d9dfd2"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("2c05a698-a94f-42b3-8d99-f221f7a4941b"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("afd8bb36-3881-4bb0-a61a-8f2bf2a78a49"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("d5624734-40da-4844-bb7d-9810ba1a9a8a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("37f5fa7a-d3af-479b-96cf-27b5b65edc04"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("46316c03-a146-4488-a187-008a1aeb7749"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fa1ad28c-9505-4685-a7ea-92ff64f60ae4"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "Schema" },
                values: new object[,]
                {
                    { new Guid("6e711d1c-25b2-448f-9567-c49abfc365df"), "Furniture for sitting", "Furniture", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"name\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"color\": {\r\n      \"type\": \"string\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("8a02beb2-8b06-49db-9ba1-f27e82661e76"), "Electronics for using", "Electronics", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"name\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"voltage\": {\r\n      \"type\": \"string\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("960b4ae1-cd43-452c-bc15-c947e804b475"), "Toys for playing", "Toys", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"name\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"aimedFor\": {\r\n      \"type\": \"string\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("a206db4f-2fdd-40b4-88ef-2c14f85c97be"), "Vehicles for driving", "Vehicles", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"name\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"color\": {\r\n      \"type\": \"string\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("cdf7870a-7d49-4180-ae2c-e5df90c9b062"), "Books for reading", "Books", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"name\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"author\": {\r\n      \"type\": \"string\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("d3910333-fe03-42d7-8e3d-ac8f2d09df25"), "Clothes for wearing", "Clothes", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"name\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"size\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("ebe977a7-1773-4b23-a677-b7f3200599ba"), "Food for eating", "Food", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"name\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"ingredients\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { new Guid("1d10f377-df33-496d-8193-592e60af558f"), "https://www.countryflags.io/si/flat/64.png", "Slovenia" },
                    { new Guid("2004586a-e34a-48a1-8068-598559b2be37"), "https://www.countryflags.io/hr/flat/64.png", "Croatia" },
                    { new Guid("611b1eb0-1aff-4f21-b497-1e697ce67c19"), "https://www.countryflags.io/rs/flat/64.png", "Serbia" },
                    { new Guid("6215b842-ab4d-4940-a28e-a5c21d9ea1ec"), "https://www.countryflags.io/al/flat/64.png", "Albania" },
                    { new Guid("77e6eedf-891d-45af-9888-8dff22b9018d"), "https://www.countryflags.io/ba/flat/64.png", "Bosnia and Herzegovina" },
                    { new Guid("8b0a1921-8b16-4e62-a043-a50635d3d76c"), "https://www.countryflags.io/me/flat/64.png", "Montenegro" },
                    { new Guid("fd837fab-fa42-4800-93c5-51849f7dc753"), "https://www.countryflags.io/mk/flat/64.png", "Macedonia" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "CountryId", "Latitude", "Longitude", "Name" },
                values: new object[,]
                {
                    { new Guid("223ef92a-5335-4937-ae06-79cb496751be"), new Guid("611b1eb0-1aff-4f21-b497-1e697ce67c19"), 43.856258m, 18.413076m, "Sarajevo" },
                    { new Guid("34c69446-cc0a-425c-8fb7-ef6c78a478f8"), new Guid("611b1eb0-1aff-4f21-b497-1e697ce67c19"), 45.251667m, 19.836944m, "Novi Sad" },
                    { new Guid("570afee0-edd2-46d9-8367-1d8f2fbd4170"), new Guid("8b0a1921-8b16-4e62-a043-a50635d3d76c"), 46.056946m, 14.505751m, "Ljubljana" },
                    { new Guid("89ce41d1-aff7-4585-800c-3e838e8ec568"), new Guid("2004586a-e34a-48a1-8068-598559b2be37"), 42.460201m, 19.259995m, "Podgorica" },
                    { new Guid("8bc5d17c-0401-4ef9-b295-8a1a607c1000"), new Guid("2004586a-e34a-48a1-8068-598559b2be37"), 45.815010m, 15.981919m, "Zagreb" },
                    { new Guid("93d982fb-1ae1-4d40-aef4-39e42baec339"), new Guid("fd837fab-fa42-4800-93c5-51849f7dc753"), 40.056946m, 10.505751m, "Town" },
                    { new Guid("aeab178a-eecd-4f2d-908c-44cb0a58801c"), new Guid("611b1eb0-1aff-4f21-b497-1e697ce67c19"), 44.786568m, 20.448921m, "Belgrade" },
                    { new Guid("d885770e-f4cd-449a-bd8b-05872ffba755"), new Guid("1d10f377-df33-496d-8193-592e60af558f"), 20.056946m, 4.505751m, "othertown" },
                    { new Guid("eaa0f6db-db14-4c14-8260-5ceb6774629d"), new Guid("77e6eedf-891d-45af-9888-8dff22b9018d"), 42.002876m, 21.436935m, "Skopje" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Schema" },
                values: new object[,]
                {
                    { new Guid("1e82b789-54fd-4a94-bb4b-5f47732cb152"), new Guid("ebe977a7-1773-4b23-a677-b7f3200599ba"), "Vegetables for eating", "Vegetables", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"sourLevel\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"colors\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("3ac76f2d-24d3-4a3a-a8bf-eb218d65a0e7"), new Guid("ebe977a7-1773-4b23-a677-b7f3200599ba"), "Meat for eating", "Meat", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"taste\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"colors\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("633efeda-466b-4302-aa7a-9c192f4a3c9a"), new Guid("d3910333-fe03-42d7-8e3d-ac8f2d09df25"), "Shirts for wearing", "Shirts", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"material\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"colors\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("8289ce7e-053a-448d-b95e-e6c2e03334b9"), new Guid("8a02beb2-8b06-49db-9ba1-f27e82661e76"), "Laptops for using", "Laptops", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"brand\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"screensizes\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("828d6d61-2320-4863-9dbd-7b2468aede7e"), new Guid("ebe977a7-1773-4b23-a677-b7f3200599ba"), "Fruits for eating", "Fruits", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"sweetLevel\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"colors\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("8a54d209-31a2-4c4f-8ae9-e2e7658b1ebd"), new Guid("8a02beb2-8b06-49db-9ba1-f27e82661e76"), "Phones for using", "Phones", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"brand\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"colors\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("97605215-0e59-4d1b-b980-b8379fb1db10"), new Guid("a206db4f-2fdd-40b4-88ef-2c14f85c97be"), "Cars for driving", "Cars", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"brand\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"motors\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("a8e48c56-5033-4b7a-8333-aac523d1297a"), new Guid("cdf7870a-7d49-4180-ae2c-e5df90c9b062"), "Comics for reading", "Comics", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"genre\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"characters\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("aa663b93-712f-4021-b38b-804c85455ec7"), new Guid("cdf7870a-7d49-4180-ae2c-e5df90c9b062"), "Novels for reading", "Novels", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"genre\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"themes\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("b66d646c-b79e-476b-91a3-a0e813c2baee"), new Guid("a206db4f-2fdd-40b4-88ef-2c14f85c97be"), "Bikes for driving", "Bikes", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"brand\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"handles\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("c1e011fc-3d3c-4264-a0a1-ea9aea2d727f"), new Guid("d3910333-fe03-42d7-8e3d-ac8f2d09df25"), "Pants for wearing", "Pants", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"material\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"shades\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AddressId", "CreatedAt", "Email", "Name", "Password", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("11273c30-ff1f-4b50-9663-8a57eed70c9f"), new Guid("93d982fb-1ae1-4d40-aef4-39e42baec339"), new DateTime(2023, 4, 24, 5, 0, 8, 714, DateTimeKind.Utc).AddTicks(2885), "DebyDebyDoo@gmail.com", "DebyDoo", "debugger", new DateTime(2023, 4, 24, 5, 0, 8, 714, DateTimeKind.Utc).AddTicks(2885) },
                    { new Guid("42b2a4d1-f4db-4460-a5f0-3a7e781fc94b"), new Guid("eaa0f6db-db14-4c14-8260-5ceb6774629d"), new DateTime(2023, 4, 24, 5, 0, 8, 714, DateTimeKind.Utc).AddTicks(2877), "admin2@gmail.com", "Admin2", "123456", new DateTime(2023, 4, 24, 5, 0, 8, 714, DateTimeKind.Utc).AddTicks(2877) },
                    { new Guid("4b31f369-2831-4395-8a82-da860c087cbe"), new Guid("89ce41d1-aff7-4585-800c-3e838e8ec568"), new DateTime(2023, 4, 24, 5, 0, 8, 714, DateTimeKind.Utc).AddTicks(2881), "admin3@gmail.com", "Admin3", "123sdda456", new DateTime(2023, 4, 24, 5, 0, 8, 714, DateTimeKind.Utc).AddTicks(2882) },
                    { new Guid("5365b64f-f746-4da3-989f-16b2ba071976"), new Guid("d885770e-f4cd-449a-bd8b-05872ffba755"), new DateTime(2023, 4, 24, 5, 0, 8, 714, DateTimeKind.Utc).AddTicks(2890), "duje@gmail.com", "duje", "1111", new DateTime(2023, 4, 24, 5, 0, 8, 714, DateTimeKind.Utc).AddTicks(2890) },
                    { new Guid("56cf1149-4439-4d8e-8fe3-915b0cc92c9c"), new Guid("aeab178a-eecd-4f2d-908c-44cb0a58801c"), new DateTime(2023, 4, 24, 5, 0, 8, 714, DateTimeKind.Utc).AddTicks(2863), "John@gmail.com", "John", "123456", new DateTime(2023, 4, 24, 5, 0, 8, 714, DateTimeKind.Utc).AddTicks(2867) },
                    { new Guid("e2763412-0851-4187-a9ad-fe9b89689f96"), new Guid("223ef92a-5335-4937-ae06-79cb496751be"), new DateTime(2023, 4, 24, 5, 0, 8, 714, DateTimeKind.Utc).AddTicks(2874), "admin@gmail.com", "Admin", "123456", new DateTime(2023, 4, 24, 5, 0, 8, 714, DateTimeKind.Utc).AddTicks(2875) },
                    { new Guid("eed6b2dd-2cb4-4837-8577-76afef6d4d84"), new Guid("34c69446-cc0a-425c-8fb7-ef6c78a478f8"), new DateTime(2023, 4, 24, 5, 0, 8, 714, DateTimeKind.Utc).AddTicks(2872), "Jane@gmail.com", "Jane", "123456", new DateTime(2023, 4, 24, 5, 0, 8, 714, DateTimeKind.Utc).AddTicks(2872) },
                    { new Guid("fe7cc45d-4b3c-4b58-a7e8-2b5b83a2ee61"), new Guid("570afee0-edd2-46d9-8367-1d8f2fbd4170"), new DateTime(2023, 4, 24, 5, 0, 8, 714, DateTimeKind.Utc).AddTicks(2887), "none@gmail.com", "nonexistant", "123456", new DateTime(2023, 4, 24, 5, 0, 8, 714, DateTimeKind.Utc).AddTicks(2887) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Created", "Description", "ExtraProperties", "Images", "LocationId", "Name", "Price", "Quantity", "SellerId", "SubCategoryId", "SubProperties" },
                values: new object[,]
                {
                    { new Guid("025c3c8b-7ca8-40b6-8ba4-d4f4164e49fa"), new Guid("8a02beb2-8b06-49db-9ba1-f27e82661e76"), new DateTime(2023, 4, 24, 5, 0, 8, 714, DateTimeKind.Utc).AddTicks(3459), "Laptop for working", "{\r\n  \"name\": \"asus\",\r\n  \"voltage\": [\r\n    \"250V\",\r\n    \"100V\"\r\n  ]\r\n}", new List<string> { "https://i.imgur.com/1Q1Z1Zm.jpg" }, new Guid("34c69446-cc0a-425c-8fb7-ef6c78a478f8"), "Asus Laptop", 1000m, 5, new Guid("eed6b2dd-2cb4-4837-8577-76afef6d4d84"), new Guid("8289ce7e-053a-448d-b95e-e6c2e03334b9"), "{\r\n  \"brand\": \"asus\",\r\n  \"screensizes\": [\r\n    \"10300p\",\r\n    \"4100p\"\r\n  ]\r\n}" },
                    { new Guid("10a71ac3-9e3c-42af-a1c5-ee05aff80dc4"), new Guid("8a02beb2-8b06-49db-9ba1-f27e82661e76"), new DateTime(2023, 4, 24, 5, 0, 8, 714, DateTimeKind.Utc).AddTicks(3679), "Iphone 11 for working", "{\r\n  \"name\": \"iphone\",\r\n  \"voltage\": [\r\n    \"150V\",\r\n    \"100V\"\r\n  ]\r\n}", new List<string> { "https://i.imgur.com/1Q1Z1Zm.jpg" }, new Guid("34c69446-cc0a-425c-8fb7-ef6c78a478f8"), "Iphone 11", 1000m, 5, new Guid("eed6b2dd-2cb4-4837-8577-76afef6d4d84"), new Guid("8a54d209-31a2-4c4f-8ae9-e2e7658b1ebd"), "{\r\n  \"brand\": \"apple\",\r\n  \"colors\": [\r\n    \"red\",\r\n    \"blue\"\r\n  ]\r\n}" },
                    { new Guid("3de2e2bb-d0fb-46b2-8ce2-5a324f18e41e"), new Guid("d3910333-fe03-42d7-8e3d-ac8f2d09df25"), new DateTime(2023, 4, 24, 5, 0, 8, 714, DateTimeKind.Utc).AddTicks(2905), "T-Shirt for wearing", "{\r\n  \"name\": \"cotton\",\r\n  \"size\": [\r\n    \"red\",\r\n    \"blue\"\r\n  ]\r\n}", new List<string> { "https://i.imgur.com/1Q1Z1Zm.jpg" }, new Guid("aeab178a-eecd-4f2d-908c-44cb0a58801c"), "T-Shirt", 10m, 10, new Guid("56cf1149-4439-4d8e-8fe3-915b0cc92c9c"), new Guid("633efeda-466b-4302-aa7a-9c192f4a3c9a"), "{\r\n  \"material\": \"cotton\",\r\n  \"colors\": [\r\n    \"red\",\r\n    \"blue\"\r\n  ]\r\n}" },
                    { new Guid("505d8e4b-f37d-431c-a5a5-450cff959a1a"), new Guid("d3910333-fe03-42d7-8e3d-ac8f2d09df25"), new DateTime(2023, 4, 24, 5, 0, 8, 714, DateTimeKind.Utc).AddTicks(3091), "Jeans for wearing", "{\r\n  \"name\": \"cotton\",\r\n  \"size\": [\r\n    \"red\",\r\n    \"blue\"\r\n  ]\r\n}", new List<string> { "https://i.imgur.com/1Q1Z1Zm.jpg" }, new Guid("aeab178a-eecd-4f2d-908c-44cb0a58801c"), "Jeans", 20m, 20, new Guid("56cf1149-4439-4d8e-8fe3-915b0cc92c9c"), new Guid("c1e011fc-3d3c-4264-a0a1-ea9aea2d727f"), "{\r\n  \"material\": \"cotton\",\r\n  \"shades\": [\r\n    \"red\",\r\n    \"blue\"\r\n  ]\r\n}" },
                    { new Guid("a67b958d-0d2d-4886-abf4-48ef535f37ad"), new Guid("8a02beb2-8b06-49db-9ba1-f27e82661e76"), new DateTime(2023, 4, 24, 5, 0, 8, 714, DateTimeKind.Utc).AddTicks(3272), "Laptop for working", "{\r\n  \"name\": \"cotton\",\r\n  \"voltage\": [\r\n    \"250V\",\r\n    \"100V\"\r\n  ]\r\n}", new List<string> { "https://i.imgur.com/1Q1Z1Zm.jpg" }, new Guid("aeab178a-eecd-4f2d-908c-44cb0a58801c"), "Windows Laptop", 500m, 5, new Guid("4b31f369-2831-4395-8a82-da860c087cbe"), new Guid("8289ce7e-053a-448d-b95e-e6c2e03334b9"), "{\r\n  \"brand\": \"cotton\",\r\n  \"screensizes\": [\r\n    \"1000p\",\r\n    \"400p\"\r\n  ]\r\n}" },
                    { new Guid("ba4e4226-7788-470a-9af4-07adacffaaf3"), new Guid("8a02beb2-8b06-49db-9ba1-f27e82661e76"), new DateTime(2023, 4, 24, 5, 0, 8, 714, DateTimeKind.Utc).AddTicks(3598), "Iphone 12 for working", "{\r\n  \"name\": \"iphone\",\r\n  \"voltage\": [\r\n    \"250V\",\r\n    \"100V\"\r\n  ]\r\n}", new List<string> { "https://i.imgur.com/1Q1Z1Zm.jpg" }, new Guid("34c69446-cc0a-425c-8fb7-ef6c78a478f8"), "Iphone 12", 1000m, 5, new Guid("eed6b2dd-2cb4-4837-8577-76afef6d4d84"), new Guid("8a54d209-31a2-4c4f-8ae9-e2e7658b1ebd"), "{\r\n  \"brand\": \"apple\",\r\n  \"colors\": [\r\n    \"red\",\r\n    \"blue\"\r\n  ]\r\n}" },
                    { new Guid("bce20b2e-8f3a-4aae-81e7-85967c9ef9fc"), new Guid("8a02beb2-8b06-49db-9ba1-f27e82661e76"), new DateTime(2023, 4, 24, 5, 0, 8, 714, DateTimeKind.Utc).AddTicks(3353), "Laptop for working", "{\r\n  \"name\": \"macbook\",\r\n  \"voltage\": [\r\n    \"250V\",\r\n    \"100V\"\r\n  ]\r\n}", new List<string> { "https://i.imgur.com/1Q1Z1Zm.jpg" }, new Guid("89ce41d1-aff7-4585-800c-3e838e8ec568"), "MacBook", 1000m, 5, new Guid("42b2a4d1-f4db-4460-a5f0-3a7e781fc94b"), new Guid("8289ce7e-053a-448d-b95e-e6c2e03334b9"), "{\r\n  \"brand\": \"apple\",\r\n  \"screensizes\": [\r\n    \"1000p\",\r\n    \"400p\"\r\n  ]\r\n}" },
                    { new Guid("d02f6a5c-c0d4-4868-9bb1-3bde112f6fca"), new Guid("d3910333-fe03-42d7-8e3d-ac8f2d09df25"), new DateTime(2023, 4, 24, 5, 0, 8, 714, DateTimeKind.Utc).AddTicks(3193), "Shoes for wearing", "{\r\n  \"material\": \"cotton\",\r\n  \"voltage\": [\r\n    \"250V\",\r\n    \"100V\"\r\n  ]\r\n}", new List<string> { "https://i.imgur.com/1Q1Z1Zm.jpg" }, new Guid("aeab178a-eecd-4f2d-908c-44cb0a58801c"), "Shoes", 30m, 30, new Guid("42b2a4d1-f4db-4460-a5f0-3a7e781fc94b"), new Guid("c1e011fc-3d3c-4264-a0a1-ea9aea2d727f"), "{\r\n  \"name\": \"cotton\",\r\n  \"size\": [\r\n    \"red\",\r\n    \"blue\"\r\n  ]\r\n}" }
                });
        }
    }
}
