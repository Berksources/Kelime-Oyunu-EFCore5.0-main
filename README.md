# Kelime-Oyunu-EFCore5.0
Projeyi çalıştırabilmeniz için EntityLayer'da bulunan KelimeOyunuDbContext sınıfı içersindeki OnConfiguring metodundan kendi MSQL veri tabanı adresinizi vermeniz gerekmektedir.
Admin Paneli Giriş Bilgileri, Email: berk.garip@hbksoftware.com Şifre:

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-Q7EGB25; Initial Catalog=KelimeOyunuDB;Integrated Security=True;");
        }
        
       
