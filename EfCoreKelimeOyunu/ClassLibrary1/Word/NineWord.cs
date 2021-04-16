using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.KelimeOyunu
{
   public class NineWord:Base
    {
        [Key]
        public int NineWordID { get; set; }
        [Required]
        public string NineWordQuestion { get; set; }//Soru
        [Required]
        public string NineWordAnswer { get; set; }//Cevap
        [Required]
        public string NineWordData { get; set; }//Veri
        [Required]
        public int NineWordScore { get; set; }
    }
    public class NineWordConfiguration : IEntityTypeConfiguration<NineWord>
    {
      
public void Configure(EntityTypeBuilder<NineWord> builder)
{
    builder.HasKey(x => x.NineWordID);

    builder.HasData(new NineWord
    {
        NineWordID = 1,
        NineWordQuestion = " Sıcak suya soğuk veya soğuğa sıcak su katma",
        NineWordAnswer = " Ilıştırma",
        NineWordData = " Ilıştırma",
        NineWordScore = 900
    });
    builder.HasData(new NineWord
    {
        NineWordID = 2,
        NineWordQuestion = " Özellikle gözler için, “Yuvasından dışarıya doğru fırlamak” anlamında bir söz",
        NineWordAnswer = " Pörtlemek",
        NineWordData = " Pörtlemek",
        NineWordScore = 900
    });
    builder.HasData(new NineWord
    {
        NineWordID = 3,
        NineWordQuestion = "  Araç üstü yüklüğü",
        NineWordAnswer = " Portbagaj",
        NineWordData = " Portbagaj",
        NineWordScore = 900
    });
    builder.HasData(new NineWord
    {
        NineWordID = 4,
        NineWordQuestion = " Gasilhaneye giden yolun başlangıcı olan mekan",
        NineWordAnswer = " Doğumhane",
        NineWordData = " Doğumhane",
        NineWordScore = 900
    });
    builder.HasData(new NineWord
    {
        NineWordID = 5,
        NineWordQuestion = " Boyu “Bel ile topuk” arasında kalan bir kadın giysisini, boyuyla birlikte tanımlayan söz dizisi",
        NineWordAnswer = " Maksietek",
        NineWordData = " Maksietek",
        NineWordScore = 900
    });
    builder.HasData(new NineWord
    {
        NineWordID = 6,
        NineWordQuestion = " Bir şeyi bir yere hareket etmeyecek biçimde yerleştirme",
        NineWordAnswer = " Sabitleme",
        NineWordData = " Sabitleme",
        NineWordScore = 900
    });
    builder.HasData(new NineWord
    {
        NineWordID = 7,
        NineWordQuestion = "  Yanak ve alt çenesinde gür, geniş, özensiz görünümlü bir kıl birikintisi olan kişi",
        NineWordAnswer = "  Kabasakal",
        NineWordData = "  Kabasakal",
        NineWordScore = 900
    });
    builder.HasData(new NineWord
    {
        NineWordID = 8,
        NineWordQuestion = "  Argoda, “Utanacak duruma düşürmek, bozum etmek”",
        NineWordAnswer = " Morartmak",
        NineWordData = " Morartmak",
        NineWordScore = 900
    });
    builder.HasData(new NineWord
    {
        NineWordID = 9,
        NineWordQuestion = " Olayların ve varlıkların görünüşlerini, kalem, fırça gibi araçlarla kağıt, bez gibi yüzeyler üzerine geçirmek",
        NineWordAnswer = " Resmetmek",
        NineWordData = " Resmetmek",
        NineWordScore = 900
    });
    builder.HasData(new NineWord
    {
        NineWordID = 10,
        NineWordQuestion = " “Vermek” fiiliyle, “İş birliği yapmak, dayanışma içine girmek” anlamlarında bir söz dizisi",
        NineWordAnswer = "  Sırtsırta",
        NineWordData = "  Sırtsırta",
        NineWordScore = 900
    });
    builder.HasData(new NineWord
    {
        NineWordID = 11,
        NineWordQuestion = "  Bir yapının üst kısmına iki döşeme arasında yer alacak şekilde daire veya odalar bütünü eklemek",
        NineWordAnswer = "  Katçıkmak",
        NineWordData = " Katçıkmak",
        NineWordScore = 900
    });
    builder.HasData(new NineWord
    {
        NineWordID = 12,
        NineWordQuestion = "  Maç süresinin sonuna eklenen, duraklamaların yarattığı kayıp zaman",
        NineWordAnswer = "  Uzatmalar",
        NineWordData = " Uzatmalar",
        NineWordScore = 900
    });
    builder.HasData(new NineWord
    {
        NineWordID = 13,
        NineWordQuestion = "  Bozukluğu, yanlışlığı gidermek, tashih etmek",
        NineWordAnswer = "  Düzeltmek",
        NineWordData = " Düzeltmek",
        NineWordScore = 900
    });
    builder.HasData(new NineWord
    {
        NineWordID = 14,
        NineWordQuestion = " Bir insanın öfke ve nefret beslediği kişi veya kişilere yönelttiği kötü duygu ve/veya eylem",
        NineWordAnswer = "  Düşmanlık",
        NineWordData = "  Düşmanlık",
        NineWordScore = 900
    });
    builder.HasData(new NineWord
    {
        NineWordID = 15,
        NineWordQuestion = " Elektrik yardımıyla dönen bir şerit üzerinde egzersiz yapmaya yarayan araç",
        NineWordAnswer = " Koşubandı",
        NineWordData = " Koşubandı",
        NineWordScore = 900
    });
    builder.HasData(new NineWord
    {
        NineWordID = 16,
        NineWordQuestion = " 57 kiloda dövüşen boksör",
        NineWordAnswer = " Tüysıklet",
        NineWordData = "  Tüysıklet",
        NineWordScore = 900
    });
    builder.HasData(new NineWord
    {
        NineWordID = 17,
        NineWordQuestion = "  Hava hedeflerine karşı kullanılan silahlara verilen genel ad",
        NineWordAnswer = "  Uçaksavar",
        NineWordData = " Uçaksavar",
        NineWordScore = 900
    });
    builder.HasData(new NineWord
    {
        NineWordID = 18,
        NineWordQuestion = " Süratini artırmak",
        NineWordAnswer = "  Hızvermek",
        NineWordData = " Hızvermek",
        NineWordScore = 900
    });
    builder.HasData(new NineWord
    {
        NineWordID = 19,
        NineWordQuestion = " Pulluğun atası",
        NineWordAnswer = " Karasaban",
        NineWordData = "  Karasaban",
        NineWordScore = 900
    });
    builder.HasData(new NineWord
    {
        NineWordID = 20,
        NineWordQuestion = "  Uzaktan bağırarak, dikkatini çekmeye çalışmak",
        NineWordAnswer = " Seslenmek",
        NineWordData = " Seslenmek",
        NineWordScore = 900
    });
}
    }
}
