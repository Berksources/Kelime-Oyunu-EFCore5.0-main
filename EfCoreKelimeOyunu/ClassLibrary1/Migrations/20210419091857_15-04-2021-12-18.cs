using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity.KelimeOyunu.Migrations
{
    public partial class _150420211218 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScoreTables_Users_UserID",
                table: "ScoreTables");

            migrationBuilder.DropIndex(
                name: "IX_ScoreTables_UserID",
                table: "ScoreTables");

            migrationBuilder.AlterColumn<int>(
                name: "ScoreTableID",
                table: "ScoreTables",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.InsertData(
                table: "EightWords",
                columns: new[] { "EightWordID", "CreatedDate", "DataGuidID", "EightWordAnswer", "EightWordData", "EightWordQuestion", "EightWordScore", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("18976aeb-4b51-4f50-8129-846267074c6c"), "Sürmenaj", "Sürmenaj", "Sürekli ve aşırı çalışmadan doğan yorgunluk,bitkinlik", 800, null },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8309a96a-3cd2-4a1f-97a5-a98aa0b15137"), " Selamlık", " Selamlık", " Saray, köşk ve konaklarda erkek konukların kabul edildiği yer", 800, null },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("66a8c1af-5ce5-4855-bd26-fadb8004dcb3"), " Terminal", " Terminal", " Otobüs, uçak gibi taşıtların yolcularını ilk aldığı ve son bıraktığı yer", 800, null },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69373a7f-a23c-4d01-97b1-fdfda0d818e2"), " Rahmetli", " Rahmetli", "  “Olmak” fiili ile beraber kullanıldığında “Ölmek” anlamına gelen kelime", 800, null },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("43314017-483f-4acd-8ff3-c9b7c44e53b2"), " Haytalık", " Haytalık", " Bir baltaya sap olmadan, başıboş yaşama hali", 800, null },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7be3359f-5999-46da-866d-ecd5e1891d34"), " Yayçizer", " Yayçizer", " “Pergel”in Türkçe kökenli karşılığı", 800, null },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("57778169-a213-4784-9a9c-1522206cca3a"), " Dengesiz", " Dengesiz", " Muvazenesi bozuk, balansı ayarsız olan", 800, null },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1744e891-6d67-4aac-adc6-3685c4dabceb"), " Mükemmel", " Mükemmel", " Kelime anlamı “Kemale erdirilmiş” olup, “Eksiksiz, kusursuz, şahane” anlamlarında kullanılan bir söz", 800, null },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f05b579b-dd39-45be-825a-a9d50814d646"), " Kırılmak", " Kırılmak", " Savaş, bulaşıcı hastalık gibi sebeplerle “Çok sayıda insan ölmek” anlamında kullanılan söz", 800, null },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("57816825-0089-457a-a709-49c53a73d32b"), " Anestezi", " Anestezi", " “Uyuşturma, duyumsuzlaştırma” anlamındaki Fransızca kökenli söz", 800, null },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a845ea5c-53de-4a07-a4a1-e5db82069b3f"), " Filoloji", " Filoloji", " Dil yoluyla bir toplumun kültürünü inceleyen bilim", 800, null },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("01ce129c-caee-411e-8b07-68f71b8743bf"), " Açıklise", " Açıklise", " Dersleri radyo, televizyon gibi araçlarla yayınlanan veya posta ile ilgililere ulaştırılan ortaöğretim kurumu", 800, null },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3658de61-5d5e-4214-a9ea-39c58b3e29a8"), " İskorpit", " İskorpit", " Adı “Akrep” anlamına gelen Yunanca kökenli bir kelimeden türeyen zehirli bir balık", 800, null },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0524dc33-7079-403a-a350-63b1e3adb4ab"), "Torpilli", "Torpilli", "Mecazen, “Kayıranı olan” anlamında bir söz", 800, null },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e7d62f8d-43f9-4892-915a-38e3d2691b4b"), "Likitfon", "Likitfon", "İstenilen anda nakte dönüştürülebilecek olan yatırım aracı", 800, null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fdb08477-19b7-4437-96f0-c14d74b2d9a5"), "Çıngırak", "Çıngırak", "  İçindeki tanelerin hareketi ile ses çıkaran oyuncak", 800, null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7153ed0f-01f0-4016-9b3b-f8bd4fd849bd"), "Yapımevi", "Yapımevi", " “Film prodüksiyon şirketi”nin Türkçe karşılığı", 800, null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ffe79174-d63d-476f-b744-cf2299eaa08e"), "Alakadar", "Alakadar", "“İlişkili, ilintili, ilgili” anlamlarındaki bir söz", 800, null },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d42732c4-0be7-4ccc-a50b-f306539d6405"), " Berhudar", " Berhudar", " “Mutluluğa erişmiş olan” anlamında bir sözcük", 800, null },
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e141bec6-d79c-4c1d-a8bb-0f2dfa4928af"), "Tercihen", " Tercihen", " “Yeğleyerek, yeğleme yolu ile” anlamında bir söz", 800, null }
                });

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

            migrationBuilder.InsertData(
                table: "NineWords",
                columns: new[] { "NineWordID", "CreatedDate", "DataGuidID", "ModifiedDate", "NineWordAnswer", "NineWordData", "NineWordQuestion", "NineWordScore" },
                values: new object[,]
                {
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3d1c900c-a593-40f6-88b2-0f34d2519b0d"), null, " Pörtlemek", " Pörtlemek", " Özellikle gözler için, “Yuvasından dışarıya doğru fırlamak” anlamında bir söz", 900 },
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("53e41b41-a2ad-4f18-98b3-d92432af3ac0"), null, " Seslenmek", " Seslenmek", "  Uzaktan bağırarak, dikkatini çekmeye çalışmak", 900 },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b663176b-2a82-4333-a4ea-ed620ed9422b"), null, "  Hızvermek", " Hızvermek", " Süratini artırmak", 900 },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ee1f73bd-e544-4fcd-9acc-17f5b22e8d5b"), null, "  Uçaksavar", " Uçaksavar", "  Hava hedeflerine karşı kullanılan silahlara verilen genel ad", 900 },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8a4b08b0-8b8f-4f28-b9f9-01b2b73c0dc6"), null, " Tüysıklet", "  Tüysıklet", " 57 kiloda dövüşen boksör", 900 },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7a05f420-9b47-4410-a2ce-64010d0d7ed6"), null, " Koşubandı", " Koşubandı", " Elektrik yardımıyla dönen bir şerit üzerinde egzersiz yapmaya yarayan araç", 900 },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d13e541c-d09c-4667-bb83-05f499f148d7"), null, "  Düşmanlık", "  Düşmanlık", " Bir insanın öfke ve nefret beslediği kişi veya kişilere yönelttiği kötü duygu ve/veya eylem", 900 },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3e4c777d-6fec-4de7-955a-7720cd502c56"), null, "  Düzeltmek", " Düzeltmek", "  Bozukluğu, yanlışlığı gidermek, tashih etmek", 900 },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d568b110-36f3-4afd-b283-2446c3d70796"), null, "  Uzatmalar", " Uzatmalar", "  Maç süresinin sonuna eklenen, duraklamaların yarattığı kayıp zaman", 900 },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("25ecb5f4-9346-4c84-af1e-514e0d755473"), null, " Karasaban", "  Karasaban", " Pulluğun atası", 900 },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7ae61c7e-d631-4071-8eae-efc636bf37ca"), null, "  Katçıkmak", " Katçıkmak", "  Bir yapının üst kısmına iki döşeme arasında yer alacak şekilde daire veya odalar bütünü eklemek", 900 },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2e6ababd-410e-4a00-865e-a9c17fdf8778"), null, " Resmetmek", " Resmetmek", " Olayların ve varlıkların görünüşlerini, kalem, fırça gibi araçlarla kağıt, bez gibi yüzeyler üzerine geçirmek", 900 },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("21e39332-12db-47f8-a869-12da97360903"), null, " Morartmak", " Morartmak", "  Argoda, “Utanacak duruma düşürmek, bozum etmek”", 900 },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8dc5f1fd-68fd-438d-9e49-ec65cd6ac81a"), null, "  Kabasakal", "  Kabasakal", "  Yanak ve alt çenesinde gür, geniş, özensiz görünümlü bir kıl birikintisi olan kişi", 900 },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0bea8e21-d2e2-4e23-8d94-faf2de6bee16"), null, " Sabitleme", " Sabitleme", " Bir şeyi bir yere hareket etmeyecek biçimde yerleştirme", 900 },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("35862718-9bf7-47fe-b148-bdf344c38df4"), null, " Maksietek", " Maksietek", " Boyu “Bel ile topuk” arasında kalan bir kadın giysisini, boyuyla birlikte tanımlayan söz dizisi", 900 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e2724891-7046-46c6-9008-77cea8433661"), null, " Doğumhane", " Doğumhane", " Gasilhaneye giden yolun başlangıcı olan mekan", 900 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23220a5d-d80f-4156-ae4d-cfe57352c409"), null, " Portbagaj", " Portbagaj", "  Araç üstü yüklüğü", 900 },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cfcc5998-602c-4b2e-9a04-cea062ffbd2b"), null, "  Sırtsırta", "  Sırtsırta", " “Vermek” fiiliyle, “İş birliği yapmak, dayanışma içine girmek” anlamlarında bir söz dizisi", 900 },
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e6cb3ff2-67d2-415a-9da8-1b66fb461cb1"), null, " Ilıştırma", " Ilıştırma", " Sıcak suya soğuk veya soğuğa sıcak su katma", 900 }
                });

            migrationBuilder.InsertData(
                table: "SevenWords",
                columns: new[] { "SevenWordID", "CreatedDate", "DataGuidID", "ModifiedDate", "SevenWordAnswer", "SevenWordData", "SevenWordQuestion", "SevenWordScore" },
                values: new object[,]
                {
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8b7dd737-c364-4ffe-84e8-f28664f032fe"), null, "Eritmek", "Eritmek", "Alt anlamı, “Harcayıp tüketmek” olan söz", 700 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9cc209d2-3867-45d0-925f-8c1a5b14b4b9"), null, "İşatmak", "İşatmak", " Argoda, “Gönlü olup olmadığını anlamak için manalı tavırlarda bulunmak, kur yapmak”", 700 },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c9adfd1d-d619-4b01-8a4a-5b90f571f813"), null, "Şakımak", "Şakımak", "Kuşlar için, “Ezgili ses çıkarmak”", 700 },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d9fd082-2bd8-4df0-8866-a5e1c8597375"), null, "Enerjik", "Enerjik", "“Güçlü, hareketli ve aktif” anlamlarındaki söz", 700 }
                });

            migrationBuilder.InsertData(
                table: "SevenWords",
                columns: new[] { "SevenWordID", "CreatedDate", "DataGuidID", "ModifiedDate", "SevenWordAnswer", "SevenWordData", "SevenWordQuestion", "SevenWordScore" },
                values: new object[,]
                {
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("618afec0-4bd1-400b-81c4-0f05c902e732"), null, "Fasulye", "Fasulye", "“Maş, çalı, horoz” gibi türleri olan bir bitki", 700 },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2132cdc0-cf93-409e-9ece-ffa931c655c5"), null, "Yardakçı", "Yardakçı", "Kötü ve yasa dışı işlerdeki yardımcı", 700 },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("947165e3-b708-42da-850c-0e6c2b326cae"), null, "Ekşimik", "Ekşimik", "Yağ alınmış sütten yapılan peynir, kesmik, çökelek", 700 },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e55b5f4e-f219-4e34-9d48-42d2f6cb8998"), null, "Alanadı", "Alanadı", "“Bir internet servisi veya web sitesi adresinin sözcük olarak ismi” anlamındaki bilişim terimi", 700 },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a7b770f1-364e-47c4-971f-a42721f2cddd"), null, "Ekilmelik", "Ekilmelik", "Randevulaştığı kişi tarafından aldatılmak", 700 },
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c3c7851c-10df-4c3a-8842-936467da7c6a"), null, "Pastane", "Pastane", "Tatlı ve hamur işi dükkanı", 700 },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6ca7b6c5-3b21-4046-9f2d-0af5fc26a892"), null, "Düpedüz", "Düpedüz", "“Açıktan açığa, gerçekten” anlamlarında pekiştirilmiş bir sözcük", 700 },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b950e57e-41a6-4e7b-888f-ee6c88b1f013"), null, "Jüpiter", "Jüpiter", "Yarı karanlığa denk aydınlık ve bu aydınlığı oluşturan kaynak", 700 },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("94bb7743-4466-4bfa-a13c-8226dd9523a8"), null, "Jüpiter", "Jüpiter", "“Erendiz” veya “Müşteri” de denen gezegen", 700 },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("333ad67f-e8d5-442b-aac8-e2d06ec92232"), null, "İhtiras", "İhtiras", "Zarara ve sıkıntıya karşı alınan önlem", 700 },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("871c0946-678c-41ac-aaf4-ad43d0bb63f3"), null, "Rüştiye", "Rüştiye", "Eskiden “Ortaokul” derecesinde olan eğitim kurumu", 700 },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8e9d68f6-9e2d-46fb-842c-e723763f3a2e"), null, "Prenses", "Prenses", "Avrupa hanedanlarında kadın üyelere verilen genel soyluluk unvanı", 700 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("337d914e-26a0-4d1d-99d0-fe2ffbf40aa2"), null, "Isırgan", "Isırgan", "Üzerinde yakıcı tüyler bulunan bir ot", 700 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("95307de3-ac36-419a-a0a5-ba876abfb956"), null, "Heyecan", "Heyecan", " Sevinç, korku, sabırsızlık, kızgınlık gibi sebeplerle ortaya çıkan güçlü ve geçici duygu durumu", 700 },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9da895ce-5eb5-4183-b083-83c9494c4510"), null, "Tamlama", "Tamlama", "Bir adın başka bir ad, zamir veya sıfatla oluşturduğu kelime grubu", 700 },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6a831d05-0327-4723-b47d-883da3f474fe"), null, "İkebana", "İkebana", "Japon Çiçek düzenleme sanatı", 700 }
                });

            migrationBuilder.InsertData(
                table: "SixthWords",
                columns: new[] { "SixthWordID", "CreatedDate", "DataGuidID", "ModifiedDate", "SixthWordAnswer", "SixthWordData", "SixthWordQuestion", "SixthWordScore" },
                values: new object[,]
                {
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7f148dc4-49de-4b82-898b-4c28bbc1242b"), null, "Tüymek", "Tüymek", "Argoda, “Kaçmak, ortadan kaybolmak”", 600 },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("46be8791-197c-49cc-89b7-52c8b9c35c75"), null, "Haşhaş", "Haşhaş", "Kapsüllerinden Afyon elde edilen kültür bitkisi", 600 },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3421cf01-51f2-4de7-a0ca-f1cbe5d5eafd"), null, "Ruhsuz", "Ruhsuz", "Mecazi anlamda, “Cansız, güçsüz, etkisiz, miskin”", 600 },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f8e0a794-950d-4793-b09f-432cc84e19d4"), null, "Tasnif", "Tasnif", " “Sınıflama” anlamına gelen Arapça kökenli sözcük", 600 },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c87a9766-f79d-4128-93ab-22b843b88e53"), null, "Fiyort", "Fiyort", "Norveç, İskoçya ve Kuzey Amerika kıyılarında buzulların oluşturdukları körfe", 600 },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3d680d0f-1d89-4ebd-b836-3d8a06ff2bbf"), null, "Yummak", "Yummak", "Kısarak kapamak, sıkarak kapalı duruma getirmek", 600 },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ac536719-cc58-4843-b529-41c8c605d28d"), null, "Türbin", "Türbin", "Su, Buhar, Gaz gibi herhangi bir akışkanın hareket enerjisiyle dönerek çalışan araç", 600 },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c86affbe-f3b1-40f1-a115-09616fa1c16f"), null, "Vizite", "Vizite", "Hekimin hastanedeki hastaları dolaşıp yoklaması", 600 },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2ff7a680-9fc0-4649-beeb-5662e8b01455"), null, "Safran", "Safran", "Canlı bir sarı tonunu da adıyla niteleyen, dünyanın en pahalı baharatı", 600 },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b00650be-056f-4b72-a712-75ed4dd59b1f"), null, "Takdis", "Takdis", " Kutsal sayma, kutsama", 600 },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1e901d83-f143-482c-9f97-b7134c1f1a99"), null, "Düşsel", "Düşsel", "“Hayali” sözünün Türkçe kökenli karşılıklarından biri", 600 },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("29335a29-acbf-48ed-b9ce-5baa9488cfac"), null, "Burmak", "Burmak", "Döndürerek bükmek", 600 },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("917a081e-9c43-44e4-b279-76972ffdd0dc"), null, "Ürümek", "Ürümek", "“Havlamak” anlamında bir söz", 600 },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2131d574-9789-4848-8616-460e21fe9bb8"), null, "Yüksük", "Yüksük", "Dikiş nakış işlerinde kullanılan parmak korumalığı", 600 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5f653033-7b6c-4ab2-91be-01b3bffa3f61"), null, "Ulamak", "Ulamak", " “Eklemek, katmak, ilave etmek” anlamında bir söz", 600 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("73c90716-18b2-41b8-91b5-82363e70743e"), null, "Aktüel", "Aktüel", " “Güncel” anlamına gelen Fransızca kökenli sözcük ", 600 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6cddc69c-2e05-42dc-bc7c-fab90e0721b3"), null, " Sağmak", "Sağmak", "Argoda 'Aldatarak parasını çekmek' ", 600 },
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7eb1e618-ec8f-40b4-9bed-abaf838abc15"), null, "Yakınma veya hafifseme yoluyla şimdiki zaman", "Zamane", "Zamane", 600 },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6de3fedd-c425-47c5-8d6e-70302b0df8f9"), null, "Vurgun", "Vurgun", "Kolayca, haksız ele geçen kazanç", 600 },
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("774e913f-5966-4154-bd20-183d5e0ad29a"), null, "Haşlak", "Haşlak", "“Kızgın, kaynar, büyük zarar verecek kadar sıcak” anlamlarındaki sıfat", 600 }
                });

            migrationBuilder.InsertData(
                table: "TenWords",
                columns: new[] { "TenWordID", "CreatedDate", "DataGuidID", "ModifiedDate", "TenWordAnswer", "TenWordData", "TenWordQuestion", "TenWordScore" },
                values: new object[,]
                {
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("56d39132-801e-4d5b-a15b-3d046a9ed845"), null, " Loloyapmak", "Loloyapmak", " Bitirim jargonunda, “Üstünlük kurmak çabasıyla yüksek perdeden konuşarak, gösterişli fakat içi boş tavırlarda bulunmak”", 1000 },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5cfc1d22-1a28-483b-bebd-f0b05b4e9172"), null, " Kaskolamak", " Kaskolamak", " Taşıtı uğrayacağı kazadan doğacak zararın karşılanması için sigorta kapsamına almak", 1000 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("02690df5-9cf4-4fad-9cb4-29e6e7c2590a"), null, " Elmaşekeri", " Elmaşekeri", "  İçi meyveli battal lolipop", 1000 },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3526ba00-c8ce-49ab-b2b2-ca552d708c95"), null, " Başaramama", " Başaramama", " “Çuvallama, çarşafa dolanma, sınıfta kalma” deyimlerinin karşılığı olan söz", 1000 },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4ebe836f-bcd8-4085-9a48-34873c3e9ee0"), null, " İşlemhacmi", "  İşlemhacmi", " Borsada günlük gerçekleştirilen alım satımların toplam tutarı", 1000 },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fa4ab26e-c766-44df-ac81-e9be5062cd23"), null, "  İhmaletmek", "  İhmaletmek", " Gereken ilgiyi göstermemek, savsaklamak, boşlamak", 1000 }
                });

            migrationBuilder.InsertData(
                table: "TenWords",
                columns: new[] { "TenWordID", "CreatedDate", "DataGuidID", "ModifiedDate", "TenWordAnswer", "TenWordData", "TenWordQuestion", "TenWordScore" },
                values: new object[,]
                {
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("873ed809-dd57-46be-aee7-cc5257729e98"), null, " Hazırbeton", " Hazırbeton", " Yapı işlerinde kullanılmak üzere “Karmaç” denen araçlarla taşınan bağlayıcı karışım", 1000 },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ae34ee15-b0d3-45e6-933d-6d1971fd400a"), null, " Karşılaşma", " Karşılaşma", "  “Maç” sözcüğünün eş anlamlısı", 1000 },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49ac6df6-e027-43de-bf79-c35324f15fd1"), null, "  Hedefkitle", " Hedefkitle", " Verilmek istenen mesajın ulaşması istenen grup veya topluluk", 1000 },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("90b4132f-7e64-4a2c-8210-fbe04d57acb5"), null, "  Yaşlıbaşlı", " Yaşlıbaşlı", " “Uzun yılları geride bırakmış ve belli bir olgunluğa erişmiş” anlamında bir söz", 1000 },
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cbcfca8f-b4f0-43c2-91b4-dcee05202b3f"), null, " Müteakiben", " Müteakiben", " “Sonra, arkasında, ardı sıra” anlamlarında Arapça kökenli bir söz", 1000 },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6ce738c8-13ae-4f3e-8747-8cfb41f89fde"), null, " Senetsepet", " Senetsepet", " “Borç kağıdı, sözleşme gibi resmi bağlayıcılığı olan belgeler” için kullanılan bir tabir", 1000 },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a0499c77-98ed-45ca-aa08-80d62b832c19"), null, " Mumadönmek", "  Mumadönmek", " “Uslanmak, söz dinler hale gelmek” anlamında bir deyim", 1000 },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a9cb8378-d17e-4465-bd62-56139dfcceed"), null, " Püfnoktası", " Püfnoktası", "  Bir işin en ince, hassas ve önemli kısmı", 1000 },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b2d2fb3d-c4fb-461d-b906-eee14c3e47d8"), null, " Kalpyarası", " Kalpyarası", "  Aşktan, özlemden, başarısızlıktan duyulan büyük keder, aşırı üzüntü, yürek acısı", 1000 },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e74aa11d-3cbd-42f8-b760-18a5b3c0760e"), null, "  Temelatmak", " Temelatmak", "  Bir yapının toprak altında kalan dayanak bölümlerini yapmaya başlamak", 1000 },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1035b086-ad69-43fa-bbf0-ad96e03d3518"), null, "  Kuyukebabı", " Maksietek", " Toprak altında özel olarak kazılıp hazırlanmış çukurda pişirilen, Oğlak ve Kuzu etinden yapılan yemek", 1000 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fa97a588-4cc5-4550-a2df-3c83f8380b94"), null, "  Peydahlama", " Peydahlama", " İstenmeyen, hoş görülmeyen bir şey edinme, oluşturma, meydana getirme", 1000 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b4c0465d-4309-4a67-9e0a-43009237a4e8"), null, " Kankanseri", " Kankanseri", " “Lösemi” de denen rahatsızlık", 1000 },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("31f61ea2-b839-47df-bbdd-cacb1ec39d5b"), null, " Kızılırmak", " Kızılırmak", "  Sırasıyla Sivas, Kayseri, Nevşehir, Aksaray, Kırşehir, Ankara, Kırıkkale, Çankırı, Çorum, Sinop ve Samsun’a hayat veren Akarsu", 1000 }
                });

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

            migrationBuilder.AddForeignKey(
                name: "FK_ScoreTables_Users_ScoreTableID",
                table: "ScoreTables",
                column: "ScoreTableID",
                principalTable: "Users",
                principalColumn: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScoreTables_Users_ScoreTableID",
                table: "ScoreTables");

            migrationBuilder.DeleteData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "EightWords",
                keyColumn: "EightWordID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "NineWords",
                keyColumn: "NineWordID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SevenWords",
                keyColumn: "SevenWordID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SixthWords",
                keyColumn: "SixthWordID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TenWords",
                keyColumn: "TenWordID",
                keyValue: 20);

            migrationBuilder.AlterColumn<int>(
                name: "ScoreTableID",
                table: "ScoreTables",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 1,
                column: "DataGuidID",
                value: new Guid("64170417-ba7b-4eaa-a15a-e931d2df5b2d"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 2,
                column: "DataGuidID",
                value: new Guid("6cb3c83b-9ebb-47e4-9e6d-e967bc9167dc"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 3,
                column: "DataGuidID",
                value: new Guid("aef05ab9-2bc5-4463-947c-04ac0950552f"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 4,
                column: "DataGuidID",
                value: new Guid("ec5a2ee0-b97d-4451-ad6e-f42703c859d9"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 5,
                column: "DataGuidID",
                value: new Guid("1dc87f28-4b35-44da-a79a-0402d8b3fd12"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 6,
                column: "DataGuidID",
                value: new Guid("25c4eaf5-f729-40db-9e87-43035a67d85b"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 7,
                column: "DataGuidID",
                value: new Guid("5c0d0e6b-4d1f-4c9b-8fb0-9282ba91abca"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 8,
                column: "DataGuidID",
                value: new Guid("36a0dbf8-431f-43f5-831f-bde8b299cc0c"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 9,
                column: "DataGuidID",
                value: new Guid("1699098b-75dc-4a77-9961-b02febad0e2f"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 10,
                column: "DataGuidID",
                value: new Guid("c0009eec-9392-457b-87bf-f1da1561c80d"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 11,
                column: "DataGuidID",
                value: new Guid("7951d359-abc8-4b2b-80a9-f8143fccee8d"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 12,
                column: "DataGuidID",
                value: new Guid("b2e387b0-0e9a-4eae-84a5-dee3a1c66f25"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 13,
                column: "DataGuidID",
                value: new Guid("0870dd65-797b-41c2-b49f-2c5e25ae715d"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 14,
                column: "DataGuidID",
                value: new Guid("d89ead6f-1082-42e1-8f15-5656ab47f1ef"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 15,
                column: "DataGuidID",
                value: new Guid("abaaad02-1c3f-4d34-b57b-7e203759e253"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 16,
                column: "DataGuidID",
                value: new Guid("5b411f81-0a73-4166-8b66-40187ac6b34f"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 17,
                column: "DataGuidID",
                value: new Guid("509a91a7-81c9-466f-b888-5e83a685c989"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 18,
                column: "DataGuidID",
                value: new Guid("6500adac-bfb0-4b01-b149-2fbc7167a68d"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 19,
                column: "DataGuidID",
                value: new Guid("9f439739-473e-4a8b-a271-8c1e1ff91e04"));

            migrationBuilder.UpdateData(
                table: "FifthWords",
                keyColumn: "FifthWordID",
                keyValue: 20,
                column: "DataGuidID",
                value: new Guid("65cef124-4c01-4957-97c2-75ea9879b4ee"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 1,
                column: "DataGuidID",
                value: new Guid("1bb784bc-a1d7-468f-91d4-132341408f09"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 2,
                column: "DataGuidID",
                value: new Guid("a49568cd-8c9a-4d7a-97f1-d96581059dd9"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 3,
                column: "DataGuidID",
                value: new Guid("697981f4-ea52-4b4b-bdd0-969cde5ab2ff"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 4,
                column: "DataGuidID",
                value: new Guid("7fa3f96c-4f88-48d4-810c-d47e4ce55308"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 5,
                column: "DataGuidID",
                value: new Guid("6f89cbcd-3838-489d-9ede-fd2c3bd39fe0"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 6,
                column: "DataGuidID",
                value: new Guid("5d8c41b8-3618-4889-a908-c94c2f49b464"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 7,
                column: "DataGuidID",
                value: new Guid("acbc0bb2-17f2-4e44-bf74-9b673ddbb9ca"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 8,
                column: "DataGuidID",
                value: new Guid("8cc4dbdd-e053-4cbb-8112-aae02a18623a"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 9,
                column: "DataGuidID",
                value: new Guid("2a9c6bd0-e023-427d-a0b0-f7b766b82f6a"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 10,
                column: "DataGuidID",
                value: new Guid("a14ef73f-09f0-4da5-b8fd-862573d9e31a"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 11,
                column: "DataGuidID",
                value: new Guid("6578cae5-6766-4a17-9d58-b64207ee3055"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 12,
                column: "DataGuidID",
                value: new Guid("53cdb38d-e1d2-48cb-844d-4e9f4b6d8342"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 13,
                column: "DataGuidID",
                value: new Guid("ce248d44-945e-4d6e-8e0b-02342bfccc2d"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 14,
                column: "DataGuidID",
                value: new Guid("c6672531-69dc-460a-9b6e-1761481aa6f6"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 15,
                column: "DataGuidID",
                value: new Guid("4caa625c-8591-44c2-9fc3-d2241910fe1a"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 16,
                column: "DataGuidID",
                value: new Guid("f6e65c46-afb2-4fce-84f1-cf501f4e6d65"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 17,
                column: "DataGuidID",
                value: new Guid("4ed742fb-4556-4632-9ed1-7a372be034ab"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 18,
                column: "DataGuidID",
                value: new Guid("ad39e94b-54fc-4561-9720-946ddda6bd61"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 19,
                column: "DataGuidID",
                value: new Guid("8cb12158-f9b1-43f6-93f4-295f54b18fd9"));

            migrationBuilder.UpdateData(
                table: "FourWords",
                keyColumn: "FourWordID",
                keyValue: 20,
                column: "DataGuidID",
                value: new Guid("6f2d483a-47f8-4838-8791-e35f798be597"));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 1,
                column: "DataGuidID",
                value: new Guid("dab7c2c4-f5bf-4d96-b330-c2340e615e1c"));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 2,
                column: "DataGuidID",
                value: new Guid("8a38b7c2-4733-4962-80de-232d65c2aa49"));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DataGuidID" },
                values: new object[] { new DateTime(2021, 4, 19, 10, 8, 22, 335, DateTimeKind.Local).AddTicks(78), new Guid("25f2cd6d-baa3-4a55-a6ed-c0905e4b4f7d") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DataGuidID" },
                values: new object[] { new DateTime(2021, 4, 19, 10, 8, 22, 337, DateTimeKind.Local).AddTicks(1328), new Guid("8494396d-3f4e-4103-a320-2459d364a23b") });

            migrationBuilder.CreateIndex(
                name: "IX_ScoreTables_UserID",
                table: "ScoreTables",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_ScoreTables_Users_UserID",
                table: "ScoreTables",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
