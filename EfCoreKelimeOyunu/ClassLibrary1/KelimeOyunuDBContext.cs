using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.KelimeOyunu
{
    public class KelimeOyunuDBContext:DbContext
    {
        public KelimeOyunuDBContext(DbContextOptions<KelimeOyunuDBContext> options) : base(options) { }
        public KelimeOyunuDBContext(){}

        ///>Kullanıcı Yönetimi
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        ///Kullanıcı Yönetimi

        ///Kelimeler
        public DbSet<FourWord> FourWords { get; set; }
        public DbSet<FifthWord> FifthWords { get; set; }
        public DbSet<SixthWord> SixthWords { get; set; }
        public DbSet<SevenWord> SevenWords { get; set; }
        public DbSet<EightWord> EightWords { get; set; }
        public DbSet<NineWord> NineWords { get; set; }
        public DbSet<TenWord> TenWords { get; set; }
        public DbSet<ScoreTable> ScoreTables { get; set; }
        ///Kelimeler
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-4OHI60J; Initial Catalog=KelimeOyunuDB;Integrated Security=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new FourWordConfiguration());
            modelBuilder.ApplyConfiguration(new FifthWordConfiguration());
        }
    }
}
