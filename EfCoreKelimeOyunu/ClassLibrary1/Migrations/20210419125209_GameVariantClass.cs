using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity.KelimeOyunu.Migrations
{
    public partial class GameVariantClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GameVariants",
                columns: table => new
                {
                    GameVariantID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameQuestionCount = table.Column<int>(type: "int", nullable: false),
                    GameScoreCount = table.Column<int>(type: "int", nullable: false),
                    GameIsOver = table.Column<bool>(type: "bit", nullable: false),
                    GameIsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    DataGuidID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameVariants", x => x.GameVariantID);
                });

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 1,
                column: "DataGuidID",
                value: new Guid("de9f71ec-d5ea-443a-841d-7eb729550538"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 2,
                column: "DataGuidID",
                value: new Guid("2e719ae7-7dcc-4a99-8290-830c881189f0"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 3,
                column: "DataGuidID",
                value: new Guid("a42e6399-b381-4435-94c7-4b6ece9c13e3"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 4,
                column: "DataGuidID",
                value: new Guid("b0f36e95-1b8b-424f-85a1-38ce22b7c3c7"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 5,
                column: "DataGuidID",
                value: new Guid("0b1bd3bf-ff39-46fd-9604-fb0dc39357d5"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 6,
                column: "DataGuidID",
                value: new Guid("32d140c8-453c-489c-bd40-a4654b3ccc04"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 7,
                column: "DataGuidID",
                value: new Guid("cf248ceb-9774-412d-9701-960aadea93e9"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 8,
                column: "DataGuidID",
                value: new Guid("9cc4717d-7ebc-4d27-b11c-e41bf60ad36b"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 9,
                column: "DataGuidID",
                value: new Guid("f166d10d-6322-4649-baea-a13ded000c9b"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 10,
                column: "DataGuidID",
                value: new Guid("e46b813c-4689-45dd-a3d2-f08f4a530e54"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 11,
                column: "DataGuidID",
                value: new Guid("f434d2b5-8626-4c6b-b35d-10ae11603caf"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 12,
                column: "DataGuidID",
                value: new Guid("f12b4209-b247-45f4-9a84-5da98866fa85"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 13,
                column: "DataGuidID",
                value: new Guid("18da561f-fe4d-41fa-9739-e205edfcb7bf"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 14,
                column: "DataGuidID",
                value: new Guid("ffaf184b-93b8-468c-a070-375646ee2819"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 15,
                column: "DataGuidID",
                value: new Guid("be200b4a-a04a-47f0-9dca-143bacb52636"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 16,
                column: "DataGuidID",
                value: new Guid("53ee939c-f7c9-47cb-8a23-55e5e5e848e9"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 17,
                column: "DataGuidID",
                value: new Guid("1f4559f4-b893-48c8-831c-7bc453144265"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 18,
                column: "DataGuidID",
                value: new Guid("77442b24-95b8-421b-9d7e-15ec4a402142"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 19,
                column: "DataGuidID",
                value: new Guid("5e41dac5-57a9-4204-b999-6121bf3b1a0d"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 20,
                column: "DataGuidID",
                value: new Guid("c22358a6-bdcb-4ace-89cd-41bf75466c41"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 1,
                column: "DataGuidID",
                value: new Guid("241047a6-e29d-4476-9ca3-e3cf4247b1e0"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 2,
                column: "DataGuidID",
                value: new Guid("a545e9ce-7a92-4687-9962-810b035bcedc"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 3,
                column: "DataGuidID",
                value: new Guid("427a6012-b511-4a66-8549-beea13a75595"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 4,
                column: "DataGuidID",
                value: new Guid("573cff4b-1e44-47a3-931d-e028ba723a54"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 5,
                column: "DataGuidID",
                value: new Guid("22cf581d-9608-4148-a246-c728be80d042"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 6,
                column: "DataGuidID",
                value: new Guid("43a59beb-7da5-4e11-8cc3-e867fb35da31"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 7,
                column: "DataGuidID",
                value: new Guid("a9513a09-bf90-4f8b-a9cf-a95c4ba1701e"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 8,
                column: "DataGuidID",
                value: new Guid("758c2b23-1345-4f08-8653-a755738aa423"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 9,
                column: "DataGuidID",
                value: new Guid("81aaddf3-72d7-4ee5-8262-acf9d0e830f2"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 10,
                column: "DataGuidID",
                value: new Guid("28d2efdf-1691-4547-b7d0-bcbe4432f868"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 11,
                column: "DataGuidID",
                value: new Guid("ec4ad1d6-6691-43a9-983f-90c1922208c6"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 12,
                column: "DataGuidID",
                value: new Guid("765431af-5567-4783-b9d0-20533dfe40a4"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 13,
                column: "DataGuidID",
                value: new Guid("4506392d-5a86-460a-b4fe-9fc35602e4d0"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 14,
                column: "DataGuidID",
                value: new Guid("1d599092-6ac6-4795-a86a-fbae2007c5c2"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 15,
                column: "DataGuidID",
                value: new Guid("d79f475f-aead-4580-8482-23fbcbf69143"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 16,
                column: "DataGuidID",
                value: new Guid("51e89d7c-56ba-4e27-9320-c6eeec13c14b"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 17,
                column: "DataGuidID",
                value: new Guid("f99ece96-89f6-4cfd-8ed2-9f8954ec0064"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 18,
                column: "DataGuidID",
                value: new Guid("3a8c97c4-451c-417c-9096-e9c0d79d0d71"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 19,
                column: "DataGuidID",
                value: new Guid("486b4a2c-1b8b-4ba6-b343-1091bd80a196"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 20,
                column: "DataGuidID",
                value: new Guid("ff410bc1-1c1d-4f6c-9cca-b6cb00d6ce8a"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 1,
                column: "DataGuidID",
                value: new Guid("28fbb43c-5299-4e3b-83d2-5785b534ffa5"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 2,
                column: "DataGuidID",
                value: new Guid("69176f74-72c9-4f60-b56d-bfeb89371676"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 3,
                column: "DataGuidID",
                value: new Guid("2be6f082-86a4-4fb0-9bdb-c3905c60cd52"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 4,
                column: "DataGuidID",
                value: new Guid("d9c60f41-e311-4c79-828f-b6c39d3d8f53"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 5,
                column: "DataGuidID",
                value: new Guid("f9285ead-f173-41e4-a380-232851a3fa33"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 6,
                column: "DataGuidID",
                value: new Guid("0cb1de1f-49c4-43d7-a7da-e3429a1d149e"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 7,
                column: "DataGuidID",
                value: new Guid("3f81b6e6-c861-4956-8c84-ed74dfc3f134"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 8,
                column: "DataGuidID",
                value: new Guid("c80efae4-cbd5-4078-9554-3937af76b3b6"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 9,
                column: "DataGuidID",
                value: new Guid("f6e5ff44-0835-44ab-83b4-2e41431b7487"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 10,
                column: "DataGuidID",
                value: new Guid("a39eadfa-2d51-412b-9dca-d90cad34dd12"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 11,
                column: "DataGuidID",
                value: new Guid("420cb90e-7caa-4f70-b8a4-96f2177e8841"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 12,
                column: "DataGuidID",
                value: new Guid("cc86fbfa-e473-4a62-b501-718dc4e6cb21"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 13,
                column: "DataGuidID",
                value: new Guid("f31f2a2c-b1f9-4377-a766-92e3635ca6fd"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 14,
                column: "DataGuidID",
                value: new Guid("d06a66a9-8b82-46d3-9af7-660a0a40a711"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 15,
                column: "DataGuidID",
                value: new Guid("9b0b5856-192d-4585-a118-43b04ea7b591"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 16,
                column: "DataGuidID",
                value: new Guid("f559292f-bb12-46a8-8664-7a45e5550639"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 17,
                column: "DataGuidID",
                value: new Guid("d61fc05b-59b7-45c8-b0c3-48a5f8f452fd"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 18,
                column: "DataGuidID",
                value: new Guid("94d93711-4773-4bea-98c2-1c1215ed2e7d"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 19,
                column: "DataGuidID",
                value: new Guid("3730ef21-78ff-4180-b648-dd6f6cd3742b"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 20,
                column: "DataGuidID",
                value: new Guid("6e83f9e3-be2b-473d-bad1-eb617dc1fded"));

            migrationBuilder.InsertData(
                table: "GameVariants",
                columns: new[] { "GameVariantID", "CreatedDate", "DataGuidID", "GameIsCompleted", "GameIsOver", "GameQuestionCount", "GameScoreCount", "ModifiedDate" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("74eeabff-4a30-4c57-8acc-bd0da841296f"), false, false, 0, 0, null });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 1,
                column: "DataGuidID",
                value: new Guid("d5cffe3f-6f76-43ec-9212-257bc9b7aaa9"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 2,
                column: "DataGuidID",
                value: new Guid("40567c70-1c99-451a-b34f-2693c786236e"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 3,
                column: "DataGuidID",
                value: new Guid("62221308-d3fe-489a-8c6a-05f33e9006ab"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 4,
                column: "DataGuidID",
                value: new Guid("78fbab84-7cc0-4075-9364-be165480ffa9"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 5,
                column: "DataGuidID",
                value: new Guid("ecd3c6d2-4584-4583-b9d2-645aa5d002fd"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 6,
                column: "DataGuidID",
                value: new Guid("df0abf54-2760-4284-b0ed-735c684d334d"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 7,
                column: "DataGuidID",
                value: new Guid("55618d80-5ce3-4eb7-b4e8-b29b3085850d"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 8,
                column: "DataGuidID",
                value: new Guid("601a8315-6cfe-4248-9239-287b10043b20"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 9,
                column: "DataGuidID",
                value: new Guid("6a297e4f-9811-4583-95ce-5b3baedfc7a8"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 10,
                column: "DataGuidID",
                value: new Guid("1cea01d7-a01c-43f9-8e45-778ce8dd327a"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 11,
                column: "DataGuidID",
                value: new Guid("99224d48-9b35-4dc6-bd73-412612212d0d"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 12,
                column: "DataGuidID",
                value: new Guid("2f7cd057-a655-443e-805d-9e7658a1ec7d"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 13,
                column: "DataGuidID",
                value: new Guid("215f3c0b-ddde-4ec8-8fa1-811ec2a9407d"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 14,
                column: "DataGuidID",
                value: new Guid("1da8cbbe-f004-4ce3-a2a9-b9573a74e3dc"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 15,
                column: "DataGuidID",
                value: new Guid("54bff03f-0b4d-47d7-8ee3-c1359a665051"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 16,
                column: "DataGuidID",
                value: new Guid("b52cf34a-f416-44ed-8c47-8b0bca4ad40a"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 17,
                column: "DataGuidID",
                value: new Guid("a22666c5-5e56-4071-8e34-4bb4f6e6bc92"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 18,
                column: "DataGuidID",
                value: new Guid("cda2baeb-3175-4561-9f5f-c4dddd62f4ec"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 19,
                column: "DataGuidID",
                value: new Guid("ff021152-6ce0-4613-9dc1-50a628890e89"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 20,
                column: "DataGuidID",
                value: new Guid("ccbdfdb5-1488-4b94-9fd6-c8970456ddd9"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 1,
                column: "DataGuidID",
                value: new Guid("d5b6e27e-5ae5-4f19-926a-95d2a08ef892"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 2,
                column: "DataGuidID",
                value: new Guid("95d06fee-3242-4821-a3eb-3e572c6c6813"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 3,
                column: "DataGuidID",
                value: new Guid("123d3ca8-b27c-49b2-a844-288de127f00a"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 4,
                column: "DataGuidID",
                value: new Guid("eb43cb50-5e60-4b9f-96c9-91c0009b6401"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 5,
                column: "DataGuidID",
                value: new Guid("0a46e60e-4645-4a13-8f4e-074ba55cccb7"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 6,
                column: "DataGuidID",
                value: new Guid("4bfaed04-b613-4cf6-9462-38c8a39e3fe2"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 7,
                column: "DataGuidID",
                value: new Guid("241e647e-618d-472e-a4c8-f08e54a94479"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 8,
                column: "DataGuidID",
                value: new Guid("628ffeda-b916-4ad2-98e9-a8611541d2c7"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 9,
                column: "DataGuidID",
                value: new Guid("2fa023e2-f552-4ad0-8c6c-03ec572ca44a"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 10,
                column: "DataGuidID",
                value: new Guid("afe0d73b-e019-4a4b-8885-2de26a5ef7a6"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 11,
                column: "DataGuidID",
                value: new Guid("3e04a95b-7829-404b-bcdd-6bb85196a65e"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 12,
                column: "DataGuidID",
                value: new Guid("408c486f-919a-4e00-ae7c-2eae0d90146e"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 13,
                column: "DataGuidID",
                value: new Guid("9b227457-c50d-4377-9e6c-c89b46eee298"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 14,
                column: "DataGuidID",
                value: new Guid("848e25ec-b078-4e9f-8d5d-bcb724b65f38"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 15,
                column: "DataGuidID",
                value: new Guid("87cde2f9-96b7-464c-af4c-ddf129525cc2"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 16,
                column: "DataGuidID",
                value: new Guid("7eeb3bcf-0430-42bd-9a56-86b619609f48"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 17,
                column: "DataGuidID",
                value: new Guid("35ef106e-7dc4-49c1-9b0e-8d0d13e1025a"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 18,
                column: "DataGuidID",
                value: new Guid("e91d8817-b689-4164-a329-6a3d02559be2"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 19,
                column: "DataGuidID",
                value: new Guid("da645a25-0ca8-45a2-aa40-67107ab498b0"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 20,
                column: "DataGuidID",
                value: new Guid("79eca66c-9ea5-4e3f-b185-7226dd43a4fb"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 1,
                column: "DataGuidID",
                value: new Guid("c281a9e9-1631-41df-abf8-49f394392c52"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 2,
                column: "DataGuidID",
                value: new Guid("fbf35d65-6138-4142-bd5b-f7640a9fac4a"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 3,
                column: "DataGuidID",
                value: new Guid("1c8a5f49-9e9b-458f-8a2e-6519002605fc"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 4,
                column: "DataGuidID",
                value: new Guid("dece553d-a107-4824-9afc-ed249c3e3c7b"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 5,
                column: "DataGuidID",
                value: new Guid("a0777245-97e4-4ce6-a454-1194c1481314"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 6,
                column: "DataGuidID",
                value: new Guid("e2c22faa-64da-46fb-8b99-d37de5f3eb97"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 7,
                column: "DataGuidID",
                value: new Guid("fd777e0c-2917-48cd-8fe8-c5275a9edb82"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 8,
                column: "DataGuidID",
                value: new Guid("e2d8037f-bef9-475c-ab05-b7dcd8902d54"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 9,
                column: "DataGuidID",
                value: new Guid("54e3a5af-25f4-4bb4-9687-8bc14e8845f2"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 10,
                column: "DataGuidID",
                value: new Guid("c6eb087e-7813-46bd-b759-eadaeb2c6cf3"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 11,
                column: "DataGuidID",
                value: new Guid("d806ac20-163a-4ac9-8cf3-2eaedcd33c05"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 12,
                column: "DataGuidID",
                value: new Guid("23faebb2-9e4a-4a8f-ab43-bd312e3ac3de"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 13,
                column: "DataGuidID",
                value: new Guid("f5329990-929c-4f79-9bb3-8e3374517273"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 14,
                column: "DataGuidID",
                value: new Guid("eca167c0-7e46-4496-820c-cf43b3cb1d15"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 15,
                column: "DataGuidID",
                value: new Guid("6761cb1f-de91-4754-a09f-b7e393c3b791"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 16,
                column: "DataGuidID",
                value: new Guid("f28d036a-5abe-4999-a63b-e7a8356413a3"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 17,
                column: "DataGuidID",
                value: new Guid("a2d08b56-30dd-4a95-83ae-cb1150ac8a53"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 18,
                column: "DataGuidID",
                value: new Guid("96347c4a-793a-4e54-9546-6a8d7fc5e5ca"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 19,
                column: "DataGuidID",
                value: new Guid("f59b8b59-3b17-4aa8-b028-393293c03d63"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 20,
                column: "DataGuidID",
                value: new Guid("38503799-ff40-4522-a9a9-94ab6bd6e1f2"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 1,
                column: "DataGuidID",
                value: new Guid("5822bbf4-670a-453d-9a3b-3ee1b365e45a"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 2,
                column: "DataGuidID",
                value: new Guid("5268abee-598e-401e-8887-746058168547"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 3,
                column: "DataGuidID",
                value: new Guid("4eee835c-f9f7-4ae7-af6a-b94b7977dbea"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 4,
                column: "DataGuidID",
                value: new Guid("14d252d8-b084-471c-827e-47a5c3a361a0"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 5,
                column: "DataGuidID",
                value: new Guid("76f5ff69-0b7f-4a47-8769-1fa75ccb48c4"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 6,
                column: "DataGuidID",
                value: new Guid("314ec086-09b9-4b98-badb-d5d43efb22c9"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 7,
                column: "DataGuidID",
                value: new Guid("5bbb9e4b-5847-48fc-8fff-05ad37ace75a"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 8,
                column: "DataGuidID",
                value: new Guid("031eaca1-6fca-437f-8ef2-2c335fcb49d3"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 9,
                column: "DataGuidID",
                value: new Guid("8a30c46c-faa6-4e50-97ec-b354e27c201f"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 10,
                column: "DataGuidID",
                value: new Guid("fb1319ef-67d1-4ac6-902c-9895a3a105fa"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 11,
                column: "DataGuidID",
                value: new Guid("d5d42aef-6f5a-4629-a311-9c08bc0a9f91"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 12,
                column: "DataGuidID",
                value: new Guid("bba6fa02-ef45-4a6b-90bd-7a2e68a5dc46"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 13,
                column: "DataGuidID",
                value: new Guid("af17ef73-2926-49fe-ac00-b16aab01e51d"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 14,
                column: "DataGuidID",
                value: new Guid("01981ba9-26d8-49f1-8f12-9a40e3a16341"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 15,
                column: "DataGuidID",
                value: new Guid("ee38d9ae-12c1-41b8-8152-50e6d1ad7367"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 16,
                column: "DataGuidID",
                value: new Guid("0218a1b2-e887-49b3-92ee-50621836f865"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 17,
                column: "DataGuidID",
                value: new Guid("46216f08-e1e7-4558-8b75-abdce28c5a02"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 18,
                column: "DataGuidID",
                value: new Guid("336b996d-8a0e-44a8-928d-82b89b8bdd43"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 19,
                column: "DataGuidID",
                value: new Guid("130cf34e-388d-4f2d-b1e7-4b9b113b26be"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 20,
                column: "DataGuidID",
                value: new Guid("f00d3b6e-58b4-4acc-8aa0-91b317d32f52"));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 1,
                column: "DataGuidID",
                value: new Guid("e688994d-9375-4aa2-8b49-f114dd0ce891"));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 2,
                column: "DataGuidID",
                value: new Guid("ff81862d-0e7f-44dc-aa06-359d9198b90f"));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DataGuidID" },
                values: new object[] { new DateTime(2021, 4, 19, 15, 52, 8, 188, DateTimeKind.Local).AddTicks(3568), new Guid("3e7aca8c-97f5-400d-893f-0515252ab229") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DataGuidID" },
                values: new object[] { new DateTime(2021, 4, 19, 15, 52, 8, 191, DateTimeKind.Local).AddTicks(1961), new Guid("156c975c-978f-4cc7-871d-90c171089659") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameVariants");

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 1,
                column: "DataGuidID",
                value: new Guid("18976aeb-4b51-4f50-8129-846267074c6c"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 2,
                column: "DataGuidID",
                value: new Guid("ffe79174-d63d-476f-b744-cf2299eaa08e"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 3,
                column: "DataGuidID",
                value: new Guid("7153ed0f-01f0-4016-9b3b-f8bd4fd849bd"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 4,
                column: "DataGuidID",
                value: new Guid("fdb08477-19b7-4437-96f0-c14d74b2d9a5"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 5,
                column: "DataGuidID",
                value: new Guid("e7d62f8d-43f9-4892-915a-38e3d2691b4b"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 6,
                column: "DataGuidID",
                value: new Guid("0524dc33-7079-403a-a350-63b1e3adb4ab"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 7,
                column: "DataGuidID",
                value: new Guid("3658de61-5d5e-4214-a9ea-39c58b3e29a8"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 8,
                column: "DataGuidID",
                value: new Guid("01ce129c-caee-411e-8b07-68f71b8743bf"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 9,
                column: "DataGuidID",
                value: new Guid("a845ea5c-53de-4a07-a4a1-e5db82069b3f"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 10,
                column: "DataGuidID",
                value: new Guid("57816825-0089-457a-a709-49c53a73d32b"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 11,
                column: "DataGuidID",
                value: new Guid("f05b579b-dd39-45be-825a-a9d50814d646"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 12,
                column: "DataGuidID",
                value: new Guid("1744e891-6d67-4aac-adc6-3685c4dabceb"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 13,
                column: "DataGuidID",
                value: new Guid("57778169-a213-4784-9a9c-1522206cca3a"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 14,
                column: "DataGuidID",
                value: new Guid("7be3359f-5999-46da-866d-ecd5e1891d34"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 15,
                column: "DataGuidID",
                value: new Guid("43314017-483f-4acd-8ff3-c9b7c44e53b2"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 16,
                column: "DataGuidID",
                value: new Guid("69373a7f-a23c-4d01-97b1-fdfda0d818e2"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 17,
                column: "DataGuidID",
                value: new Guid("66a8c1af-5ce5-4855-bd26-fadb8004dcb3"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 18,
                column: "DataGuidID",
                value: new Guid("8309a96a-3cd2-4a1f-97a5-a98aa0b15137"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 19,
                column: "DataGuidID",
                value: new Guid("d42732c4-0be7-4ccc-a50b-f306539d6405"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 20,
                column: "DataGuidID",
                value: new Guid("e141bec6-d79c-4c1d-a8bb-0f2dfa4928af"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 1,
                column: "DataGuidID",
                value: new Guid("1d4515c3-2f06-43a1-8758-e3a18b64643b"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 2,
                column: "DataGuidID",
                value: new Guid("cfb16485-8b79-4c3f-9e60-be71c85b61bc"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 3,
                column: "DataGuidID",
                value: new Guid("905ae85f-cba6-43a0-9ff4-66978cdff1fa"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 4,
                column: "DataGuidID",
                value: new Guid("fbaf7d69-8c4d-4ad5-9c69-caf1d13396fa"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 5,
                column: "DataGuidID",
                value: new Guid("8164f9d1-df9f-4371-824d-42c7fd2cbfe8"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 6,
                column: "DataGuidID",
                value: new Guid("0e64706d-39ff-4aeb-83e0-e79509116c5a"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 7,
                column: "DataGuidID",
                value: new Guid("670d2239-8c38-4f48-86ce-a0d0220528fd"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 8,
                column: "DataGuidID",
                value: new Guid("e78d8383-e0d6-4b96-93ca-38d405fdb72d"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 9,
                column: "DataGuidID",
                value: new Guid("4fbd1a75-9ad1-4ffe-827a-213eed955687"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 10,
                column: "DataGuidID",
                value: new Guid("22c147e2-edbd-4f90-b201-510f375d2ec7"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 11,
                column: "DataGuidID",
                value: new Guid("a95770b5-653e-42f5-b67c-a5929bd10f15"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 12,
                column: "DataGuidID",
                value: new Guid("f7a83bb8-4c4b-418b-8669-2ef6cc07c06c"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 13,
                column: "DataGuidID",
                value: new Guid("04feee70-35aa-4d35-9d33-eeecbdaee0fd"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 14,
                column: "DataGuidID",
                value: new Guid("7a4e303c-80a9-472d-8566-bbf9b46728bb"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 15,
                column: "DataGuidID",
                value: new Guid("5c047678-767e-4d78-92d2-27998bd79ae3"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 16,
                column: "DataGuidID",
                value: new Guid("acc6d5a6-df0a-44c6-9760-1f58652bc275"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 17,
                column: "DataGuidID",
                value: new Guid("6902f153-1170-4b21-997f-233bb3e937da"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 18,
                column: "DataGuidID",
                value: new Guid("428cd901-1af0-432b-824d-4823487b26ee"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 19,
                column: "DataGuidID",
                value: new Guid("1b0fbf1a-ee00-41e4-aeb3-5be027c11b0f"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 20,
                column: "DataGuidID",
                value: new Guid("cad9b3c9-ea3c-4562-94cf-fa74178fa578"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 1,
                column: "DataGuidID",
                value: new Guid("a881ba16-205f-4d8d-8f2a-68a7583e54ba"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 2,
                column: "DataGuidID",
                value: new Guid("a01e619e-2536-4309-bf5d-61d8ac8207e8"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 3,
                column: "DataGuidID",
                value: new Guid("4469f29f-d122-4187-9198-4a54ade49030"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 4,
                column: "DataGuidID",
                value: new Guid("a1785752-27aa-4dba-8460-7914a9533b2f"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 5,
                column: "DataGuidID",
                value: new Guid("71846337-0e3c-4ee9-b559-a0a7d0228472"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 6,
                column: "DataGuidID",
                value: new Guid("d9301608-0d4c-466a-80d9-99fe679b6e00"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 7,
                column: "DataGuidID",
                value: new Guid("f9b15b5a-fc1a-4ce8-9ceb-672b268f1d15"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 8,
                column: "DataGuidID",
                value: new Guid("9c5dea5b-c311-454d-8eb6-9852bea67b8f"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 9,
                column: "DataGuidID",
                value: new Guid("cfb64591-f798-4648-8d32-75ece6028f7a"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 10,
                column: "DataGuidID",
                value: new Guid("9d61f33b-a592-40e3-a2e5-a9a8c2af6935"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 11,
                column: "DataGuidID",
                value: new Guid("96b3cca7-cb9a-4991-9a3e-9df5665227b3"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 12,
                column: "DataGuidID",
                value: new Guid("cf1f8fd5-eb26-43cc-903d-16104a860533"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 13,
                column: "DataGuidID",
                value: new Guid("a1f3de0f-d2ea-4fd9-bc1d-ebf6e1ba7679"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 14,
                column: "DataGuidID",
                value: new Guid("3be957fd-3720-4c24-8abc-b5c41ca049de"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 15,
                column: "DataGuidID",
                value: new Guid("b1d423ab-5280-4703-88b6-3a235c2b5115"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 16,
                column: "DataGuidID",
                value: new Guid("a5d8edfe-60a6-4b99-8bb4-8225ed28c413"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 17,
                column: "DataGuidID",
                value: new Guid("2c5f6562-625c-48fa-8d0a-3c9f5c14135f"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 18,
                column: "DataGuidID",
                value: new Guid("70dd185d-cf55-47bd-ab22-6d43cf9315bc"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 19,
                column: "DataGuidID",
                value: new Guid("d4b51dd5-a417-4e5f-b416-36af34c1f8a6"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 20,
                column: "DataGuidID",
                value: new Guid("961b6d2e-94cc-4d5e-963d-f011ff4b4c3b"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 1,
                column: "DataGuidID",
                value: new Guid("e6cb3ff2-67d2-415a-9da8-1b66fb461cb1"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 2,
                column: "DataGuidID",
                value: new Guid("3d1c900c-a593-40f6-88b2-0f34d2519b0d"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 3,
                column: "DataGuidID",
                value: new Guid("23220a5d-d80f-4156-ae4d-cfe57352c409"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 4,
                column: "DataGuidID",
                value: new Guid("e2724891-7046-46c6-9008-77cea8433661"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 5,
                column: "DataGuidID",
                value: new Guid("35862718-9bf7-47fe-b148-bdf344c38df4"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 6,
                column: "DataGuidID",
                value: new Guid("0bea8e21-d2e2-4e23-8d94-faf2de6bee16"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 7,
                column: "DataGuidID",
                value: new Guid("8dc5f1fd-68fd-438d-9e49-ec65cd6ac81a"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 8,
                column: "DataGuidID",
                value: new Guid("21e39332-12db-47f8-a869-12da97360903"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 9,
                column: "DataGuidID",
                value: new Guid("2e6ababd-410e-4a00-865e-a9c17fdf8778"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 10,
                column: "DataGuidID",
                value: new Guid("cfcc5998-602c-4b2e-9a04-cea062ffbd2b"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 11,
                column: "DataGuidID",
                value: new Guid("7ae61c7e-d631-4071-8eae-efc636bf37ca"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 12,
                column: "DataGuidID",
                value: new Guid("d568b110-36f3-4afd-b283-2446c3d70796"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 13,
                column: "DataGuidID",
                value: new Guid("3e4c777d-6fec-4de7-955a-7720cd502c56"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 14,
                column: "DataGuidID",
                value: new Guid("d13e541c-d09c-4667-bb83-05f499f148d7"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 15,
                column: "DataGuidID",
                value: new Guid("7a05f420-9b47-4410-a2ce-64010d0d7ed6"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 16,
                column: "DataGuidID",
                value: new Guid("8a4b08b0-8b8f-4f28-b9f9-01b2b73c0dc6"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 17,
                column: "DataGuidID",
                value: new Guid("ee1f73bd-e544-4fcd-9acc-17f5b22e8d5b"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 18,
                column: "DataGuidID",
                value: new Guid("b663176b-2a82-4333-a4ea-ed620ed9422b"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 19,
                column: "DataGuidID",
                value: new Guid("25ecb5f4-9346-4c84-af1e-514e0d755473"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 20,
                column: "DataGuidID",
                value: new Guid("53e41b41-a2ad-4f18-98b3-d92432af3ac0"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 1,
                column: "DataGuidID",
                value: new Guid("c3c7851c-10df-4c3a-8842-936467da7c6a"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 2,
                column: "DataGuidID",
                value: new Guid("9cc209d2-3867-45d0-925f-8c1a5b14b4b9"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 3,
                column: "DataGuidID",
                value: new Guid("95307de3-ac36-419a-a0a5-ba876abfb956"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 4,
                column: "DataGuidID",
                value: new Guid("337d914e-26a0-4d1d-99d0-fe2ffbf40aa2"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 5,
                column: "DataGuidID",
                value: new Guid("8e9d68f6-9e2d-46fb-842c-e723763f3a2e"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 6,
                column: "DataGuidID",
                value: new Guid("871c0946-678c-41ac-aaf4-ad43d0bb63f3"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 7,
                column: "DataGuidID",
                value: new Guid("333ad67f-e8d5-442b-aac8-e2d06ec92232"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 8,
                column: "DataGuidID",
                value: new Guid("94bb7743-4466-4bfa-a13c-8226dd9523a8"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 9,
                column: "DataGuidID",
                value: new Guid("b950e57e-41a6-4e7b-888f-ee6c88b1f013"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 10,
                column: "DataGuidID",
                value: new Guid("6a831d05-0327-4723-b47d-883da3f474fe"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 11,
                column: "DataGuidID",
                value: new Guid("9da895ce-5eb5-4183-b083-83c9494c4510"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 12,
                column: "DataGuidID",
                value: new Guid("6ca7b6c5-3b21-4046-9f2d-0af5fc26a892"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 13,
                column: "DataGuidID",
                value: new Guid("a7b770f1-364e-47c4-971f-a42721f2cddd"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 14,
                column: "DataGuidID",
                value: new Guid("e55b5f4e-f219-4e34-9d48-42d2f6cb8998"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 15,
                column: "DataGuidID",
                value: new Guid("947165e3-b708-42da-850c-0e6c2b326cae"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 16,
                column: "DataGuidID",
                value: new Guid("2132cdc0-cf93-409e-9ece-ffa931c655c5"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 17,
                column: "DataGuidID",
                value: new Guid("618afec0-4bd1-400b-81c4-0f05c902e732"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 18,
                column: "DataGuidID",
                value: new Guid("9d9fd082-2bd8-4df0-8866-a5e1c8597375"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 19,
                column: "DataGuidID",
                value: new Guid("c9adfd1d-d619-4b01-8a4a-5b90f571f813"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 20,
                column: "DataGuidID",
                value: new Guid("8b7dd737-c364-4ffe-84e8-f28664f032fe"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 1,
                column: "DataGuidID",
                value: new Guid("7eb1e618-ec8f-40b4-9bed-abaf838abc15"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 2,
                column: "DataGuidID",
                value: new Guid("6cddc69c-2e05-42dc-bc7c-fab90e0721b3"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 3,
                column: "DataGuidID",
                value: new Guid("73c90716-18b2-41b8-91b5-82363e70743e"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 4,
                column: "DataGuidID",
                value: new Guid("5f653033-7b6c-4ab2-91be-01b3bffa3f61"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 5,
                column: "DataGuidID",
                value: new Guid("2131d574-9789-4848-8616-460e21fe9bb8"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 6,
                column: "DataGuidID",
                value: new Guid("917a081e-9c43-44e4-b279-76972ffdd0dc"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 7,
                column: "DataGuidID",
                value: new Guid("29335a29-acbf-48ed-b9ce-5baa9488cfac"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 8,
                column: "DataGuidID",
                value: new Guid("6de3fedd-c425-47c5-8d6e-70302b0df8f9"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 9,
                column: "DataGuidID",
                value: new Guid("1e901d83-f143-482c-9f97-b7134c1f1a99"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 10,
                column: "DataGuidID",
                value: new Guid("2ff7a680-9fc0-4649-beeb-5662e8b01455"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 11,
                column: "DataGuidID",
                value: new Guid("c86affbe-f3b1-40f1-a115-09616fa1c16f"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 12,
                column: "DataGuidID",
                value: new Guid("7f148dc4-49de-4b82-898b-4c28bbc1242b"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 13,
                column: "DataGuidID",
                value: new Guid("ac536719-cc58-4843-b529-41c8c605d28d"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 14,
                column: "DataGuidID",
                value: new Guid("3d680d0f-1d89-4ebd-b836-3d8a06ff2bbf"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 15,
                column: "DataGuidID",
                value: new Guid("c87a9766-f79d-4128-93ab-22b843b88e53"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 16,
                column: "DataGuidID",
                value: new Guid("f8e0a794-950d-4793-b09f-432cc84e19d4"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 17,
                column: "DataGuidID",
                value: new Guid("3421cf01-51f2-4de7-a0ca-f1cbe5d5eafd"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 18,
                column: "DataGuidID",
                value: new Guid("46be8791-197c-49cc-89b7-52c8b9c35c75"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 19,
                column: "DataGuidID",
                value: new Guid("b00650be-056f-4b72-a712-75ed4dd59b1f"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 20,
                column: "DataGuidID",
                value: new Guid("774e913f-5966-4154-bd20-183d5e0ad29a"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 1,
                column: "DataGuidID",
                value: new Guid("cbcfca8f-b4f0-43c2-91b4-dcee05202b3f"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 2,
                column: "DataGuidID",
                value: new Guid("02690df5-9cf4-4fad-9cb4-29e6e7c2590a"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 3,
                column: "DataGuidID",
                value: new Guid("b4c0465d-4309-4a67-9e0a-43009237a4e8"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 4,
                column: "DataGuidID",
                value: new Guid("fa97a588-4cc5-4550-a2df-3c83f8380b94"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 5,
                column: "DataGuidID",
                value: new Guid("1035b086-ad69-43fa-bbf0-ad96e03d3518"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 6,
                column: "DataGuidID",
                value: new Guid("e74aa11d-3cbd-42f8-b760-18a5b3c0760e"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 7,
                column: "DataGuidID",
                value: new Guid("b2d2fb3d-c4fb-461d-b906-eee14c3e47d8"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 8,
                column: "DataGuidID",
                value: new Guid("a9cb8378-d17e-4465-bd62-56139dfcceed"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 9,
                column: "DataGuidID",
                value: new Guid("a0499c77-98ed-45ca-aa08-80d62b832c19"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 10,
                column: "DataGuidID",
                value: new Guid("31f61ea2-b839-47df-bbdd-cacb1ec39d5b"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 11,
                column: "DataGuidID",
                value: new Guid("6ce738c8-13ae-4f3e-8747-8cfb41f89fde"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 12,
                column: "DataGuidID",
                value: new Guid("90b4132f-7e64-4a2c-8210-fbe04d57acb5"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 13,
                column: "DataGuidID",
                value: new Guid("49ac6df6-e027-43de-bf79-c35324f15fd1"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 14,
                column: "DataGuidID",
                value: new Guid("ae34ee15-b0d3-45e6-933d-6d1971fd400a"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 15,
                column: "DataGuidID",
                value: new Guid("873ed809-dd57-46be-aee7-cc5257729e98"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 16,
                column: "DataGuidID",
                value: new Guid("fa4ab26e-c766-44df-ac81-e9be5062cd23"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 17,
                column: "DataGuidID",
                value: new Guid("4ebe836f-bcd8-4085-9a48-34873c3e9ee0"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 18,
                column: "DataGuidID",
                value: new Guid("3526ba00-c8ce-49ab-b2b2-ca552d708c95"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 19,
                column: "DataGuidID",
                value: new Guid("5cfc1d22-1a28-483b-bebd-f0b05b4e9172"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 20,
                column: "DataGuidID",
                value: new Guid("56d39132-801e-4d5b-a15b-3d046a9ed845"));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 1,
                column: "DataGuidID",
                value: new Guid("35a89318-6d8f-4192-9f30-619531f27c48"));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 2,
                column: "DataGuidID",
                value: new Guid("48a46aa0-7289-4234-aec3-2a40395954f8"));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DataGuidID" },
                values: new object[] { new DateTime(2021, 4, 19, 12, 18, 56, 915, DateTimeKind.Local).AddTicks(6056), new Guid("e0bc8811-fb20-4e7e-af59-aa377b5f0b4f") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DataGuidID" },
                values: new object[] { new DateTime(2021, 4, 19, 12, 18, 56, 918, DateTimeKind.Local).AddTicks(7311), new Guid("2283f0b4-876e-4795-8683-c202978f342b") });
        }
    }
}
