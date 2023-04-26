using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class seed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2a081aa1-504d-4913-96d8-595e9faaffa9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c02c44ef-6254-419a-9918-d565c30d27f5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f4146393-ef7a-47f0-a2c8-b1c370bdce0d"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("e2c43b31-ce75-47cc-b688-cc8c87d778da"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("115cc146-04bc-4f7b-aa8f-a91940282555"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("336806b3-aa7b-4696-befe-ff0a19285ae8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3fe4fa92-fcba-42d5-81c0-983c5c892173"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c8f91d6-2d2d-4f6b-9b30-23716c24cdc0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("989ee745-9a87-4ee9-bdaa-4fad4def6044"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9f1ba821-f7a8-4ea1-a4a3-01bdcc9f29c6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c3a456af-e12a-4c5b-9e77-cf239d401b96"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e802c6ac-b346-4450-84e1-4857f51062ee"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("078f7d52-c17d-413d-85d0-43d377231ccb"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("20c536da-0c49-4747-b276-b5f57fc11a31"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("2847a4a1-f57a-4508-a728-50b597890ade"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("72fa7799-a0ed-4b72-ab29-cd7facda88f1"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("79334430-93da-477f-a52b-336a808ef9aa"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("88363248-a399-430d-86db-14ad03dae8f1"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("bda15054-c81f-4df0-90f7-1e601c65d988"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("130eeb6d-69b9-46d2-97ef-064579a25f95"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("24a0628b-bad2-496e-8be2-59006b97e440"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3dc8d114-5a76-420a-9ae4-6e3564cbc395"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55695980-cfb1-474c-b520-81dc0d7660b0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("338b6dff-1620-4c4e-ab24-56b253d1b327"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("946036da-d5de-4eef-8912-5762d0f2805d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("db4b4fc1-f050-4075-83a0-95c2f3497267"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("0bd9403b-c155-4132-9251-9dff67dc0830"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("35b97e91-b15e-4edf-933b-a81cea3cf22d"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("3d77cc3d-af6b-4b2e-9d03-802ea7c9bc67"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("523bc55d-a297-4798-8599-1a834cd538dc"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("1d355207-c3dd-452c-95df-b23a1fc83abc"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("7c9fb98f-f4b9-41c8-b76d-08a51fcb704b"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("9fb48dd6-cfb2-4140-9716-d91f0cb3b601"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("b09e61d9-69ae-4ac3-91cc-d480695a40c6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("06e11082-0fae-4c1b-84b3-c83a421a6001"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2232fa4b-74ad-4925-a957-9aef9280d2d3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3d2ed5f6-3e8d-4a65-b8d0-b45a262fdb05"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6e8cad0-ad7a-48a3-87e5-a6189f9a4e3c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1df1d8e6-f2e5-4d33-8c9c-90b256605e0e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e11b4eb2-6895-4588-9d70-1cf103ce1279"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("12cdf073-8d73-4830-a812-71932c6c9c76"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("71d315e9-e5c0-4aa4-ba9f-fe9f4d473817"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f45a21a4-7ca5-4f4f-a205-cb69a97b8c89"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("43c371e8-348a-482e-8051-f024678702f4"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("65a6a13d-611d-49c5-b548-8a8a4e84ab6d"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("8257ea0f-708f-42ad-bf21-644d92b8b7d0"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("fa62203c-06ff-43d4-b733-5efeaf52a70a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3b040119-c518-4f8f-a37c-8e1df235b4e9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("626e3b81-55e5-4907-a17b-a5c2b7180e20"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f5172903-b584-46fe-a98c-a2a634916360"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("1df1d8e6-f2e5-4d33-8c9c-90b256605e0e"), "Electronics for using", "Electronics", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"name\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"voltage\": {\r\n      \"type\": \"string\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("2a081aa1-504d-4913-96d8-595e9faaffa9"), "Toys for playing", "Toys", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"name\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"aimedFor\": {\r\n      \"type\": \"string\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("338b6dff-1620-4c4e-ab24-56b253d1b327"), "Food for eating", "Food", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"name\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"ingredients\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("946036da-d5de-4eef-8912-5762d0f2805d"), "Vehicles for driving", "Vehicles", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"name\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"color\": {\r\n      \"type\": \"string\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("c02c44ef-6254-419a-9918-d565c30d27f5"), "Furniture for sitting", "Furniture", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"name\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"color\": {\r\n      \"type\": \"string\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("db4b4fc1-f050-4075-83a0-95c2f3497267"), "Books for reading", "Books", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"name\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"author\": {\r\n      \"type\": \"string\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("e11b4eb2-6895-4588-9d70-1cf103ce1279"), "Clothes for wearing", "Clothes", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"name\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"size\": {\r\n      \"type\": \"string\"\r\n    }\r\n  }\r\n}" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { new Guid("12cdf073-8d73-4830-a812-71932c6c9c76"), "https://www.countryflags.io/me/flat/64.png", "Montenegro" },
                    { new Guid("3b040119-c518-4f8f-a37c-8e1df235b4e9"), "https://www.countryflags.io/hr/flat/64.png", "Croatia" },
                    { new Guid("626e3b81-55e5-4907-a17b-a5c2b7180e20"), "https://www.countryflags.io/ba/flat/64.png", "Bosnia and Herzegovina" },
                    { new Guid("71d315e9-e5c0-4aa4-ba9f-fe9f4d473817"), "https://www.countryflags.io/si/flat/64.png", "Slovenia" },
                    { new Guid("f4146393-ef7a-47f0-a2c8-b1c370bdce0d"), "https://www.countryflags.io/al/flat/64.png", "Albania" },
                    { new Guid("f45a21a4-7ca5-4f4f-a205-cb69a97b8c89"), "https://www.countryflags.io/mk/flat/64.png", "Macedonia" },
                    { new Guid("f5172903-b584-46fe-a98c-a2a634916360"), "https://www.countryflags.io/rs/flat/64.png", "Serbia" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "CountryId", "Latitude", "Longitude", "Name" },
                values: new object[,]
                {
                    { new Guid("0bd9403b-c155-4132-9251-9dff67dc0830"), new Guid("12cdf073-8d73-4830-a812-71932c6c9c76"), 46.056946m, 14.505751m, "Ljubljana" },
                    { new Guid("35b97e91-b15e-4edf-933b-a81cea3cf22d"), new Guid("f5172903-b584-46fe-a98c-a2a634916360"), 43.856258m, 18.413076m, "Sarajevo" },
                    { new Guid("3d77cc3d-af6b-4b2e-9d03-802ea7c9bc67"), new Guid("71d315e9-e5c0-4aa4-ba9f-fe9f4d473817"), 20.056946m, 4.505751m, "othertown" },
                    { new Guid("43c371e8-348a-482e-8051-f024678702f4"), new Guid("f5172903-b584-46fe-a98c-a2a634916360"), 45.251667m, 19.836944m, "Novi Sad" },
                    { new Guid("523bc55d-a297-4798-8599-1a834cd538dc"), new Guid("f45a21a4-7ca5-4f4f-a205-cb69a97b8c89"), 40.056946m, 10.505751m, "Town" },
                    { new Guid("65a6a13d-611d-49c5-b548-8a8a4e84ab6d"), new Guid("3b040119-c518-4f8f-a37c-8e1df235b4e9"), 42.460201m, 19.259995m, "Podgorica" },
                    { new Guid("8257ea0f-708f-42ad-bf21-644d92b8b7d0"), new Guid("626e3b81-55e5-4907-a17b-a5c2b7180e20"), 42.002876m, 21.436935m, "Skopje" },
                    { new Guid("e2c43b31-ce75-47cc-b688-cc8c87d778da"), new Guid("3b040119-c518-4f8f-a37c-8e1df235b4e9"), 45.815010m, 15.981919m, "Zagreb" },
                    { new Guid("fa62203c-06ff-43d4-b733-5efeaf52a70a"), new Guid("f5172903-b584-46fe-a98c-a2a634916360"), 44.786568m, 20.448921m, "Belgrade" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Schema" },
                values: new object[,]
                {
                    { new Guid("078f7d52-c17d-413d-85d0-43d377231ccb"), new Guid("338b6dff-1620-4c4e-ab24-56b253d1b327"), "Meat for eating", "Meat", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"taste\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"colors\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("1d355207-c3dd-452c-95df-b23a1fc83abc"), new Guid("e11b4eb2-6895-4588-9d70-1cf103ce1279"), "Pants for wearing", "Pants", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"material\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"shades\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("20c536da-0c49-4747-b276-b5f57fc11a31"), new Guid("946036da-d5de-4eef-8912-5762d0f2805d"), "Bikes for driving", "Bikes", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"brand\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"handles\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("2847a4a1-f57a-4508-a728-50b597890ade"), new Guid("db4b4fc1-f050-4075-83a0-95c2f3497267"), "Comics for reading", "Comics", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"genre\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"characters\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("72fa7799-a0ed-4b72-ab29-cd7facda88f1"), new Guid("946036da-d5de-4eef-8912-5762d0f2805d"), "Cars for driving", "Cars", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"brand\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"motors\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("79334430-93da-477f-a52b-336a808ef9aa"), new Guid("338b6dff-1620-4c4e-ab24-56b253d1b327"), "Fruits for eating", "Fruits", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"sweetLevel\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"colors\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("7c9fb98f-f4b9-41c8-b76d-08a51fcb704b"), new Guid("1df1d8e6-f2e5-4d33-8c9c-90b256605e0e"), "Phones for using", "Phones", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"brand\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"colors\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("88363248-a399-430d-86db-14ad03dae8f1"), new Guid("db4b4fc1-f050-4075-83a0-95c2f3497267"), "Novels for reading", "Novels", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"genre\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"themes\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("9fb48dd6-cfb2-4140-9716-d91f0cb3b601"), new Guid("e11b4eb2-6895-4588-9d70-1cf103ce1279"), "Shirts for wearing", "Shirts", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"material\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"colors\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("b09e61d9-69ae-4ac3-91cc-d480695a40c6"), new Guid("1df1d8e6-f2e5-4d33-8c9c-90b256605e0e"), "Laptops for using", "Laptops", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"brand\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"screensizes\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" },
                    { new Guid("bda15054-c81f-4df0-90f7-1e601c65d988"), new Guid("338b6dff-1620-4c4e-ab24-56b253d1b327"), "Vegetables for eating", "Vegetables", "{\r\n  \"type\": \"object\",\r\n  \"properties\": {\r\n    \"sourLevel\": {\r\n      \"type\": \"string\"\r\n    },\r\n    \"colors\": {\r\n      \"type\": \"array\"\r\n    }\r\n  }\r\n}" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AddressId", "CreatedAt", "Email", "Name", "Password", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("06e11082-0fae-4c1b-84b3-c83a421a6001"), new Guid("fa62203c-06ff-43d4-b733-5efeaf52a70a"), new DateTime(2023, 4, 24, 0, 35, 14, 200, DateTimeKind.Utc).AddTicks(3337), "John@gmail.com", "John", "123456", new DateTime(2023, 4, 24, 0, 35, 14, 200, DateTimeKind.Utc).AddTicks(3341) },
                    { new Guid("130eeb6d-69b9-46d2-97ef-064579a25f95"), new Guid("0bd9403b-c155-4132-9251-9dff67dc0830"), new DateTime(2023, 4, 24, 0, 35, 14, 200, DateTimeKind.Utc).AddTicks(3405), "none@gmail.com", "nonexistant", "123456", new DateTime(2023, 4, 24, 0, 35, 14, 200, DateTimeKind.Utc).AddTicks(3405) },
                    { new Guid("2232fa4b-74ad-4925-a957-9aef9280d2d3"), new Guid("8257ea0f-708f-42ad-bf21-644d92b8b7d0"), new DateTime(2023, 4, 24, 0, 35, 14, 200, DateTimeKind.Utc).AddTicks(3391), "admin2@gmail.com", "Admin2", "123456", new DateTime(2023, 4, 24, 0, 35, 14, 200, DateTimeKind.Utc).AddTicks(3391) },
                    { new Guid("24a0628b-bad2-496e-8be2-59006b97e440"), new Guid("35b97e91-b15e-4edf-933b-a81cea3cf22d"), new DateTime(2023, 4, 24, 0, 35, 14, 200, DateTimeKind.Utc).AddTicks(3387), "admin@gmail.com", "Admin", "123456", new DateTime(2023, 4, 24, 0, 35, 14, 200, DateTimeKind.Utc).AddTicks(3388) },
                    { new Guid("3d2ed5f6-3e8d-4a65-b8d0-b45a262fdb05"), new Guid("43c371e8-348a-482e-8051-f024678702f4"), new DateTime(2023, 4, 24, 0, 35, 14, 200, DateTimeKind.Utc).AddTicks(3384), "Jane@gmail.com", "Jane", "123456", new DateTime(2023, 4, 24, 0, 35, 14, 200, DateTimeKind.Utc).AddTicks(3384) },
                    { new Guid("3dc8d114-5a76-420a-9ae4-6e3564cbc395"), new Guid("3d77cc3d-af6b-4b2e-9d03-802ea7c9bc67"), new DateTime(2023, 4, 24, 0, 35, 14, 200, DateTimeKind.Utc).AddTicks(3408), "duje@gmail.com", "duje", "1111", new DateTime(2023, 4, 24, 0, 35, 14, 200, DateTimeKind.Utc).AddTicks(3409) },
                    { new Guid("55695980-cfb1-474c-b520-81dc0d7660b0"), new Guid("523bc55d-a297-4798-8599-1a834cd538dc"), new DateTime(2023, 4, 24, 0, 35, 14, 200, DateTimeKind.Utc).AddTicks(3399), "DebyDebyDoo@gmail.com", "DebyDoo", "debugger", new DateTime(2023, 4, 24, 0, 35, 14, 200, DateTimeKind.Utc).AddTicks(3399) },
                    { new Guid("a6e8cad0-ad7a-48a3-87e5-a6189f9a4e3c"), new Guid("65a6a13d-611d-49c5-b548-8a8a4e84ab6d"), new DateTime(2023, 4, 24, 0, 35, 14, 200, DateTimeKind.Utc).AddTicks(3394), "admin3@gmail.com", "Admin3", "123sdda456", new DateTime(2023, 4, 24, 0, 35, 14, 200, DateTimeKind.Utc).AddTicks(3395) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Created", "Description", "ExtraProperties", "Images", "LocationId", "Name", "Price", "Quantity", "SellerId", "SubCategoryId", "SubProperties" },
                values: new object[,]
                {
                    { new Guid("115cc146-04bc-4f7b-aa8f-a91940282555"), new Guid("1df1d8e6-f2e5-4d33-8c9c-90b256605e0e"), new DateTime(2023, 4, 24, 0, 35, 14, 200, DateTimeKind.Utc).AddTicks(4004), "Laptop for working", "{\r\n  \"name\": \"macbook\",\r\n  \"voltage\": [\r\n    \"250V\",\r\n    \"100V\"\r\n  ]\r\n}", new List<string> { "https://i.imgur.com/1Q1Z1Zm.jpg" }, new Guid("65a6a13d-611d-49c5-b548-8a8a4e84ab6d"), "MacBook", 1000m, 5, new Guid("2232fa4b-74ad-4925-a957-9aef9280d2d3"), new Guid("b09e61d9-69ae-4ac3-91cc-d480695a40c6"), "{\r\n  \"brand\": \"apple\",\r\n  \"screensizes\": [\r\n    \"1000p\",\r\n    \"400p\"\r\n  ]\r\n}" },
                    { new Guid("336806b3-aa7b-4696-befe-ff0a19285ae8"), new Guid("1df1d8e6-f2e5-4d33-8c9c-90b256605e0e"), new DateTime(2023, 4, 24, 0, 35, 14, 200, DateTimeKind.Utc).AddTicks(3893), "Laptop for working", "{\r\n  \"name\": \"cotton\",\r\n  \"voltage\": [\r\n    \"250V\",\r\n    \"100V\"\r\n  ]\r\n}", new List<string> { "https://i.imgur.com/1Q1Z1Zm.jpg" }, new Guid("fa62203c-06ff-43d4-b733-5efeaf52a70a"), "Windows Laptop", 500m, 5, new Guid("a6e8cad0-ad7a-48a3-87e5-a6189f9a4e3c"), new Guid("b09e61d9-69ae-4ac3-91cc-d480695a40c6"), "{\r\n  \"brand\": \"cotton\",\r\n  \"screensizes\": [\r\n    \"1000p\",\r\n    \"400p\"\r\n  ]\r\n}" },
                    { new Guid("3fe4fa92-fcba-42d5-81c0-983c5c892173"), new Guid("e11b4eb2-6895-4588-9d70-1cf103ce1279"), new DateTime(2023, 4, 24, 0, 35, 14, 200, DateTimeKind.Utc).AddTicks(3425), "T-Shirt for wearing", "{\r\n  \"name\": \"cotton\",\r\n  \"size\": [\r\n    \"red\",\r\n    \"blue\"\r\n  ]\r\n}", new List<string> { "https://i.imgur.com/1Q1Z1Zm.jpg" }, new Guid("fa62203c-06ff-43d4-b733-5efeaf52a70a"), "T-Shirt", 10m, 10, new Guid("06e11082-0fae-4c1b-84b3-c83a421a6001"), new Guid("9fb48dd6-cfb2-4140-9716-d91f0cb3b601"), "{\r\n  \"material\": \"cotton\",\r\n  \"colors\": [\r\n    \"red\",\r\n    \"blue\"\r\n  ]\r\n}" },
                    { new Guid("6c8f91d6-2d2d-4f6b-9b30-23716c24cdc0"), new Guid("1df1d8e6-f2e5-4d33-8c9c-90b256605e0e"), new DateTime(2023, 4, 24, 0, 35, 14, 200, DateTimeKind.Utc).AddTicks(4135), "Laptop for working", "{\r\n  \"name\": \"asus\",\r\n  \"voltage\": [\r\n    \"250V\",\r\n    \"100V\"\r\n  ]\r\n}", new List<string> { "https://i.imgur.com/1Q1Z1Zm.jpg" }, new Guid("43c371e8-348a-482e-8051-f024678702f4"), "Asus Laptop", 1000m, 5, new Guid("3d2ed5f6-3e8d-4a65-b8d0-b45a262fdb05"), new Guid("b09e61d9-69ae-4ac3-91cc-d480695a40c6"), "{\r\n  \"brand\": \"asus\",\r\n  \"screensizes\": [\r\n    \"10300p\",\r\n    \"4100p\"\r\n  ]\r\n}" },
                    { new Guid("989ee745-9a87-4ee9-bdaa-4fad4def6044"), new Guid("1df1d8e6-f2e5-4d33-8c9c-90b256605e0e"), new DateTime(2023, 4, 24, 0, 35, 14, 200, DateTimeKind.Utc).AddTicks(4889), "Iphone 11 for working", "{\r\n  \"name\": \"iphone\",\r\n  \"voltage\": [\r\n    \"150V\",\r\n    \"100V\"\r\n  ]\r\n}", new List<string> { "https://i.imgur.com/1Q1Z1Zm.jpg" }, new Guid("43c371e8-348a-482e-8051-f024678702f4"), "Iphone 11", 1000m, 5, new Guid("3d2ed5f6-3e8d-4a65-b8d0-b45a262fdb05"), new Guid("7c9fb98f-f4b9-41c8-b76d-08a51fcb704b"), "{\r\n  \"brand\": \"apple\",\r\n  \"colors\": [\r\n    \"red\",\r\n    \"blue\"\r\n  ]\r\n}" },
                    { new Guid("9f1ba821-f7a8-4ea1-a4a3-01bdcc9f29c6"), new Guid("e11b4eb2-6895-4588-9d70-1cf103ce1279"), new DateTime(2023, 4, 24, 0, 35, 14, 200, DateTimeKind.Utc).AddTicks(3643), "Jeans for wearing", "{\r\n  \"name\": \"cotton\",\r\n  \"size\": [\r\n    \"red\",\r\n    \"blue\"\r\n  ]\r\n}", new List<string> { "https://i.imgur.com/1Q1Z1Zm.jpg" }, new Guid("fa62203c-06ff-43d4-b733-5efeaf52a70a"), "Jeans", 20m, 20, new Guid("06e11082-0fae-4c1b-84b3-c83a421a6001"), new Guid("1d355207-c3dd-452c-95df-b23a1fc83abc"), "{\r\n  \"material\": \"cotton\",\r\n  \"shades\": [\r\n    \"red\",\r\n    \"blue\"\r\n  ]\r\n}" },
                    { new Guid("c3a456af-e12a-4c5b-9e77-cf239d401b96"), new Guid("1df1d8e6-f2e5-4d33-8c9c-90b256605e0e"), new DateTime(2023, 4, 24, 0, 35, 14, 200, DateTimeKind.Utc).AddTicks(4746), "Iphone 12 for working", "{\r\n  \"name\": \"iphone\",\r\n  \"voltage\": [\r\n    \"250V\",\r\n    \"100V\"\r\n  ]\r\n}", new List<string> { "https://i.imgur.com/1Q1Z1Zm.jpg" }, new Guid("43c371e8-348a-482e-8051-f024678702f4"), "Iphone 12", 1000m, 5, new Guid("3d2ed5f6-3e8d-4a65-b8d0-b45a262fdb05"), new Guid("7c9fb98f-f4b9-41c8-b76d-08a51fcb704b"), "{\r\n  \"brand\": \"apple\",\r\n  \"colors\": [\r\n    \"red\",\r\n    \"blue\"\r\n  ]\r\n}" },
                    { new Guid("e802c6ac-b346-4450-84e1-4857f51062ee"), new Guid("e11b4eb2-6895-4588-9d70-1cf103ce1279"), new DateTime(2023, 4, 24, 0, 35, 14, 200, DateTimeKind.Utc).AddTicks(3793), "Shoes for wearing", "{\r\n  \"material\": \"cotton\",\r\n  \"voltage\": [\r\n    \"250V\",\r\n    \"100V\"\r\n  ]\r\n}", new List<string> { "https://i.imgur.com/1Q1Z1Zm.jpg" }, new Guid("fa62203c-06ff-43d4-b733-5efeaf52a70a"), "Shoes", 30m, 30, new Guid("2232fa4b-74ad-4925-a957-9aef9280d2d3"), new Guid("1d355207-c3dd-452c-95df-b23a1fc83abc"), "{\r\n  \"name\": \"cotton\",\r\n  \"size\": [\r\n    \"red\",\r\n    \"blue\"\r\n  ]\r\n}" }
                });
        }
    }
}
