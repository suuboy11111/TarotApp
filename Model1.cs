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

        // C�c DbSet hi?n t?i
        public virtual DbSet<Card> Cards { get; set; }
        public virtual DbSet<Meaning> Meanings { get; set; }
        public virtual DbSet<Reading> Readings { get; set; }
        public virtual DbSet<Spread> Spreads { get; set; }
        public virtual DbSet<Theme> Themes { get; set; }

        // Th�m DbSet cho ReadingDetail
        public virtual DbSet<ReadingDetail> ReadingDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Quan h? gi?a c�c b?ng ?� c�
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

            // Th�m c?u h�nh cho quan h? gi?a Reading v� ReadingDetail
            modelBuilder.Entity<Reading>()
                .HasMany(r => r.ReadingDetails)  // M?i Reading c� nhi?u ReadingDetail
                .WithRequired(rd => rd.Reading)
                .HasForeignKey(rd => rd.ReadingID)
                .WillCascadeOnDelete(true);  // T? ??ng x�a ReadingDetails khi Reading b? x�a

            modelBuilder.Entity<ReadingDetail>()
                .HasRequired(rd => rd.Card)  // M?i ReadingDetail c� m?t Card
                .WithMany()
                .HasForeignKey(rd => rd.CardID)
                .WillCascadeOnDelete(false);  // Kh�ng x�a Card khi ReadingDetail b? x�a
        }
    }
}
