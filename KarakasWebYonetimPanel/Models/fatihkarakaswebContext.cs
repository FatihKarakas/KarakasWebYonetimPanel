using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KarakasWebYonetimPanel.Models
{
    public partial class fatihkarakaswebContext : DbContext
    {
        public fatihkarakaswebContext()
        {
        }

        public fatihkarakaswebContext(DbContextOptions<fatihkarakaswebContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Anket> Anket { get; set; }
        public virtual DbSet<Bist100> Bist100 { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Hakkimda> Hakkimda { get; set; }
        public virtual DbSet<HastaneBilgi> HastaneBilgi { get; set; }
        public virtual DbSet<LocalString> LocalString { get; set; }
        public virtual DbSet<Mesajlar> Mesajlar { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<PostTag> PostTag { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<Referanslar> Referanslar { get; set; }
        public virtual DbSet<Setting> Setting { get; set; }
        public virtual DbSet<SystemError> SystemError { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<UrlRecord> UrlRecord { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=94.138.197.30;Database=fatihkarakasweb;User ID=fatihkarakas;Password=Dt372054!!;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Anket>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.GuncelemeZaman)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Hastane).IsRequired();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IpAdres)
                    .HasColumnName("Ip_Adres")
                    .HasMaxLength(50);

                entity.Property(e => e.S10).HasColumnName("s10");

                entity.Property(e => e.S11).HasColumnName("s11");

                entity.Property(e => e.S12).HasColumnName("s12");

                entity.Property(e => e.S13).HasColumnName("s13");

                entity.Property(e => e.S14).HasColumnName("s14");

                entity.Property(e => e.S15).HasColumnName("s15");

                entity.Property(e => e.S16).HasColumnName("s16");

                entity.Property(e => e.S17).HasColumnName("s17");

                entity.Property(e => e.S18).HasColumnName("s18");

                entity.Property(e => e.S19).HasColumnName("s19");

                entity.Property(e => e.S20).HasColumnName("s20");

                entity.Property(e => e.S21).HasColumnName("s21");

                entity.Property(e => e.S22).HasColumnName("s22");

                entity.Property(e => e.S23).HasColumnName("s23");

                entity.Property(e => e.S24).HasColumnName("s24");

                entity.Property(e => e.S25).HasColumnName("s25");

                entity.Property(e => e.S26).HasColumnName("s26");

                entity.Property(e => e.S27).HasColumnName("s27");

                entity.Property(e => e.S28).HasColumnName("s28");

                entity.Property(e => e.S29).HasColumnName("s29");

                entity.Property(e => e.S30).HasColumnName("s30");

                entity.Property(e => e.S31).HasColumnName("s31");

                entity.Property(e => e.S32).HasColumnName("s32");

                entity.Property(e => e.S33).HasColumnName("s33");

                entity.Property(e => e.S34).HasColumnName("s34");

                entity.Property(e => e.S35).HasColumnName("s35");

                entity.Property(e => e.S36).HasColumnName("s36");

                entity.Property(e => e.S37).HasColumnName("s37");

                entity.Property(e => e.S8).HasColumnName("s8");

                entity.Property(e => e.S9).HasColumnName("s9");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.İl)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Bist100>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.HacimStr).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HisseAdi)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.LastPice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IpAdres).HasMaxLength(50);

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Comment_dbo.Post_PostId");
            });

            modelBuilder.Entity<Hakkimda>(entity =>
            {
                entity.Property(e => e.About)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<HastaneBilgi>(entity =>
            {
                entity.Property(e => e.HastaneAdi)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Vkn)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Mesajlar>(entity =>
            {
                entity.Property(e => e.Eposta)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Ipadres)
                    .HasColumnName("IPAdres")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Mesaj)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.TamAd)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Zaman)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.PicturePath).HasMaxLength(250);

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Post)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Post_dbo.Category_CategoryId");
            });

            modelBuilder.Entity<PostTag>(entity =>
            {
                entity.HasOne(d => d.Post)
                    .WithMany(p => p.PostTag)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PostTag_dbo.Post_PostId");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.PostTag)
                    .HasForeignKey(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PostTag_dbo.Tag_TagId");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.Property(e => e.CalismaSuresi).HasMaxLength(250);

                entity.Property(e => e.Kurum).HasMaxLength(250);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.ResimAdres).HasMaxLength(250);

                entity.Property(e => e.Url).HasMaxLength(200);
            });

            modelBuilder.Entity<Referanslar>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aciklama)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Baslik)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CalismaSuresi)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Kurum).HasMaxLength(250);

                entity.Property(e => e.LinUrl).HasMaxLength(50);

                entity.Property(e => e.Platform).HasMaxLength(50);

                entity.Property(e => e.ResimAdres).HasMaxLength(150);
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.SelectedValue).HasMaxLength(500);
            });

            modelBuilder.Entity<SystemError>(entity =>
            {
                entity.Property(e => e.ErrorDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<UrlRecord>(entity =>
            {
                entity.Property(e => e.UniqueUrl).HasMaxLength(500);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
