using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.KelimeOyunu
{
   public class FifthWord:Base
    {
        [Key]
        public int FifthWordID { get; set; }
        [Required]
        public string FifthWordQuestion { get; set; }//Soru
        [Required]
        public string FifthWordAnswer { get; set; }//Cevap
        [Required]
        public string FifthWordData { get; set; }//Veri
        [Required]
        public int FifthWordScore { get; set; }
    }
    public class FifthWordConfiguration : IEntityTypeConfiguration<FifthWord>
    {
        public void Configure(EntityTypeBuilder<FifthWord> builder)
        {
            builder.HasKey(user => user.FifthWordID);//Primary Key Yapılandırması

            builder.HasData(new FifthWord
            {
                FifthWordID=1,
                FifthWordQuestion= "Bir deneyin edilgen katılımcısı",
                FifthWordAnswer="Kobay",
                FifthWordData="Kobay",
                FifthWordScore=500
            });
            builder.HasData(new FifthWord
            {
                FifthWordID = 2,
                FifthWordQuestion = "Argoda, “Hüznü ruha zerk eden şarkılar” için kullanılan bir söz",
                FifthWordAnswer = "Damar",
                FifthWordData = "Damar",
                FifthWordScore = 500
            });
            builder.HasData(new FifthWord
            {
                FifthWordID = 3,
                FifthWordQuestion = "Eşeysel yaratılış özelliğinde letafet barındıran insan, cinsilatif",
                FifthWordAnswer = "Kadın",
                FifthWordData = "Kadın",
                FifthWordScore = 500
            });
            builder.HasData(new FifthWord
            {
                FifthWordID = 4,
                FifthWordQuestion = "Yürekten gelen, sahiplenen, en sade sevgi sözü",
                FifthWordAnswer = "Canım",
                FifthWordData = "Canım",
                FifthWordScore = 500
            });
            builder.HasData(new FifthWord
            {
                FifthWordID = 5,
                FifthWordQuestion = "Mora çalan pembe, bordo çiçekler açan şifalı bir bitki",
                FifthWordAnswer = "Hatmi",
                FifthWordData = "Hatmi",
                FifthWordScore = 500
            });
            builder.HasData(new FifthWord
            {
                FifthWordID = 6,
                FifthWordQuestion = "“İşlenmemiş verimsiz araziler ve topraklar” için kullanılan bir söz",
                FifthWordAnswer = "Kıraç",
                FifthWordData = "Kıraç",
                FifthWordScore = 500
            });
            builder.HasData(new FifthWord
            {
                FifthWordID = 7,
                FifthWordQuestion = "Sempatik bodur",
                FifthWordAnswer = "Bücür",
                FifthWordData = "Bücür",
                FifthWordScore = 500
            });
            builder.HasData(new FifthWord
            {
                FifthWordID = 8,
                FifthWordQuestion = "Eski mezun toplantılarının vazgeçilmez yemeği",
                FifthWordAnswer = "Pilav",
                FifthWordData = "Pilav",
                FifthWordScore = 500
            });
            builder.HasData(new FifthWord
            {
                FifthWordID = 9,
                FifthWordQuestion = "Üzerinde savaşın sürdüğü bölge",
                FifthWordAnswer = "Cephe",
                FifthWordData = "Cephe",
                FifthWordScore = 500
            });
            builder.HasData(new FifthWord
            {
                FifthWordID = 10,
                FifthWordQuestion = "Özellikle kokuyu azalttığı için soğan salatalarında tercih edilen bir baharat",
                FifthWordAnswer = "Sumak",
                FifthWordData = "Sumak",
                FifthWordScore = 500
            });
            builder.HasData(new FifthWord
            {
                FifthWordID = 11,
                FifthWordQuestion = "Akdeniz’e özgü, Deniz kıyısında bile yetişebilen bir ağaç",
                FifthWordAnswer = "Ilgın",
                FifthWordData = "Ilgın",
                FifthWordScore = 500
            });
            builder.HasData(new FifthWord
            {
                FifthWordID = 12,
                FifthWordQuestion = "Bir desimetreküp hacmindeki ölçü birimi",
                FifthWordAnswer = "Litre",
                FifthWordData = "Litre",
                FifthWordScore = 500
            });
            builder.HasData(new FifthWord
            {
                FifthWordID = 13,
                FifthWordQuestion = "Kasaplık hayvanlardan sağlanan kemiksiz besin maddesi",
                FifthWordAnswer = "Lopet",
                FifthWordData = "Lopet",
                FifthWordScore = 500
            });
            builder.HasData(new FifthWord
            {
                FifthWordID = 14,
                FifthWordQuestion = "“Seyrek” sözünün eş ve yakın anlamlı karşılığı",
                FifthWordAnswer = "Nadir",
                FifthWordData = "Nadir",
                FifthWordScore = 500
            });
            builder.HasData(new FifthWord
            {
                FifthWordID = 15,
                FifthWordQuestion = "80X110 ölçülerindeki çöp poşetinin ebatı” için kullanılan söz",
                FifthWordAnswer = "Jumbo",
                FifthWordData = "Jumbo",
                FifthWordScore = 500
            });
            builder.HasData(new FifthWord
            {
                FifthWordID = 16,
                FifthWordQuestion = "Kauçuk ve jelatin kıvamındaki bir dinamit formuna da adını veren tatlıs",
                FifthWordAnswer = "Lokum",
                FifthWordData = "Lokum",
                FifthWordScore = 500
            });
            builder.HasData(new FifthWord
            {
                FifthWordID = 17,
                FifthWordQuestion = "“Dayak, kötek” anlamlarında bir sözcük",
                FifthWordAnswer = "Patak",
                FifthWordData = "Patak",
                FifthWordScore = 500
            });
            builder.HasData(new FifthWord
            {
                FifthWordID = 18,
                FifthWordQuestion = "Sayıları göstermek için kullanılan işaretlerden her biri",
                FifthWordAnswer = "Rakam",
                FifthWordData = "Rakam",
                FifthWordScore = 500
            });
            builder.HasData(new FifthWord
            {
                FifthWordID = 19,
                FifthWordQuestion = "Tatlı düş",
                FifthWordAnswer = "Hülya",
                FifthWordData = "Hülya",
                FifthWordScore = 500
            });
            builder.HasData(new FifthWord
            {
                FifthWordID = 20,
                FifthWordQuestion = "Dil dudak yoluyla çıkarılan tiz ses",
                FifthWordAnswer = "Islık",
                FifthWordData = "Islık",
                FifthWordScore = 500
            });
        }
    }
}
