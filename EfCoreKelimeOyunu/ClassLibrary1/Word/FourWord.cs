using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.KelimeOyunu
{
   public class FourWord:Base
    {
        [Key]
        public int FourWordID { get; set; }
        [Required]
        public string FourWordQuestion { get; set; }//Soru
        [Required]
        public string FourWordAnswer { get; set; }//Cevap
        [Required]
        public string FourWordData { get; set; }//Veri
        [Required]
        public int FourWordScore { get; set; }
    }
    public class FourWordConfiguration : IEntityTypeConfiguration<FourWord>
    {
        public void Configure(EntityTypeBuilder<FourWord> builder)
        {
            builder.HasKey(user => user.FourWordID);//Primary Key Yapılandırması

            builder.HasData(new FourWord
            {
                FourWordID=1,
                FourWordQuestion="Umar sözünün daha yaygın kullanılan Farsça kökenli eş anlamlısı ",
                FourWordAnswer="Çare",
                FourWordData="Çare",
                FourWordScore=400
            });

            builder.HasData(new FourWord
            {
                FourWordID = 2,
                FourWordQuestion = "Etrafı helis eğrisi biçiminde girintiler ve çıkıntılarla dolanmış çivi ",
                FourWordAnswer = "Vida",
                FourWordData = "Vida",
                FourWordScore = 400
            });
            builder.HasData(new FourWord
            {
                FourWordID = 3,
                FourWordQuestion = "Mecazen , 'Gönül ve cesaret kırıcı,huysuz,sert' ",
                FourWordAnswer = "Ters",
                FourWordData = "Ters",
                FourWordScore = 400
            });
            builder.HasData(new FourWord
            {
                FourWordID = 4,
                FourWordQuestion = "Neden olduğu rahatsız edici kaşıntı nedeniyle “Sevimsiz insanlara” da yakıştırılan bir deri hastalığı",
                FourWordAnswer = "Uyuz",
                FourWordData = "Uyuz",
                FourWordScore = 400
            });
            builder.HasData(new FourWord
            {
                FourWordID = 5,
                FourWordQuestion = "Yüksekliği 0-500 M. arasında değişen, doğal coğrafi oluşum",
                FourWordAnswer = "Tepe",
                FourWordData = "Tepe",
                FourWordScore = 400
            });
            builder.HasData(new FourWord
            {
                FourWordID = 6,
                FourWordQuestion = "“Şuh” sözcüğünün Batı kökenli eş ve yakın anlamlı karşılığı",
                FourWordAnswer = "Vamp",
                FourWordData = "Vamp",
                FourWordScore = 400
            });
            builder.HasData(new FourWord
            {
                FourWordID = 7,
                FourWordQuestion = "Türkiye’nin Doğu Anadolu Bölgesi’nde doğup Hazar Denizi’ne dökülen Nehir",
                FourWordAnswer = "Aras",
                FourWordData = "Aras",
                FourWordScore = 400
            });
            builder.HasData(new FourWord
            {
                FourWordID = 8,
                FourWordQuestion = "Modern miğfer",
                FourWordAnswer = "Kask",
                FourWordData = "Kask",
                FourWordScore = 400
            });
            builder.HasData(new FourWord
            {
                FourWordID = 9,
                FourWordQuestion = "Etrafı iplikle örülen düğme yarığı",
                FourWordAnswer = "İlik",
                FourWordData = "İlik",
                FourWordScore = 400
            });
            builder.HasData(new FourWord
            {
                FourWordID = 10,
                FourWordQuestion = "Soru: Nargilenin ucuna takılan, tütün konulan tuva",
                FourWordAnswer = "Lüle",
                FourWordData = "Lüle",
                FourWordScore = 400
            });
            builder.HasData(new FourWord
            {
                FourWordID = 11,
                FourWordQuestion = "Nokturnal canlıların aktif olduğu zaman dilimi",
                FourWordAnswer = "Gece",
                FourWordData = "Gece",
                FourWordScore = 400
            });
            builder.HasData(new FourWord
            {
                FourWordID = 12,
                FourWordQuestion = "Soru: Aylıkçı nimeti",
                FourWordAnswer = "Maaş",
                FourWordData = "Maaş",
                FourWordScore = 400
            });
            builder.HasData(new FourWord
            {
                FourWordID = 13,
                FourWordQuestion = "Çarşı pazar ekonomisinin simgelerinden olan ve artık yeniden popülerleşen ağ torba",
                FourWordAnswer = "File",
                FourWordData = "File",
                FourWordScore = 400
            });
            builder.HasData(new FourWord
            {
                FourWordID = 14,
                FourWordQuestion = "Genç olanlarına “Düve” denen hayvan",
                FourWordAnswer = "İnek",
                FourWordData = "İnek",
                FourWordScore = 400
            });
            builder.HasData(new FourWord
            {
                FourWordID = 15,
                FourWordQuestion = "Dik veya paralel olmayan doğru",
                FourWordAnswer = "Eğik",
                FourWordData = "Eğik",
                FourWordScore = 400
            });
            builder.HasData(new FourWord
            {
                FourWordID = 16,
                FourWordQuestion = "Emir komuta zinciri ile bağlı olan taşıtlar topluluğu",
                FourWordAnswer = "Filo",
                FourWordData = "Filo",
                FourWordScore = 400
            });
            builder.HasData(new FourWord
            {
                FourWordID = 17,
                FourWordQuestion = "“Hoşa gitmeyen, olumsuz yönde dikkat çeken renkleri” niteleyen bir söz",
                FourWordAnswer = "Cart",
                FourWordData = "Cart",
                FourWordScore = 400
            });
            builder.HasData(new FourWord
            {
                FourWordID = 18,
                FourWordQuestion = "İnce bir teli üç kez iç içe bükerek elde edilen bir kırtasiye gereci",
                FourWordAnswer = "Ataş",
                FourWordData = "Ataş",
                FourWordScore = 400
            });
            builder.HasData(new FourWord
            {
                FourWordID = 19,
                FourWordQuestion = "Bir erkek adı olarak da kullanılan, “Edebi eser veren kimse, yazar” anlamındaki isim",
                FourWordAnswer = "Edip",
                FourWordData = "Edip",
                FourWordScore = 400
            });
            builder.HasData(new FourWord
            {
                FourWordID = 20,
                FourWordQuestion = "İşi ve inancı gereği öğüt veren kişi",
                FourWordAnswer = "Vaiz",
                FourWordData = "Vaiz",
                FourWordScore = 400
            });
        }
    }
}
