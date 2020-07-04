namespace WebCNPM.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyModels : DbContext
    {
        public MyModels()
            : base("name=MyModels")
        {
        }

        public virtual DbSet<BANTHANG> BANTHANGs { get; set; }
        public virtual DbSet<BXH_DOI> BXH_DOI { get; set; }
        public virtual DbSet<CAUTHU> CAUTHUs { get; set; }
        public virtual DbSet<CAUTHU_GHIBAN> CAUTHU_GHIBAN { get; set; }
        public virtual DbSet<CAUTHU_RASAN> CAUTHU_RASAN { get; set; }
        public virtual DbSet<DOIBONG> DOIBONGs { get; set; }
        public virtual DbSet<LOAICAUTHU> LOAICAUTHUs { get; set; }
        public virtual DbSet<MUAGIAI> MUAGIAIs { get; set; }
        public virtual DbSet<SAN> SANs { get; set; }
        public virtual DbSet<THAMSO> THAMSOes { get; set; }
        public virtual DbSet<TRAUDAU> TRAUDAUs { get; set; }
        public virtual DbSet<TRONGTAI> TRONGTAIs { get; set; }

        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BANTHANG>()
                .Property(e => e.MaLoaiBanThang)
                .IsUnicode(false);

            modelBuilder.Entity<BANTHANG>()
                .Property(e => e.BanThang1)
                .IsUnicode(false);

            modelBuilder.Entity<BANTHANG>()
                .HasMany(e => e.CAUTHU_GHIBAN)
                .WithRequired(e => e.BANTHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BXH_DOI>()
                .Property(e => e.MaDoi)
                .IsUnicode(false);

            modelBuilder.Entity<BXH_DOI>()
                .Property(e => e.MaMua)
                .IsUnicode(false);

            modelBuilder.Entity<CAUTHU>()
                .Property(e => e.MaCauThu)
                .IsUnicode(false);

            modelBuilder.Entity<CAUTHU>()
                .Property(e => e.MaDoi)
                .IsUnicode(false);

            modelBuilder.Entity<CAUTHU>()
                .Property(e => e.MaLoaiCauThu)
                .IsUnicode(false);

            modelBuilder.Entity<CAUTHU>()
                .Property(e => e.QuocTich)
                .IsUnicode(false);

            modelBuilder.Entity<CAUTHU>()
                .HasMany(e => e.CAUTHU_GHIBANs)
                .WithRequired(e => e.CAUTHU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CAUTHU>()
                .Property(e => e.HinhAnh)
                .IsUnicode(false);

            modelBuilder.Entity<CAUTHU_GHIBAN>()
                .Property(e => e.MaTranDau)
                .IsUnicode(false);

            modelBuilder.Entity<CAUTHU_GHIBAN>()
                .Property(e => e.MaCauThu)
                .IsUnicode(false);

            modelBuilder.Entity<CAUTHU_GHIBAN>()
                .Property(e => e.ThoiDiem)
                .IsUnicode(false);

            modelBuilder.Entity<CAUTHU_GHIBAN>()
                .Property(e => e.MaLoaiBanThang)
                .IsUnicode(false);

            modelBuilder.Entity<CAUTHU_RASAN>()
                .Property(e => e.MaTranDau)
                .IsUnicode(false);

            modelBuilder.Entity<CAUTHU_RASAN>()
                .Property(e => e.MaCauThu)
                .IsUnicode(false);

            modelBuilder.Entity<CAUTHU_RASAN>()
                .Property(e => e.MaDoi)
                .IsUnicode(false);

            modelBuilder.Entity<DOIBONG>()
                .Property(e => e.MaDoi)
                .IsUnicode(false);

            modelBuilder.Entity<DOIBONG>()
                .Property(e => e.MaSan)
                .IsUnicode(false);

            modelBuilder.Entity<DOIBONG>()
                .HasMany(e => e.CAUTHUs)
                .WithRequired(e => e.DOIBONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DOIBONG>()
                .HasMany(e => e.CAUTHU_RASAN)
                .WithRequired(e => e.DOIBONG)
                .WillCascadeOnDelete(false);

            //Tu them
            modelBuilder.Entity<DOIBONG>()
                .HasMany(e => e.BXHs)
                .WithRequired(e => e.DOIBONG)
                .WillCascadeOnDelete(false);


            modelBuilder.Entity<LOAICAUTHU>()
                .Property(e => e.MaLoaiCauThu)
                .IsUnicode(false);

            modelBuilder.Entity<MUAGIAI>()
                .Property(e => e.MaMua)
                .IsUnicode(false);

            modelBuilder.Entity<MUAGIAI>()
                .Property(e => e.TenMua)
                .IsUnicode(false);

            modelBuilder.Entity<MUAGIAI>()
                .HasMany(e => e.TRAUDAUs)
                .WithRequired(e => e.MUAGIAI)
                .WillCascadeOnDelete(false);
            
            //Tu them
            modelBuilder.Entity<MUAGIAI>()
               .HasMany(e => e.BXHs)
               .WithRequired(e => e.MUAGIAI)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<SAN>()
                .Property(e => e.MaSan)
                .IsUnicode(false);

            modelBuilder.Entity<SAN>()
                .HasMany(e => e.DOIBONGs)
                .WithRequired(e => e.SAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SAN>()
                .HasMany(e => e.TRAUDAUs)
                .WithRequired(e => e.SAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<THAMSO>()
                .Property(e => e.MaTS)
                .IsUnicode(false);

            //Tu them
            modelBuilder.Entity<THAMSO>()
                .HasMany(e => e.MUAGIAIs)
                .WithRequired(e => e.THAMSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TRAUDAU>()
                .Property(e => e.MaTranDau)
                .IsUnicode(false);

            modelBuilder.Entity<TRAUDAU>()
                .Property(e => e.MaMua)
                .IsUnicode(false);

            modelBuilder.Entity<TRAUDAU>()
                .Property(e => e.MaDoi1)
                .IsUnicode(false);

            modelBuilder.Entity<TRAUDAU>()
                .Property(e => e.MaDoi2)
                .IsUnicode(false);

            modelBuilder.Entity<TRAUDAU>()
                .Property(e => e.Luot)
                .IsUnicode(false);

            modelBuilder.Entity<TRAUDAU>()
                .Property(e => e.MaSan)
                .IsUnicode(false);

            modelBuilder.Entity<TRAUDAU>()
                .Property(e => e.MaTrongTai)
                .IsUnicode(false);

            modelBuilder.Entity<TRAUDAU>()
                .HasMany(e => e.CAUTHU_GHIBAN)
                .WithRequired(e => e.TRANDAU)
                .WillCascadeOnDelete(false);


            modelBuilder.Entity<TRONGTAI>()
                .Property(e => e.MaTrongTai)
                .IsUnicode(false);

            modelBuilder.Entity<TRONGTAI>()
                .HasMany(e => e.TRAUDAUs)
                .WithRequired(e => e.TRONGTAI)
                .WillCascadeOnDelete(false);
        }

        public System.Data.Entity.DbSet<WebCNPM.Models.BXH> BXHs { get; set; }
    }
}
