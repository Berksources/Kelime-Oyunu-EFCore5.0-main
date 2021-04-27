using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.KelimeOyunu
{
    public class TenWord:Base
    {
        [Key]
        public int TenWordID { get; set; }
        [Required]
        public string TenWordQuestion { get; set; }//Soru
        [Required]
        public string TenWordAnswer { get; set; }//Cevap
        [Required]
        public string TenWordData { get; set; }//Veri
        [Required]
        public int TenWordScore { get; set; }
    }
    public class TenWordConfiguration : IEntityTypeConfiguration<TenWord>
    {
        public void Configure(EntityTypeBuilder<TenWord> builder)
        {
            builder.HasKey(x => x.TenWordID);

            builder.HasData(new TenWord
            {
                TenWordID = 1,
                TenWordQuestion = " “Sonra, arkasında, ardı sıra” anlamlarında Arapça kökenli bir söz",
                TenWordAnswer = "Müteakiben",
                TenWordData = "Müteakiben",
                TenWordScore = 1000
            });
            builder.HasData(new TenWord
            {
                TenWordID = 2,
                TenWordQuestion = "  İçi meyveli battal lolipop",
                TenWordAnswer = "Elmaşekeri",
                TenWordData = "Elmaşekeri",
                TenWordScore = 1000
            });
            builder.HasData(new TenWord
            {
                TenWordID = 3,
                TenWordQuestion = " “Lösemi” de denen rahatsızlık",
                TenWordAnswer = "Kankanseri",
                TenWordData = "Kankanseri",
                TenWordScore = 1000
            });
            builder.HasData(new TenWord
            {
                TenWordID = 4,
                TenWordQuestion = " İstenmeyen, hoş görülmeyen bir şey edinme, oluşturma, meydana getirme",
                TenWordAnswer = "Peydahlama",
                TenWordData = "Peydahlama",
                TenWordScore = 1000
            });
            builder.HasData(new TenWord
            {
                TenWordID = 5,
                TenWordQuestion = " Toprak altında özel olarak kazılıp hazırlanmış çukurda pişirilen, Oğlak ve Kuzu etinden yapılan yemek",
                TenWordAnswer = "Kuyukebabı",
                TenWordData = "Maksietek",
                TenWordScore = 1000
            });
            builder.HasData(new TenWord
            {
                TenWordID = 6,
                TenWordQuestion = "  Bir yapının toprak altında kalan dayanak bölümlerini yapmaya başlamak",
                TenWordAnswer = "Temelatmak",
                TenWordData = "Temelatmak",
                TenWordScore = 1000
            });
            builder.HasData(new TenWord
            {
                TenWordID = 7,
                TenWordQuestion = "  Aşktan, özlemden, başarısızlıktan duyulan büyük keder, aşırı üzüntü, yürek acısı",
                TenWordAnswer = "Kalpyarası",
                TenWordData = "Kalpyarası",
                TenWordScore = 1000
            });
            builder.HasData(new TenWord
            {
                TenWordID = 8,
                TenWordQuestion = "Bir işin en ince, hassas ve önemli kısmı",
                TenWordAnswer = "Püfnoktası",
                TenWordData = "Püfnoktası",
                TenWordScore = 1000
            });
            builder.HasData(new TenWord
            {
                TenWordID = 9,
                TenWordQuestion = " “Uslanmak, söz dinler hale gelmek” anlamında bir deyim",
                TenWordAnswer = "Mumadönmek",
                TenWordData = "Mumadönmek",
                TenWordScore = 1000
            });
            builder.HasData(new TenWord
            {
                TenWordID = 10,
                TenWordQuestion = "  Sırasıyla Sivas, Kayseri, Nevşehir, Aksaray, Kırşehir, Ankara, Kırıkkale, Çankırı, Çorum, Sinop ve Samsun’a hayat veren Akarsu",
                TenWordAnswer = "Kızılırmak",
                TenWordData = "Kızılırmak",
                TenWordScore = 1000
            });
            builder.HasData(new TenWord
            {
                TenWordID = 11,
                TenWordQuestion = " “Borç kağıdı, sözleşme gibi resmi bağlayıcılığı olan belgeler” için kullanılan bir tabir",
                TenWordAnswer = "Senetsepet",
                TenWordData = "Senetsepet",
                TenWordScore = 1000
            });
            builder.HasData(new TenWord
            {
                TenWordID = 12,
                TenWordQuestion = " “Uzun yılları geride bırakmış ve belli bir olgunluğa erişmiş” anlamında bir söz",
                TenWordAnswer = "Yaşlıbaşlı",
                TenWordData = "Yaşlıbaşlı",
                TenWordScore = 1000
            });
            builder.HasData(new TenWord
            {
                TenWordID = 13,
                TenWordQuestion = " Verilmek istenen mesajın ulaşması istenen grup veya topluluk",
                TenWordAnswer = "Hedefkitle",
                TenWordData = "Hedefkitle",
                TenWordScore = 1000
            });
            builder.HasData(new TenWord
            {
                TenWordID = 14,
                TenWordQuestion = "  “Maç” sözcüğünün eş anlamlısı",
                TenWordAnswer = "Karşılaşma",
                TenWordData = "Karşılaşma",
                TenWordScore = 1000
            });
            builder.HasData(new TenWord
            {
                TenWordID = 15,
                TenWordQuestion = " Yapı işlerinde kullanılmak üzere “Karmaç” denen araçlarla taşınan bağlayıcı karışım",
                TenWordAnswer = "Hazırbeton",
                TenWordData = "Hazırbeton",
                TenWordScore = 1000
            });
            builder.HasData(new TenWord
            {
                TenWordID = 16,
                TenWordQuestion = " Gereken ilgiyi göstermemek, savsaklamak, boşlamak",
                TenWordAnswer = "İhmaletmek",
                TenWordData = "İhmaletmek",
                TenWordScore = 1000
            });
            builder.HasData(new TenWord
            {
                TenWordID = 17,
                TenWordQuestion = " Borsada günlük gerçekleştirilen alım satımların toplam tutarı",
                TenWordAnswer = "İşlemhacmi",
                TenWordData = "İşlemhacmi",
                TenWordScore = 1000
            });
            builder.HasData(new TenWord
            {
                TenWordID = 18,
                TenWordQuestion = " “Çuvallama, çarşafa dolanma, sınıfta kalma” deyimlerinin karşılığı olan söz",
                TenWordAnswer = "Başaramama",
                TenWordData = "Başaramama",
                TenWordScore = 1000
            });
            builder.HasData(new TenWord
            {
                TenWordID = 19,
                TenWordQuestion = " Taşıtı uğrayacağı kazadan doğacak zararın karşılanması için sigorta kapsamına almak",
                TenWordAnswer = "Kaskolamak",
                TenWordData = "Kaskolamak",
                TenWordScore = 1000
            });
            builder.HasData(new TenWord
            {
                TenWordID = 20,
                TenWordQuestion = " Bitirim jargonunda, “Üstünlük kurmak çabasıyla yüksek perdeden konuşarak, gösterişli fakat içi boş tavırlarda bulunmak”",
                TenWordAnswer = "Loloyapmak",
                TenWordData = "Loloyapmak",
                TenWordScore = 1000
            });
        }
    }
}
