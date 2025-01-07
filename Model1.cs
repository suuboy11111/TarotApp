using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TarotApp
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Tarot")
        {
        }

        // Các DbSet hi?n t?i
        public virtual DbSet<Card> Cards { get; set; }
        public virtual DbSet<Meaning> Meanings { get; set; }
        public virtual DbSet<Reading> Readings { get; set; }
        public virtual DbSet<Spread> Spreads { get; set; }
        public virtual DbSet<Theme> Themes { get; set; }

        // Thêm DbSet cho ReadingDetail
        public virtual DbSet<ReadingDetail> ReadingDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Quan h? gi?a các b?ng ?ã có
            modelBuilder.Entity<Card>()
                .HasMany(e => e.Meanings)
                .WithRequired(e => e.Card)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Card>()
                .HasMany(e => e.Readings)
                .WithRequired(e => e.Card)
                .HasForeignKey(e => e.Card1ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Card>()
                .HasMany(e => e.Readings1)
                .WithRequired(e => e.Card1)
                .HasForeignKey(e => e.Card2ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Card>()
                .HasMany(e => e.Readings2)
                .WithRequired(e => e.Card2)
                .HasForeignKey(e => e.Card3ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Theme>()
                .HasMany(e => e.Meanings)
                .WithRequired(e => e.Theme)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Theme>()
                .HasMany(e => e.Readings)
                .WithRequired(e => e.Theme)
                .WillCascadeOnDelete(false);

            // Thêm c?u hình cho quan h? gi?a Reading và ReadingDetail
            modelBuilder.Entity<Reading>()
                .HasMany(r => r.ReadingDetails)  // M?i Reading có nhi?u ReadingDetail
                .WithRequired(rd => rd.Reading)
                .HasForeignKey(rd => rd.ReadingID)
                .WillCascadeOnDelete(true);  // T? ??ng xóa ReadingDetails khi Reading b? xóa

            modelBuilder.Entity<ReadingDetail>()
                .HasRequired(rd => rd.Card)  // M?i ReadingDetail có m?t Card
                .WithMany()
                .HasForeignKey(rd => rd.CardID)
                .WillCascadeOnDelete(false);  // Không xóa Card khi ReadingDetail b? xóa
        }
    }
}
