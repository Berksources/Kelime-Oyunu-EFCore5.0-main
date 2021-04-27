using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity.KelimeOyunu.Migrations
{
    public partial class DbContextSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 1,
                column: "DataGuidID",
                value: new Guid("6285d002-2724-4dae-9028-b1ba98911b58"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 2,
                column: "DataGuidID",
                value: new Guid("a39264dc-c8a9-4d69-bf1e-56b8d690673f"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 3,
                column: "DataGuidID",
                value: new Guid("506d3a56-d846-4791-8192-77a48c3361c4"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 4,
                column: "DataGuidID",
                value: new Guid("3186949f-7578-45eb-b4bb-ce58f8e6c360"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 5,
                column: "DataGuidID",
                value: new Guid("718533dc-9aac-4f40-8ff9-fbd23d41bbf9"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 6,
                column: "DataGuidID",
                value: new Guid("fddeee7e-dde4-4bea-813d-186eb20f4072"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 7,
                columns: new[] { "DataGuidID", "EightWordAnswer", "EightWordData" },
                values: new object[] { new Guid("78c28158-e7ce-40f1-8e25-acc8bf1c103c"), "İskorpit", "İskorpit" });

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 8,
                column: "DataGuidID",
                value: new Guid("d56bc10a-f115-4dca-b02c-62c7d25d8bbd"));

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 9,
                columns: new[] { "DataGuidID", "EightWordAnswer", "EightWordData" },
                values: new object[] { new Guid("30102019-2594-4bde-ab86-28baf471325b"), "Filoloji", "Filoloji" });

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 10,
                columns: new[] { "DataGuidID", "EightWordAnswer", "EightWordData" },
                values: new object[] { new Guid("a822d458-9345-4ff5-b704-55716be927ee"), "Anestezi", "Anestezi" });

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 11,
                columns: new[] { "DataGuidID", "EightWordAnswer", "EightWordData" },
                values: new object[] { new Guid("cf212e08-6ed7-4a78-ae54-f9f8eb05002c"), "Kırılmak", "Kırılmak" });

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 12,
                columns: new[] { "DataGuidID", "EightWordAnswer", "EightWordData" },
                values: new object[] { new Guid("61842b4b-0311-4085-8ba3-6e7c6993dcc1"), "Mükemmel", "Mükemmel" });

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 13,
                columns: new[] { "DataGuidID", "EightWordAnswer", "EightWordData" },
                values: new object[] { new Guid("614ca7bb-9cc3-4cb5-9a99-30bc584b1af4"), "Dengesiz", "Dengesiz" });

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 14,
                columns: new[] { "DataGuidID", "EightWordAnswer", "EightWordData" },
                values: new object[] { new Guid("b9ecf790-47ca-4c9d-aac5-6e43c0426ab7"), "Yayçizer", "Yayçizer" });

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 15,
                columns: new[] { "DataGuidID", "EightWordAnswer", "EightWordData" },
                values: new object[] { new Guid("1c6e9359-4076-44f0-8720-fbc93cf6f8b3"), "Haytalık", "Haytalık" });

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 16,
                columns: new[] { "DataGuidID", "EightWordAnswer", "EightWordData" },
                values: new object[] { new Guid("ae6f3211-4250-406d-94dd-a445850860e4"), "Rahmetli", "Rahmetli" });

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 17,
                columns: new[] { "DataGuidID", "EightWordAnswer", "EightWordData" },
                values: new object[] { new Guid("6cb780b5-9957-47d3-bfef-3938d31f87c8"), "Terminal", "Terminal" });

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 18,
                columns: new[] { "DataGuidID", "EightWordAnswer", "EightWordData" },
                values: new object[] { new Guid("6d1e62a9-e3e0-400c-bc27-890328a28672"), "Selamlık", "Selamlık" });

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 19,
                columns: new[] { "DataGuidID", "EightWordAnswer", "EightWordData" },
                values: new object[] { new Guid("7b0b3329-8d15-433b-a021-9b02490bba30"), "Berhudar", "Berhudar" });

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 20,
                columns: new[] { "DataGuidID", "EightWordData" },
                values: new object[] { new Guid("2de51e21-990a-4e78-8255-9fac6890a15e"), "Tercihen" });

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 1,
                column: "DataGuidID",
                value: new Guid("28baa087-3f8c-438e-b408-98b8b24d4b24"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 2,
                column: "DataGuidID",
                value: new Guid("f7a7f675-3afb-4492-b285-a64ba8d9e7d5"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 3,
                column: "DataGuidID",
                value: new Guid("bd018e95-5a1c-4f47-b62a-2af771484351"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 4,
                column: "DataGuidID",
                value: new Guid("39bae6ef-0f9d-446c-b134-ea888c8482e7"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 5,
                column: "DataGuidID",
                value: new Guid("49ea27f6-5b49-4edf-a883-abe62594537f"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 6,
                column: "DataGuidID",
                value: new Guid("8c305f71-fd00-4c8f-849e-3179163964e1"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 7,
                column: "DataGuidID",
                value: new Guid("ac119060-276b-47cf-8a06-fa74bf43c66c"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 8,
                column: "DataGuidID",
                value: new Guid("8a32b510-63e9-44f4-92be-5b3d6c6296b0"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 9,
                column: "DataGuidID",
                value: new Guid("c80a8cde-3db3-4617-9fd2-1499a49f875c"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 10,
                column: "DataGuidID",
                value: new Guid("4066020c-2952-4fe0-892e-3d5b8f338c26"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 11,
                column: "DataGuidID",
                value: new Guid("4eea117e-51af-4786-9831-cf8629cbc3c5"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 12,
                column: "DataGuidID",
                value: new Guid("7a7474c8-6813-48ce-a50a-87f18761bb5f"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 13,
                column: "DataGuidID",
                value: new Guid("16a69983-678d-43b7-bc53-72042dcbf1b0"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 14,
                column: "DataGuidID",
                value: new Guid("2143fa13-e196-4396-8c17-120aa5f5aea0"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 15,
                column: "DataGuidID",
                value: new Guid("a30ef569-84d1-432a-ba69-d86c1669f3fe"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 16,
                column: "DataGuidID",
                value: new Guid("d75f822d-f628-4f0b-8551-3e15c26c7dee"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 17,
                column: "DataGuidID",
                value: new Guid("ff4093e8-5dfc-4fb4-8318-21a5261b2011"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 18,
                column: "DataGuidID",
                value: new Guid("bc9b2b62-9863-4995-bf33-fc76e716d763"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 19,
                column: "DataGuidID",
                value: new Guid("5bc824bd-793a-4e4a-a03f-d72cc6eb7a90"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 20,
                column: "DataGuidID",
                value: new Guid("aa6d76da-e761-40bf-aaaf-e6d3d046d94e"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 1,
                column: "DataGuidID",
                value: new Guid("ef00b18f-592d-49c8-a85a-dac057df29fe"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 2,
                column: "DataGuidID",
                value: new Guid("35ac9561-d012-4eba-81cc-84da0cf6e8b0"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 3,
                column: "DataGuidID",
                value: new Guid("8d3b447e-3173-44ac-a04e-61b4263d89f5"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 4,
                column: "DataGuidID",
                value: new Guid("97cf6202-b297-40f7-a779-761094bc95f1"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 5,
                column: "DataGuidID",
                value: new Guid("2d3ef4d6-fdf6-450c-bd43-063c050c68cd"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 6,
                column: "DataGuidID",
                value: new Guid("629d045a-ef4e-41ef-a2e2-9ced06f3895f"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 7,
                column: "DataGuidID",
                value: new Guid("79d67fbd-d266-470d-935b-5e96b5dcb607"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 8,
                column: "DataGuidID",
                value: new Guid("49cfff41-44b1-47a1-b5ac-ca00ab5a9352"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 9,
                column: "DataGuidID",
                value: new Guid("ddf18208-8f99-40b4-80a5-81f269f80be1"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 10,
                column: "DataGuidID",
                value: new Guid("1cb08e80-55cc-4e77-91ae-a7e5e9ef4a1c"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 11,
                column: "DataGuidID",
                value: new Guid("29638992-185b-4fbe-8d45-437053c5c113"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 12,
                column: "DataGuidID",
                value: new Guid("bc6c853b-a9d9-4fc9-832f-b7656aa9cfff"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 13,
                column: "DataGuidID",
                value: new Guid("88c79c02-7906-4909-b8bb-908bbc19f4a1"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 14,
                column: "DataGuidID",
                value: new Guid("b861cf94-409b-4e00-a515-7e6cf0ecabb4"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 15,
                column: "DataGuidID",
                value: new Guid("76d19c8f-ef4a-40d6-b12f-e163389318b0"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 16,
                column: "DataGuidID",
                value: new Guid("396ad91e-bc35-4d62-8e2a-d463cd88f902"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 17,
                column: "DataGuidID",
                value: new Guid("0e22224e-5e1f-4c77-bab6-24f3c354a308"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 18,
                column: "DataGuidID",
                value: new Guid("7920cb50-043a-47b4-b292-44dbe8f0e842"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 19,
                column: "DataGuidID",
                value: new Guid("899cc5c7-fb39-41e3-afed-a5bcd01399a5"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 20,
                column: "DataGuidID",
                value: new Guid("5891ef5a-39d4-45f5-890c-bcd5a9894f4e"));

            migrationBuilder.UpdateData(
                table: "GameVariants",
                keyColumn: "GameVariantID",
                keyValue: 1,
                column: "DataGuidID",
                value: new Guid("a6f0a440-e0bb-4679-b1ad-b5fb03b63798"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 1,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData" },
                values: new object[] { new Guid("d7cabd4c-33ca-4ef6-a7b0-556abf204779"), "Ilıştırma", "Ilıştırma" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 2,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData" },
                values: new object[] { new Guid("1795fdf1-de8a-4d0e-8a8f-8ed524d1e0ff"), "Pörtlemek", "Pörtlemek" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 3,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData", "NineWordQuestion" },
                values: new object[] { new Guid("b4c727d1-bdaf-4703-9dab-ed2bb4eeb9fa"), "Portbagaj", "Portbagaj", "Araç üstü yüklüğü" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 4,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData" },
                values: new object[] { new Guid("717f417e-2c48-488b-9950-b4aacbd9edb4"), "Doğumhane", "Doğumhane" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 5,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData" },
                values: new object[] { new Guid("224992f1-3ec7-401c-97e8-acf4e29b26fe"), "Maksietek", "Maksietek" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 6,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData" },
                values: new object[] { new Guid("1b55b66f-11b9-4657-9161-2a8b4e24b6e0"), "Sabitleme", "Sabitleme" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 7,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData" },
                values: new object[] { new Guid("6bdcb8d6-623a-47ed-a312-6b3be29a0982"), "Kabasakal", "Kabasakal" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 8,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData" },
                values: new object[] { new Guid("9037e08f-5659-4904-8e2a-eeca1bc8a839"), "Morartmak", "Morartmak" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 9,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData" },
                values: new object[] { new Guid("821f8902-1aff-4fdb-bd79-cd3296c73d84"), "Resmetmek", "Resmetmek" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 10,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData" },
                values: new object[] { new Guid("e8123951-e65d-4f45-b7b6-87b7dd3abc83"), "Sırtsırta", "Sırtsırta" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 11,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData" },
                values: new object[] { new Guid("9b067b18-e4f9-479d-9fb2-7359336d56ef"), "Katçıkmak", "Katçıkmak" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 12,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData" },
                values: new object[] { new Guid("d6398af1-6b58-49b3-be15-69bf7fa7f77b"), "Uzatmalar", "Uzatmalar" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 13,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData" },
                values: new object[] { new Guid("78056eb2-cdef-434f-98c8-d2798244d76b"), "Düzeltmek", "Düzeltmek" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 14,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData", "NineWordQuestion" },
                values: new object[] { new Guid("7cfc6cbb-e7c9-49a7-ba1e-556f45d05042"), "Düşmanlık", "Düşmanlık", "Bir insanın öfke ve nefret beslediği kişi veya kişilere yönelttiği kötü duygu ve/veya eylem" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 15,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData", "NineWordQuestion" },
                values: new object[] { new Guid("24923b89-4be4-4aa6-a8d9-eb204806fb3a"), "Koşubandı", "Koşubandı", "Elektrik yardımıyla dönen bir şerit üzerinde egzersiz yapmaya yarayan araç" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 16,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData" },
                values: new object[] { new Guid("1c42a14d-5dba-44d9-b58a-51f5894b4f4a"), "Tüysıklet", "Tüysıklet" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 17,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData" },
                values: new object[] { new Guid("7fce13c9-a228-49b0-8df8-621526d32b38"), "Uçaksavar", "Uçaksavar" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 18,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData" },
                values: new object[] { new Guid("9717cd86-59f5-40c8-b26c-c20f7be34031"), "Hızvermek", "Hızvermek" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 19,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData" },
                values: new object[] { new Guid("1ad147a0-146b-47e4-aacd-ab95c72678d8"), "Karasaban", "Karasaban" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 20,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData" },
                values: new object[] { new Guid("4446d5a5-7ecb-4cf5-8283-04c9083d0532"), "Seslenmek", "Seslenmek" });

            migrationBuilder.InsertData(
                table: "ScoreTables",
                columns: new[] { "ScoreTableID", "CreatedDate", "DataGuidID", "ModifiedDate", "ScoreData", "UserID" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c7fbbd0c-ff39-4508-9133-9143698e53a6"), null, 7600, 2 });

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 1,
                column: "DataGuidID",
                value: new Guid("18f882d8-2a64-42f8-adb9-f5ab3b811a02"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 2,
                column: "DataGuidID",
                value: new Guid("7a2d2454-42e0-432f-8372-f2be187e55ab"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 3,
                column: "DataGuidID",
                value: new Guid("e8b6382a-e7dd-4ac9-8175-a5847b171637"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 4,
                column: "DataGuidID",
                value: new Guid("8d3f9133-1333-4837-93db-d03b40d8fa21"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 5,
                column: "DataGuidID",
                value: new Guid("b5408531-8000-421d-ad1e-a7b14ea5c181"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 6,
                column: "DataGuidID",
                value: new Guid("b8ee0df7-8076-4218-80e6-83a1ce66471f"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 7,
                column: "DataGuidID",
                value: new Guid("d06efce0-5b9f-45da-91f6-9854edd29825"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 8,
                column: "DataGuidID",
                value: new Guid("a274c379-33ba-4a8d-a606-a51a73a23b81"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 9,
                column: "DataGuidID",
                value: new Guid("09e56135-a9ba-4b18-8a2c-6f9436d7282a"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 10,
                column: "DataGuidID",
                value: new Guid("80b7c578-ce35-4a86-a1ec-5032ecd0a776"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 11,
                column: "DataGuidID",
                value: new Guid("ce7a8b57-9d4b-4d64-a8ff-a35a4428e28b"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 12,
                column: "DataGuidID",
                value: new Guid("fe14b0fd-3a7f-41ee-a300-a92de5e91bbf"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 13,
                column: "DataGuidID",
                value: new Guid("2330b766-2038-468a-97e3-8682afacab2b"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 14,
                column: "DataGuidID",
                value: new Guid("549f881e-44c1-43e0-9b0d-387d89e31915"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 15,
                column: "DataGuidID",
                value: new Guid("d7cbc92f-ff87-4a41-9110-c88959637853"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 16,
                column: "DataGuidID",
                value: new Guid("c01ec57f-7141-4dfa-981e-51be3c257232"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 17,
                column: "DataGuidID",
                value: new Guid("90819eb2-0601-426f-8c27-fc422f1182dd"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 18,
                column: "DataGuidID",
                value: new Guid("66660ea1-830c-40c6-8c82-0a954ad4427a"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 19,
                column: "DataGuidID",
                value: new Guid("87d2eb57-8180-4287-bd75-eccf97134385"));

            migrationBuilder.UpdateData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 20,
                column: "DataGuidID",
                value: new Guid("d4c8436a-ee37-481c-a689-9b71775332f3"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 1,
                column: "DataGuidID",
                value: new Guid("62bc0413-d06c-4b69-bcf6-098c532ac974"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 2,
                column: "DataGuidID",
                value: new Guid("be48e86a-0289-4857-b288-d42835a4a4ab"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 3,
                column: "DataGuidID",
                value: new Guid("8d54202f-eb1a-425b-93ad-052c766f4a72"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 4,
                column: "DataGuidID",
                value: new Guid("449f5309-572d-4465-a2fc-3cec75b82cfd"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 5,
                column: "DataGuidID",
                value: new Guid("70db1ae7-0729-4070-93f4-f4155b63d898"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 6,
                column: "DataGuidID",
                value: new Guid("954ca190-91c9-4022-af3c-a3741b1d185b"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 7,
                column: "DataGuidID",
                value: new Guid("f9eeb1c6-7d7d-4108-8cae-d3353a1e613a"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 8,
                column: "DataGuidID",
                value: new Guid("f81b4264-86f2-408a-afa6-bb571a2dd5c8"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 9,
                column: "DataGuidID",
                value: new Guid("6e6560fc-4de0-441f-ab7b-19d5d9e6a48d"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 10,
                column: "DataGuidID",
                value: new Guid("312d0ed5-b106-4808-a568-d2991c42dca2"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 11,
                column: "DataGuidID",
                value: new Guid("12efd17f-df37-492b-a3a5-f8265f7d51c8"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 12,
                column: "DataGuidID",
                value: new Guid("d41159fe-d364-4d86-a92d-d852b4a1f3ab"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 13,
                column: "DataGuidID",
                value: new Guid("71930378-c708-4755-a5b9-cf82e051567a"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 14,
                column: "DataGuidID",
                value: new Guid("19da6cc5-d02e-45ba-ad34-7c2d1a66d9ed"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 15,
                column: "DataGuidID",
                value: new Guid("048107e8-0614-49c4-b565-d763b184066f"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 16,
                column: "DataGuidID",
                value: new Guid("1540b1b5-6a14-4a0f-8eab-1db9ae14eec8"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 17,
                column: "DataGuidID",
                value: new Guid("27307e37-f561-4d5f-947d-af4e037b73b6"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 18,
                column: "DataGuidID",
                value: new Guid("0a21afd2-1459-41d4-ba45-f322468cbe42"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 19,
                column: "DataGuidID",
                value: new Guid("9c4f9d9d-b59a-4965-9d6b-edd58b2a08dd"));

            migrationBuilder.UpdateData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 20,
                column: "DataGuidID",
                value: new Guid("a7a264f5-1238-4215-af01-2925cc4d53e0"));

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 1,
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData" },
                values: new object[] { new Guid("1d144bea-7cbc-4c0e-ab3e-e592f611e83a"), "Müteakiben", "Müteakiben" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 2,
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData" },
                values: new object[] { new Guid("d29b1dd1-39cf-4693-b4b1-55113f347e6c"), "Elmaşekeri", "Elmaşekeri" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 3,
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData" },
                values: new object[] { new Guid("4c44d852-2d36-4659-8a7d-07488b927e8f"), "Kankanseri", "Kankanseri" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 4,
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData" },
                values: new object[] { new Guid("56cae09f-87af-495a-9e6a-912f11dff80c"), "Peydahlama", "Peydahlama" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 5,
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData" },
                values: new object[] { new Guid("0b42ed27-d9dc-4954-bc48-cc9eae45bcec"), "Kuyukebabı", "Maksietek" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 6,
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData" },
                values: new object[] { new Guid("c1e392f8-9d0e-4495-a118-69c84328dc05"), "Temelatmak", "Temelatmak" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 7,
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData" },
                values: new object[] { new Guid("cdf4ee6a-6afa-4542-abcd-afb989f4c24b"), "Kalpyarası", "Kalpyarası" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 8,
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData", "TenWordQuestion" },
                values: new object[] { new Guid("3b6fdd7a-3459-455c-9463-1693fe9bbad6"), "Püfnoktası", "Püfnoktası", "Bir işin en ince, hassas ve önemli kısmı" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 9,
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData" },
                values: new object[] { new Guid("5aa62b0f-4eca-4215-bbfd-bd3555c58e1f"), "Mumadönmek", "Mumadönmek" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 10,
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData" },
                values: new object[] { new Guid("3d79ad69-4df0-438d-92b9-f687db8e6f96"), "Kızılırmak", "Kızılırmak" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 11,
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData" },
                values: new object[] { new Guid("ad423f5b-f5c1-42e1-9651-428abaaa2c77"), "Senetsepet", "Senetsepet" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 12,
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData" },
                values: new object[] { new Guid("5c440387-952c-4bba-a5d0-f723a73fa9ef"), "Yaşlıbaşlı", "Yaşlıbaşlı" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 13,
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData" },
                values: new object[] { new Guid("f7cac60b-2726-4552-b056-e8ab4ba8f3a7"), "Hedefkitle", "Hedefkitle" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 14,
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData" },
                values: new object[] { new Guid("f17e256c-b662-4bcf-abb8-6215f0e5df98"), "Karşılaşma", "Karşılaşma" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 15,
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData" },
                values: new object[] { new Guid("15fd0e49-d1f1-4dc7-a49e-422cc13a144e"), "Hazırbeton", "Hazırbeton" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 16,
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData" },
                values: new object[] { new Guid("16ee60fc-7a5b-420f-a437-085e9d9e4e55"), "İhmaletmek", "İhmaletmek" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 17,
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData" },
                values: new object[] { new Guid("41b58403-a6a6-4a96-8954-af1c380fdda5"), "İşlemhacmi", "İşlemhacmi" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 18,
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData" },
                values: new object[] { new Guid("3bd81022-bb6c-4685-8dce-a726192ba11b"), "Başaramama", "Başaramama" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 19,
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData" },
                values: new object[] { new Guid("242dc7ac-579d-4d01-a035-07a2c998177c"), "Kaskolamak", "Kaskolamak" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 20,
                columns: new[] { "DataGuidID", "TenWordAnswer" },
                values: new object[] { new Guid("cdc92c6f-ae5a-49b3-9ee6-312a65e91e67"), "Loloyapmak" });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 1,
                column: "DataGuidID",
                value: new Guid("01c9c4b9-3ab0-427c-b23f-3aa4f068bb7f"));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 2,
                column: "DataGuidID",
                value: new Guid("e759567b-0b81-4f3a-8083-a920fd67f821"));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DataGuidID" },
                values: new object[] { new DateTime(2021, 4, 26, 10, 39, 32, 116, DateTimeKind.Local).AddTicks(5973), new Guid("aae2a34c-8b1c-4fe7-bd5c-51bd55a282ce") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DataGuidID" },
                values: new object[] { new DateTime(2021, 4, 26, 10, 39, 32, 119, DateTimeKind.Local).AddTicks(1405), new Guid("32dba502-55e9-482d-801d-b1b369103542") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ScoreTables",
                keyColumn: "ScoreTableID",
                keyValue: 1);

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
                columns: new[] { "DataGuidID", "EightWordAnswer", "EightWordData" },
                values: new object[] { new Guid("cf248ceb-9774-412d-9701-960aadea93e9"), " İskorpit", " İskorpit" });

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
                columns: new[] { "DataGuidID", "EightWordAnswer", "EightWordData" },
                values: new object[] { new Guid("f166d10d-6322-4649-baea-a13ded000c9b"), " Filoloji", " Filoloji" });

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 10,
                columns: new[] { "DataGuidID", "EightWordAnswer", "EightWordData" },
                values: new object[] { new Guid("e46b813c-4689-45dd-a3d2-f08f4a530e54"), " Anestezi", " Anestezi" });

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 11,
                columns: new[] { "DataGuidID", "EightWordAnswer", "EightWordData" },
                values: new object[] { new Guid("f434d2b5-8626-4c6b-b35d-10ae11603caf"), " Kırılmak", " Kırılmak" });

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 12,
                columns: new[] { "DataGuidID", "EightWordAnswer", "EightWordData" },
                values: new object[] { new Guid("f12b4209-b247-45f4-9a84-5da98866fa85"), " Mükemmel", " Mükemmel" });

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 13,
                columns: new[] { "DataGuidID", "EightWordAnswer", "EightWordData" },
                values: new object[] { new Guid("18da561f-fe4d-41fa-9739-e205edfcb7bf"), " Dengesiz", " Dengesiz" });

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 14,
                columns: new[] { "DataGuidID", "EightWordAnswer", "EightWordData" },
                values: new object[] { new Guid("ffaf184b-93b8-468c-a070-375646ee2819"), " Yayçizer", " Yayçizer" });

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 15,
                columns: new[] { "DataGuidID", "EightWordAnswer", "EightWordData" },
                values: new object[] { new Guid("be200b4a-a04a-47f0-9dca-143bacb52636"), " Haytalık", " Haytalık" });

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 16,
                columns: new[] { "DataGuidID", "EightWordAnswer", "EightWordData" },
                values: new object[] { new Guid("53ee939c-f7c9-47cb-8a23-55e5e5e848e9"), " Rahmetli", " Rahmetli" });

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 17,
                columns: new[] { "DataGuidID", "EightWordAnswer", "EightWordData" },
                values: new object[] { new Guid("1f4559f4-b893-48c8-831c-7bc453144265"), " Terminal", " Terminal" });

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 18,
                columns: new[] { "DataGuidID", "EightWordAnswer", "EightWordData" },
                values: new object[] { new Guid("77442b24-95b8-421b-9d7e-15ec4a402142"), " Selamlık", " Selamlık" });

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 19,
                columns: new[] { "DataGuidID", "EightWordAnswer", "EightWordData" },
                values: new object[] { new Guid("5e41dac5-57a9-4204-b999-6121bf3b1a0d"), " Berhudar", " Berhudar" });

            migrationBuilder.UpdateData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 20,
                columns: new[] { "DataGuidID", "EightWordData" },
                values: new object[] { new Guid("c22358a6-bdcb-4ace-89cd-41bf75466c41"), " Tercihen" });

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

            migrationBuilder.UpdateData(
                table: "GameVariants",
                keyColumn: "GameVariantID",
                keyValue: 1,
                column: "DataGuidID",
                value: new Guid("74eeabff-4a30-4c57-8acc-bd0da841296f"));

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 1,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData" },
                values: new object[] { new Guid("d5cffe3f-6f76-43ec-9212-257bc9b7aaa9"), " Ilıştırma", " Ilıştırma" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 2,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData" },
                values: new object[] { new Guid("40567c70-1c99-451a-b34f-2693c786236e"), " Pörtlemek", " Pörtlemek" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 3,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData", "NineWordQuestion" },
                values: new object[] { new Guid("62221308-d3fe-489a-8c6a-05f33e9006ab"), " Portbagaj", " Portbagaj", "  Araç üstü yüklüğü" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 4,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData" },
                values: new object[] { new Guid("78fbab84-7cc0-4075-9364-be165480ffa9"), " Doğumhane", " Doğumhane" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 5,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData" },
                values: new object[] { new Guid("ecd3c6d2-4584-4583-b9d2-645aa5d002fd"), " Maksietek", " Maksietek" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 6,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData" },
                values: new object[] { new Guid("df0abf54-2760-4284-b0ed-735c684d334d"), " Sabitleme", " Sabitleme" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 7,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData" },
                values: new object[] { new Guid("55618d80-5ce3-4eb7-b4e8-b29b3085850d"), "  Kabasakal", "  Kabasakal" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 8,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData" },
                values: new object[] { new Guid("601a8315-6cfe-4248-9239-287b10043b20"), " Morartmak", " Morartmak" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 9,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData" },
                values: new object[] { new Guid("6a297e4f-9811-4583-95ce-5b3baedfc7a8"), " Resmetmek", " Resmetmek" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 10,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData" },
                values: new object[] { new Guid("1cea01d7-a01c-43f9-8e45-778ce8dd327a"), "  Sırtsırta", "  Sırtsırta" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 11,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData" },
                values: new object[] { new Guid("99224d48-9b35-4dc6-bd73-412612212d0d"), "  Katçıkmak", " Katçıkmak" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 12,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData" },
                values: new object[] { new Guid("2f7cd057-a655-443e-805d-9e7658a1ec7d"), "  Uzatmalar", " Uzatmalar" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 13,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData" },
                values: new object[] { new Guid("215f3c0b-ddde-4ec8-8fa1-811ec2a9407d"), "  Düzeltmek", " Düzeltmek" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 14,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData", "NineWordQuestion" },
                values: new object[] { new Guid("1da8cbbe-f004-4ce3-a2a9-b9573a74e3dc"), "  Düşmanlık", "  Düşmanlık", " Bir insanın öfke ve nefret beslediği kişi veya kişilere yönelttiği kötü duygu ve/veya eylem" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 15,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData", "NineWordQuestion" },
                values: new object[] { new Guid("54bff03f-0b4d-47d7-8ee3-c1359a665051"), " Koşubandı", " Koşubandı", " Elektrik yardımıyla dönen bir şerit üzerinde egzersiz yapmaya yarayan araç" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 16,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData" },
                values: new object[] { new Guid("b52cf34a-f416-44ed-8c47-8b0bca4ad40a"), " Tüysıklet", "  Tüysıklet" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 17,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData" },
                values: new object[] { new Guid("a22666c5-5e56-4071-8e34-4bb4f6e6bc92"), "  Uçaksavar", " Uçaksavar" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 18,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData" },
                values: new object[] { new Guid("cda2baeb-3175-4561-9f5f-c4dddd62f4ec"), "  Hızvermek", " Hızvermek" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 19,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData" },
                values: new object[] { new Guid("ff021152-6ce0-4613-9dc1-50a628890e89"), " Karasaban", "  Karasaban" });

            migrationBuilder.UpdateData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 20,
                columns: new[] { "DataGuidID", "NineWordAnswer", "NineWordData" },
                values: new object[] { new Guid("ccbdfdb5-1488-4b94-9fd6-c8970456ddd9"), " Seslenmek", " Seslenmek" });

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
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData" },
                values: new object[] { new Guid("5822bbf4-670a-453d-9a3b-3ee1b365e45a"), " Müteakiben", " Müteakiben" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 2,
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData" },
                values: new object[] { new Guid("5268abee-598e-401e-8887-746058168547"), " Elmaşekeri", " Elmaşekeri" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 3,
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData" },
                values: new object[] { new Guid("4eee835c-f9f7-4ae7-af6a-b94b7977dbea"), " Kankanseri", " Kankanseri" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 4,
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData" },
                values: new object[] { new Guid("14d252d8-b084-471c-827e-47a5c3a361a0"), "  Peydahlama", " Peydahlama" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 5,
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData" },
                values: new object[] { new Guid("76f5ff69-0b7f-4a47-8769-1fa75ccb48c4"), "  Kuyukebabı", " Maksietek" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 6,
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData" },
                values: new object[] { new Guid("314ec086-09b9-4b98-badb-d5d43efb22c9"), "  Temelatmak", " Temelatmak" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 7,
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData" },
                values: new object[] { new Guid("5bbb9e4b-5847-48fc-8fff-05ad37ace75a"), " Kalpyarası", " Kalpyarası" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 8,
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData", "TenWordQuestion" },
                values: new object[] { new Guid("031eaca1-6fca-437f-8ef2-2c335fcb49d3"), " Püfnoktası", " Püfnoktası", "  Bir işin en ince, hassas ve önemli kısmı" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 9,
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData" },
                values: new object[] { new Guid("8a30c46c-faa6-4e50-97ec-b354e27c201f"), " Mumadönmek", "  Mumadönmek" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 10,
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData" },
                values: new object[] { new Guid("fb1319ef-67d1-4ac6-902c-9895a3a105fa"), " Kızılırmak", " Kızılırmak" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 11,
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData" },
                values: new object[] { new Guid("d5d42aef-6f5a-4629-a311-9c08bc0a9f91"), " Senetsepet", " Senetsepet" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 12,
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData" },
                values: new object[] { new Guid("bba6fa02-ef45-4a6b-90bd-7a2e68a5dc46"), "  Yaşlıbaşlı", " Yaşlıbaşlı" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 13,
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData" },
                values: new object[] { new Guid("af17ef73-2926-49fe-ac00-b16aab01e51d"), "  Hedefkitle", " Hedefkitle" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 14,
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData" },
                values: new object[] { new Guid("01981ba9-26d8-49f1-8f12-9a40e3a16341"), " Karşılaşma", " Karşılaşma" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 15,
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData" },
                values: new object[] { new Guid("ee38d9ae-12c1-41b8-8152-50e6d1ad7367"), " Hazırbeton", " Hazırbeton" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 16,
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData" },
                values: new object[] { new Guid("0218a1b2-e887-49b3-92ee-50621836f865"), "  İhmaletmek", "  İhmaletmek" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 17,
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData" },
                values: new object[] { new Guid("46216f08-e1e7-4558-8b75-abdce28c5a02"), " İşlemhacmi", "  İşlemhacmi" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 18,
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData" },
                values: new object[] { new Guid("336b996d-8a0e-44a8-928d-82b89b8bdd43"), " Başaramama", " Başaramama" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 19,
                columns: new[] { "DataGuidID", "TenWordAnswer", "TenWordData" },
                values: new object[] { new Guid("130cf34e-388d-4f2d-b1e7-4b9b113b26be"), " Kaskolamak", " Kaskolamak" });

            migrationBuilder.UpdateData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 20,
                columns: new[] { "DataGuidID", "TenWordAnswer" },
                values: new object[] { new Guid("f00d3b6e-58b4-4acc-8aa0-91b317d32f52"), " Loloyapmak" });

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
    }
}
