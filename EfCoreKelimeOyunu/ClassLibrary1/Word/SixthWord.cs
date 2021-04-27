using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.KelimeOyunu
{
    public class SixthWord : Base
    {
        [Key]
        public int SixthWordID { get; set; }
        [Required]
        public string SixthWordQuestion { get; set; }//Soru
        [Required]
        public string SixthWordAnswer { get; set; }//Cevap
        [Required]
        public string SixthWordData { get; set; }//Veri
        [Required]
        public int SixthWordScore { get; set; }
    }
    public class SixthWordConfiguration : IEntityTypeConfiguration<SixthWord>
    {
        public void Configure(EntityTypeBuilder<SixthWord> builder)
        {
            builder.HasKey(x => x.SixthWordID);

            builder.HasData(new SixthWord
            {
                SixthWordID = 1,
                SixthWordAnswer= "Yakınma veya hafifseme yoluyla şimdiki zaman",
                SixthWordQuestion = "Zamane",
                SixthWordData = "Zamane",
                SixthWordScore = 600
            });
            builder.HasData(new SixthWord
            {
                SixthWordID = 2,
                SixthWordQuestion = "Argoda 'Aldatarak parasını çekmek' ",
                SixthWordAnswer = " Sağmak",
                SixthWordData = "Sağmak",
                SixthWordScore = 600
            });
            builder.HasData(new SixthWord
            {
                SixthWordID = 3,
                SixthWordQuestion = " “Güncel” anlamına gelen Fransızca kökenli sözcük ",
                SixthWordAnswer = "Aktüel",
                SixthWordData = "Aktüel",
                SixthWordScore = 600
            });
            builder.HasData(new SixthWord
            {
                SixthWordID = 4,
                SixthWordQuestion = " “Eklemek, katmak, ilave etmek” anlamında bir söz",
                SixthWordAnswer = "Ulamak",
                SixthWordData = "Ulamak",
                SixthWordScore = 600
            });
            builder.HasData(new SixthWord
            {
                SixthWordID = 5,
                SixthWordQuestion = "Dikiş nakış işlerinde kullanılan parmak korumalığı",
                SixthWordAnswer = "Yüksük",
                SixthWordData = "Yüksük",
                SixthWordScore = 600
            });
            builder.HasData(new SixthWord
            {
                SixthWordID = 6,
                SixthWordQuestion = "“Havlamak” anlamında bir söz",
                SixthWordAnswer = "Ürümek",
                SixthWordData = "Ürümek",
                SixthWordScore = 600
            });
            builder.HasData(new SixthWord
            {
                SixthWordID = 7,
                SixthWordQuestion = "Döndürerek bükmek",
                SixthWordAnswer = "Burmak",
                SixthWordData = "Burmak",
                SixthWordScore = 600
            });
            builder.HasData(new SixthWord
            {
                SixthWordID = 8,
                SixthWordQuestion = "Kolayca, haksız ele geçen kazanç",
                SixthWordAnswer = "Vurgun",
                SixthWordData = "Vurgun",
                SixthWordScore = 600
            });
            builder.HasData(new SixthWord
            {
                SixthWordID = 9,
                SixthWordQuestion = "“Hayali” sözünün Türkçe kökenli karşılıklarından biri",
                SixthWordAnswer = "Düşsel",
                SixthWordData = "Düşsel",
                SixthWordScore = 600
            });
            builder.HasData(new SixthWord
            {
                SixthWordID = 10,
                SixthWordQuestion = "Canlı bir sarı tonunu da adıyla niteleyen, dünyanın en pahalı baharatı",
                SixthWordAnswer = "Safran",
                SixthWordData = "Safran",
                SixthWordScore = 600
            });
            builder.HasData(new SixthWord
            {
                SixthWordID = 11,
                SixthWordQuestion = "Hekimin hastanedeki hastaları dolaşıp yoklaması",
                SixthWordAnswer = "Vizite",
                SixthWordData = "Vizite",
                SixthWordScore = 600
            });
            builder.HasData(new SixthWord
            {
                SixthWordID = 12,
                SixthWordQuestion = "Argoda, “Kaçmak, ortadan kaybolmak”",
                SixthWordAnswer = "Tüymek",
                SixthWordData = "Tüymek",
                SixthWordScore = 600
            });
            builder.HasData(new SixthWord
            {
                SixthWordID = 13,
                SixthWordQuestion = "Su, Buhar, Gaz gibi herhangi bir akışkanın hareket enerjisiyle dönerek çalışan araç",
                SixthWordAnswer = "Türbin",
                SixthWordData = "Türbin",
                SixthWordScore = 600
            });
            builder.HasData(new SixthWord
            {
                SixthWordID = 14,
                SixthWordQuestion = "Kısarak kapamak, sıkarak kapalı duruma getirmek",
                SixthWordAnswer = "Yummak",
                SixthWordData = "Yummak",
                SixthWordScore = 600
            });
            builder.HasData(new SixthWord
            {
                SixthWordID = 15,
                SixthWordQuestion = "Norveç, İskoçya ve Kuzey Amerika kıyılarında buzulların oluşturdukları körfe",
                SixthWordAnswer = "Fiyort",
                SixthWordData = "Fiyort",
                SixthWordScore = 600
            });
            builder.HasData(new SixthWord
            {
                SixthWordID = 16,
                SixthWordQuestion = " “Sınıflama” anlamına gelen Arapça kökenli sözcük",
                SixthWordAnswer = "Tasnif",
                SixthWordData = "Tasnif",
                SixthWordScore = 600
            });
            builder.HasData(new SixthWord
            {
                SixthWordID = 17,
                SixthWordQuestion = "Mecazi anlamda, “Cansız, güçsüz, etkisiz, miskin”",
                SixthWordAnswer = "Ruhsuz",
                SixthWordData = "Ruhsuz",
                SixthWordScore = 600
            });
            builder.HasData(new SixthWord
            {
                SixthWordID = 18,
                SixthWordQuestion = "Kapsüllerinden Afyon elde edilen kültür bitkisi",
                SixthWordAnswer = "Haşhaş",
                SixthWordData = "Haşhaş",
                SixthWordScore = 600
            });
            builder.HasData(new SixthWord
            {
                SixthWordID = 19,
                SixthWordQuestion = " Kutsal sayma, kutsama",
                SixthWordAnswer = "Takdis",
                SixthWordData = "Takdis",
                SixthWordScore = 600
            });
            builder.HasData(new SixthWord
            {
                SixthWordID = 20,
                SixthWordQuestion = "“Kızgın, kaynar, büyük zarar verecek kadar sıcak” anlamlarındaki sıfat",
                SixthWordAnswer = "Haşlak",
                SixthWordData = "Haşlak",
                SixthWordScore = 600
            });
        }
    }
}

