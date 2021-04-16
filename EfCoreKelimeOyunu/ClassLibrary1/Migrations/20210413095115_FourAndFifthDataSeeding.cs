using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity.KelimeOyunu.Migrations
{
    public partial class FourAndFifthDataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FifthWords",
                columns: new[] { "FifthWordID", "CreatedDate", "DataGuidID", "FifthWordAnswer", "FifthWordData", "FifthWordQuestion", "FifthWordScore", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0d10a884-5ca9-406e-ae84-3b838d851222"), "Kobay", "Kobay", "Bir deneyin edilgen katılımcısı", 500, null },
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4134c643-51ec-469d-8fea-375cbb642dec"), "Islık", "Islık", "Dil dudak yoluyla çıkarılan tiz ses", 500, null },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a1d96912-a0c3-434c-9872-72c9611e0fc2"), "Hülya", "Hülya", "Tatlı düş", 500, null },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e34a57f2-c109-406b-9357-3cabf8d93825"), "Rakam", "Rakam", "Sayıları göstermek için kullanılan işaretlerden her biri", 500, null },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bad2b86c-3d0a-4ca4-ae9a-da5e0c5f7c9e"), "Patak", "Patak", "“Dayak, kötek” anlamlarında bir sözcük", 500, null },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eef6c7e5-8fce-43cd-8e96-cfe057531203"), "Lokum", "Lokum", "Kauçuk ve jelatin kıvamındaki bir dinamit formuna da adını veren tatlıs", 500, null },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4f4a3749-3294-40e6-95fb-61dc6496955b"), "Nadir", "Nadir", "“Seyrek” sözünün eş ve yakın anlamlı karşılığı", 500, null },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bce18124-14b9-4de5-9a89-6e20bdf50d79"), "Lopet", "Lopet", "Kasaplık hayvanlardan sağlanan kemiksiz besin maddesi", 500, null },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5a93d26-1574-4167-aea1-0fd6260531f7"), "Litre", "Litre", "Bir desimetreküp hacmindeki ölçü birimi", 500, null },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1a0015c1-5e93-4551-9cbb-e9fd073802ea"), "Ilgın", "Ilgın", "Akdeniz’e özgü, Deniz kıyısında bile yetişebilen bir ağaç", 500, null },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fcf57835-858b-4911-b18a-044b0ac0a919"), "Jumbo", "Jumbo", "80X110 ölçülerindeki çöp poşetinin ebatı” için kullanılan söz", 500, null },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("976d4051-5cab-4c9f-9bb8-5668f5136b94"), "Cephe", "Cephe", "Üzerinde savaşın sürdüğü bölge", 500, null },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7817f7d3-1083-49d9-b6cb-1941af0f26d6"), "Pilav", "Pilav", "Eski mezun toplantılarının vazgeçilmez yemeği", 500, null },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("87f53b71-acac-40ae-9846-6d0f4d18d1d0"), "Bücür", "Bücür", "Sempatik bodur", 500, null },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6d25d85c-eb6e-46c1-b5d1-7a2b7706bc92"), "Kıraç", "Kıraç", "“İşlenmemiş verimsiz araziler ve topraklar” için kullanılan bir söz", 500, null },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5fc5e8ab-f7e5-406f-91af-ca1222f822e7"), "Hatmi", "Hatmi", "Mora çalan pembe, bordo çiçekler açan şifalı bir bitki", 500, null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c6a3f239-517c-4cab-a255-ac579dfe7f2c"), "Canım", "Canım", "Yürekten gelen, sahiplenen, en sade sevgi sözü", 500, null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51c59c0-dd23-479f-a5c0-a33e0e640ecc"), "Kadın", "Kadın", "Eşeysel yaratılış özelliğinde letafet barındıran insan, cinsilatif", 500, null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("704ea285-c0ca-438d-9874-ce1385c149f4"), "Damar", "Damar", "Argoda, “Hüznü ruha zerk eden şarkılar” için kullanılan bir söz", 500, null },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("db3c0e17-9d60-47f5-9f5b-87813bbacc50"), "Sumak", "Sumak", "Özellikle kokuyu azalttığı için soğan salatalarında tercih edilen bir baharat", 500, null }
                });

            migrationBuilder.InsertData(
                table: "FourWords",
                columns: new[] { "FourWordID", "CreatedDate", "DataGuidID", "FourWordAnswer", "FourWordData", "FourWordQuestion", "FourWordScore", "ModifiedDate" },
                values: new object[,]
                {
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("200c5692-fb88-487a-8294-09a4ea96de11"), "File", "File", "Çarşı pazar ekonomisinin simgelerinden olan ve artık yeniden popülerleşen ağ torba", 400, null },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("55117fa2-6bda-4fc0-a514-20f972fc8eca"), "İnek", "İnek", "Genç olanlarına “Düve” denen hayvan", 400, null },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("03c55098-9128-46d2-ab37-b7c4b5fea409"), "Eğik", "Eğik", "Dik veya paralel olmayan doğru", 400, null },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("06afbb50-ea9a-4373-bab5-ab3b7a1febd6"), "Filo", "Filo", "Emir komuta zinciri ile bağlı olan taşıtlar topluluğu", 400, null },
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e90712a4-3aac-43c7-86ab-30ec218780af"), "Vaiz", "Vaiz", "İşi ve inancı gereği öğüt veren kişi", 400, null },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7ca38fe1-a0fb-49d3-85f4-151705fd351a"), "Ataş", "Ataş", "İnce bir teli üç kez iç içe bükerek elde edilen bir kırtasiye gereci", 400, null },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c1905aa8-ea6a-4907-9422-18f8393b2f39"), "Edip", "Edip", "Bir erkek adı olarak da kullanılan, “Edebi eser veren kimse, yazar” anlamındaki isim", 400, null },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d158a66d-a690-4153-87e4-5c042c64a791"), "Maaş", "Maaş", "Soru: Aylıkçı nimeti", 400, null },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9b1a1092-bc7a-44db-b512-42f51605173d"), "Cart", "Cart", "“Hoşa gitmeyen, olumsuz yönde dikkat çeken renkleri” niteleyen bir söz", 400, null },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f365c931-1faf-4f8f-ad19-64c857effb98"), "Gece", "Gece", "Nokturnal canlıların aktif olduğu zaman dilimi", 400, null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d9bb46d2-1dc8-44a7-935d-b3d3594cb8e4"), "Vida", "Vida", "Etrafı helis eğrisi biçiminde girintiler ve çıkıntılarla dolanmış çivi ", 400, null },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ca0b1d40-db09-486b-a778-1760340371cf"), "İlik", "İlik", "Etrafı iplikle örülen düğme yarığı", 400, null },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a6ae2e21-6966-4d5e-b867-f725ffc77e44"), "Kask", "Kask", "Modern miğfer", 400, null },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4b3ce5ae-9acc-46f7-abb2-fcd1b3c362fe"), "Aras", "Aras", "Türkiye’nin Doğu Anadolu Bölgesi’nde doğup Hazar Denizi’ne dökülen Nehir", 400, null },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("aa492e04-7034-4c86-87a6-62a02f94d76f"), "Vamp", "Vamp", "“Şuh” sözcüğünün Batı kökenli eş ve yakın anlamlı karşılığı", 400, null },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00f16338-d3bd-43b3-8f16-a582fceda721"), "Tepe", "Tepe", "Yüksekliği 0-500 M. arasında değişen, doğal coğrafi oluşum", 400, null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("229e19c4-4f1a-4d2b-8c47-d20a07918ce2"), "Uyuz", "Uyuz", "Neden olduğu rahatsız edici kaşıntı nedeniyle “Sevimsiz insanlara” da yakıştırılan bir deri hastalığı", 400, null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("32d76761-1d39-46d9-a89a-5001414510e4"), "Ters", "Ters", "Mecazen , 'Gönül ve cesaret kırıcı,huysuz,sert' ", 400, null },
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eb00868d-de76-48f6-91b8-d1b0bc44415c"), "Çare", "Çare", "Umar sözünün daha yaygın kullanılan Farsça kökenli eş anlamlısı ", 400, null },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("df9133d4-c768-4d0f-88e2-b5645be11044"), "Lüle", "Lüle", "Soru: Nargilenin ucuna takılan, tütün konulan tuva", 400, null }
                });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 1,
                column: "DataGuidID",
                value: new Guid("a2cc96d9-1716-4f5b-af4b-0b5bab21356a"));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 2,
                column: "DataGuidID",
                value: new Guid("bbea0ad4-54c2-4243-89c4-e38ae0c17204"));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DataGuidID" },
                values: new object[] { new DateTime(2021, 4, 13, 12, 51, 15, 8, DateTimeKind.Local).AddTicks(5150), new Guid("81c8c8ca-201c-4bc2-aa1f-1396faec4694") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DataGuidID" },
                values: new object[] { new DateTime(2021, 4, 13, 12, 51, 15, 10, DateTimeKind.Local).AddTicks(6935), new Guid("632918e6-5abc-4c5c-8266-07fbd9198767") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 1,
                column: "DataGuidID",
                value: new Guid("7b952c84-fc68-4f72-bc45-cee6324cd862"));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 2,
                column: "DataGuidID",
                value: new Guid("ea1a4bda-a4dc-49ad-9d3d-4f593dce19ff"));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DataGuidID" },
                values: new object[] { new DateTime(2021, 4, 10, 18, 21, 42, 802, DateTimeKind.Local).AddTicks(1286), new Guid("e193b1b7-1cbe-460c-bc4f-06006baa4888") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DataGuidID" },
                values: new object[] { new DateTime(2021, 4, 10, 18, 21, 42, 804, DateTimeKind.Local).AddTicks(1439), new Guid("e14798ca-71b1-432d-8de6-c08414cd7893") });
        }
    }
}
