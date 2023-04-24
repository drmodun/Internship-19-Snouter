using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Users_BuyerId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_BuyerId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "BuyerId",
                table: "Products");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "BuyerId",
                table: "Products",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Products_BuyerId",
                table: "Products",
                column: "BuyerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Users_BuyerId",
                table: "Products",
                column: "BuyerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
