namespace HW8Practice.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class dbContext : DbContext
    {
        public dbContext()
            : base("name=dbContext")
        {
        }

        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Artwork> Artworks { get; set; }
        public virtual DbSet<Classification> Classifications { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>()
                .Property(e => e.aName)
                .IsUnicode(false);

            modelBuilder.Entity<Artist>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<Artist>()
                .HasMany(e => e.Artworks)
                .WithRequired(e => e.Artist)
                .HasForeignKey(e => e.idA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Artwork>()
                .Property(e => e.aName)
                .IsUnicode(false);

            modelBuilder.Entity<Artwork>()
                .HasMany(e => e.Classifications)
                .WithRequired(e => e.Artwork)
                .HasForeignKey(e => e.idA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Genre>()
                .Property(e => e.gName)
                .IsUnicode(false);

            modelBuilder.Entity<Genre>()
                .HasMany(e => e.Classifications)
                .WithRequired(e => e.Genre)
                .HasForeignKey(e => e.idG)
                .WillCascadeOnDelete(false);
        }
    }
}
