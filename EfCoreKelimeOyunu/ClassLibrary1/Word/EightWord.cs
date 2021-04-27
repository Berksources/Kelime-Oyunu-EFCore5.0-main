using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.KelimeOyunu
{
    public class EightWord : Base
    {
        [Key]
        public int EightWordID { get; set; }
        [Required]
        public string EightWordQuestion { get; set; }//Soru
        [Required]
        public string EightWordAnswer { get; set; }//Cevap
        [Required]
        public string EightWordData { get; set; }//Veri
        [Required]
        public int EightWordScore { get; set; }
    }
    public class EightWordConfiguration : IEntityTypeConfiguration<EightWord>
    {
        public void Configure(EntityTypeBuilder<EightWord> builder)
        {
            builder.HasKey(x => x.EightWordID);

            builder.HasData(new EightWord
            {
                EightWordID = 1,
                EightWordQuestion = "Sürekli ve aşırı çalışmadan doğan yorgunluk,bitkinlik",
                EightWordAnswer = "Sürmenaj",
                EightWordData = "Sürmenaj",
                EightWordScore = 800
            });
            builder.HasData(new EightWord
            {
                EightWordID = 2,
                EightWordQuestion = "“İlişkili, ilintili, ilgili” anlamlarındaki bir söz",
                EightWordAnswer = "Alakadar",
                EightWordData = "Alakadar",
                EightWordScore = 800
            });
            builder.HasData(new EightWord
            {
                EightWordID = 3,
                EightWordQuestion = " “Film prodüksiyon şirketi”nin Türkçe karşılığı",
                EightWordAnswer = "Yapımevi",
                EightWordData = "Yapımevi",
                EightWordScore = 800
            });
            builder.HasData(new EightWord
            {
                EightWordID = 4,
                EightWordQuestion = "  İçindeki tanelerin hareketi ile ses çıkaran oyuncak",
                EightWordAnswer = "Çıngırak",
                EightWordData = "Çıngırak",
                EightWordScore = 800
            });
            builder.HasData(new EightWord
            {
                EightWordID = 5,
                EightWordQuestion = "İstenilen anda nakte dönüştürülebilecek olan yatırım aracı",
                EightWordAnswer = "Likitfon",
                EightWordData = "Likitfon",
                EightWordScore = 800
            });
            builder.HasData(new EightWord
            {
                EightWordID = 6,
                EightWordQuestion = "Mecazen, “Kayıranı olan” anlamında bir söz",
                EightWordAnswer = "Torpilli",
                EightWordData = "Torpilli",
                EightWordScore = 800
            });
            builder.HasData(new EightWord
            {
                EightWordID = 7,
                EightWordQuestion = " Adı “Akrep” anlamına gelen Yunanca kökenli bir kelimeden türeyen zehirli bir balık",
                EightWordAnswer = "İskorpit",
                EightWordData = "İskorpit",
                EightWordScore = 800
            });
            builder.HasData(new EightWord
            {
                EightWordID = 8,
                EightWordQuestion = " Dersleri radyo, televizyon gibi araçlarla yayınlanan veya posta ile ilgililere ulaştırılan ortaöğretim kurumu",
                EightWordAnswer = " Açıklise",
                EightWordData = " Açıklise",
                EightWordScore = 800
            });
            builder.HasData(new EightWord
            {
                EightWordID = 9,
                EightWordQuestion = " Dil yoluyla bir toplumun kültürünü inceleyen bilim",
                EightWordAnswer = "Filoloji",
                EightWordData = "Filoloji",
                EightWordScore = 800
            });
            builder.HasData(new EightWord
            {
                EightWordID = 10,
                EightWordQuestion = " “Uyuşturma, duyumsuzlaştırma” anlamındaki Fransızca kökenli söz",
                EightWordAnswer = "Anestezi",
                EightWordData = "Anestezi",
                EightWordScore = 800
            });
            builder.HasData(new EightWord
            {
                EightWordID = 11,
                EightWordQuestion = " Savaş, bulaşıcı hastalık gibi sebeplerle “Çok sayıda insan ölmek” anlamında kullanılan söz",
                EightWordAnswer = "Kırılmak",
                EightWordData = "Kırılmak",
                EightWordScore = 800
            });
            builder.HasData(new EightWord
            {
                EightWordID = 12,
                EightWordQuestion = " Kelime anlamı “Kemale erdirilmiş” olup, “Eksiksiz, kusursuz, şahane” anlamlarında kullanılan bir söz",
                EightWordAnswer = "Mükemmel",
                EightWordData = "Mükemmel",
                EightWordScore = 800
            });
            builder.HasData(new EightWord
            {
                EightWordID = 13,
                EightWordQuestion = " Muvazenesi bozuk, balansı ayarsız olan",
                EightWordAnswer = "Dengesiz",
                EightWordData = "Dengesiz",
                EightWordScore = 800
            });
            builder.HasData(new EightWord
            {
                EightWordID = 14,
                EightWordQuestion = " “Pergel”in Türkçe kökenli karşılığı",
                EightWordAnswer = "Yayçizer",
                EightWordData = "Yayçizer",
                EightWordScore = 800
            });
            builder.HasData(new EightWord
            {
                EightWordID = 15,
                EightWordQuestion = " Bir baltaya sap olmadan, başıboş yaşama hali",
                EightWordAnswer = "Haytalık",
                EightWordData = "Haytalık",
                EightWordScore = 800
            });
            builder.HasData(new EightWord
            {
                EightWordID = 16,
                EightWordQuestion = "  “Olmak” fiili ile beraber kullanıldığında “Ölmek” anlamına gelen kelime",
                EightWordAnswer = "Rahmetli",
                EightWordData = "Rahmetli",
                EightWordScore = 800
            });
            builder.HasData(new EightWord
            {
                EightWordID = 17,
                EightWordQuestion = " Otobüs, uçak gibi taşıtların yolcularını ilk aldığı ve son bıraktığı yer",
                EightWordAnswer = "Terminal",
                EightWordData = "Terminal",
                EightWordScore = 800
            });
            builder.HasData(new EightWord
            {
                EightWordID = 18,
                EightWordQuestion = " Saray, köşk ve konaklarda erkek konukların kabul edildiği yer",
                EightWordAnswer = "Selamlık",
                EightWordData = "Selamlık",
                EightWordScore = 800
            });
            builder.HasData(new EightWord
            {
                EightWordID = 19,
                EightWordQuestion = " “Mutluluğa erişmiş olan” anlamında bir sözcük",
                EightWordAnswer = "Berhudar",
                EightWordData = "Berhudar",
                EightWordScore = 800
            });
            builder.HasData(new EightWord
            {
                EightWordID = 20,
                EightWordQuestion = " “Yeğleyerek, yeğleme yolu ile” anlamında bir söz",
                EightWordAnswer = "Tercihen",
                EightWordData = "Tercihen",
                EightWordScore = 800
            });
        }
    }
}
