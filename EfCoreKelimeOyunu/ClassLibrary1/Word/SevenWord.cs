using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.KelimeOyunu
{
    public class SevenWord:Base
    {
        [Key]
        public int SevenWordID { get; set; }
        [Required]
        public string SevenWordQuestion { get; set; }//Soru
        [Required]
        public string SevenWordAnswer { get; set; }//Cevap
        [Required]
        public string SevenWordData { get; set; }//Veri
        [Required]
        public int SevenWordScore { get; set; }
    }
    public class SevenWordConfiguration : IEntityTypeConfiguration<SevenWord>
    {
        public void Configure(EntityTypeBuilder<SevenWord> builder)
        {
            builder.HasKey(x => x.SevenWordID);
            builder.HasData(new SevenWord
            {
                SevenWordID = 1,
                SevenWordQuestion = "Tatlı ve hamur işi dükkanı",
                SevenWordAnswer = "Pastane",
                SevenWordData = "Pastane",
                SevenWordScore = 700
            });
            builder.HasData(new SevenWord
            {
                SevenWordID = 2,
                SevenWordQuestion = " Argoda, “Gönlü olup olmadığını anlamak için manalı tavırlarda bulunmak, kur yapmak”",
                SevenWordAnswer = "İşatmak",
                SevenWordData = "İşatmak",
                SevenWordScore = 700
            });
            builder.HasData(new SevenWord
            {
                SevenWordID = 3,
                SevenWordQuestion = " Sevinç, korku, sabırsızlık, kızgınlık gibi sebeplerle ortaya çıkan güçlü ve geçici duygu durumu",
                SevenWordAnswer = "Heyecan",
                SevenWordData = "Heyecan",
                SevenWordScore = 700
            });
            builder.HasData(new SevenWord
            {
                SevenWordID = 4,
                SevenWordQuestion = "Üzerinde yakıcı tüyler bulunan bir ot",
                SevenWordAnswer = "Isırgan",
                SevenWordData = "Isırgan",
                SevenWordScore = 700
            });
            builder.HasData(new SevenWord
            {
                SevenWordID = 5,
                SevenWordQuestion = "Avrupa hanedanlarında kadın üyelere verilen genel soyluluk unvanı",
                SevenWordAnswer = "Prenses",
                SevenWordData = "Prenses",
                SevenWordScore = 700
            });
            builder.HasData(new SevenWord
            {
                SevenWordID = 6,
                SevenWordQuestion = "Eskiden “Ortaokul” derecesinde olan eğitim kurumu",
                SevenWordAnswer = "Rüştiye",
                SevenWordData = "Rüştiye",
                SevenWordScore = 700
            });
            builder.HasData(new SevenWord
            {
                SevenWordID = 7,
                SevenWordQuestion = "Zarara ve sıkıntıya karşı alınan önlem",
                SevenWordAnswer = "İhtiras",
                SevenWordData = "İhtiras",
                SevenWordScore = 700
            });
            builder.HasData(new SevenWord
            {
                SevenWordID = 8,
                SevenWordQuestion = "“Erendiz” veya “Müşteri” de denen gezegen",
                SevenWordAnswer = "Jüpiter",
                SevenWordData = "Jüpiter",
                SevenWordScore = 700
            });
            builder.HasData(new SevenWord
            {
                SevenWordID = 9,
                SevenWordQuestion = "Yarı karanlığa denk aydınlık ve bu aydınlığı oluşturan kaynak",
                SevenWordAnswer = "Jüpiter",
                SevenWordData = "Jüpiter",
                SevenWordScore = 700
            });
            builder.HasData(new SevenWord
            {
                SevenWordID = 10,
                SevenWordQuestion = "Japon Çiçek düzenleme sanatı",
                SevenWordAnswer = "İkebana",
                SevenWordData = "İkebana",
                SevenWordScore = 700
            });
            builder.HasData(new SevenWord
            {
                SevenWordID = 11,
                SevenWordQuestion = "Bir adın başka bir ad, zamir veya sıfatla oluşturduğu kelime grubu",
                SevenWordAnswer = "Tamlama",
                SevenWordData = "Tamlama",
                SevenWordScore = 700
            });
            builder.HasData(new SevenWord
            {
                SevenWordID = 12,
                SevenWordQuestion = "“Açıktan açığa, gerçekten” anlamlarında pekiştirilmiş bir sözcük",
                SevenWordAnswer = "Düpedüz",
                SevenWordData = "Düpedüz",
                SevenWordScore = 700
            });
            builder.HasData(new SevenWord
            {
                SevenWordID = 13,
                SevenWordQuestion = "Randevulaştığı kişi tarafından aldatılmak",
                SevenWordAnswer = "Ekilmelik",
                SevenWordData = "Ekilmelik",
                SevenWordScore = 700
            });
            builder.HasData(new SevenWord
            {
                SevenWordID = 14,
                SevenWordQuestion = "“Bir internet servisi veya web sitesi adresinin sözcük olarak ismi” anlamındaki bilişim terimi",
                SevenWordAnswer = "Alanadı",
                SevenWordData = "Alanadı",
                SevenWordScore = 700
            });
            builder.HasData(new SevenWord
            {
                SevenWordID = 15,
                SevenWordQuestion = "Yağ alınmış sütten yapılan peynir, kesmik, çökelek",
                SevenWordAnswer = "Ekşimik",
                SevenWordData = "Ekşimik",
                SevenWordScore = 700
            });
            builder.HasData(new SevenWord
            {
                SevenWordID = 16,
                SevenWordQuestion = "Kötü ve yasa dışı işlerdeki yardımcı",
                SevenWordAnswer = "Yardakçı",
                SevenWordData = "Yardakçı",
                SevenWordScore = 700
            });
            builder.HasData(new SevenWord
            {
                SevenWordID = 17,
                SevenWordQuestion = "“Maş, çalı, horoz” gibi türleri olan bir bitki",
                SevenWordAnswer = "Fasulye",
                SevenWordData = "Fasulye",
                SevenWordScore = 700
            });
            builder.HasData(new SevenWord
            {
                SevenWordID = 18,
                SevenWordQuestion = "“Güçlü, hareketli ve aktif” anlamlarındaki söz",
                SevenWordAnswer = "Enerjik",
                SevenWordData = "Enerjik",
                SevenWordScore = 700
            });
            builder.HasData(new SevenWord
            {
                SevenWordID = 19,
                SevenWordQuestion = "Kuşlar için, “Ezgili ses çıkarmak”",
                SevenWordAnswer = "Şakımak",
                SevenWordData = "Şakımak",
                SevenWordScore = 700
            });
            builder.HasData(new SevenWord
            {
                SevenWordID = 20,
                SevenWordQuestion = "Alt anlamı, “Harcayıp tüketmek” olan söz",
                SevenWordAnswer = "Eritmek",
                SevenWordData = "Eritmek",
                SevenWordScore = 700
            });
        }
    }
}
