# Kelime-Oyunu-EFCore5.0
Projeyi çalıştırabilmeniz için EntityLayer'da bulunan KelimeOyunuDbContext sınıfı içersindeki OnConfiguring metodundan kendi MSQL veri tabanı adresinizi vermeniz gerekmektedir.

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=Örnek:DESKTOP-Q7EGB25; Initial Catalog=KelimeOyunuDB;Integrated Security=True;");
        }
        
       
Admin Paneli Giriş Bilgileri, Email: AdminPaneli@gmail.com Şifre: AdminGitHub
Oyuncu Giriş Bilgileri, Email: Kullanici@gmail.com Şifre: KullaniciGitHub
