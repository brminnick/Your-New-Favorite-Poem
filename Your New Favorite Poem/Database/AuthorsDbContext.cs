using System;
using Microsoft.EntityFrameworkCore;
using Your_New_Favorite_Poem.Models;

namespace Your_New_Favorite_Poem
{
    public class AuthorsDbContext : DbContext
    {
        public AuthorsDbContext(DbContextOptions<AuthorsDbContext> options) : base(options)
        {

        }

        public DbSet<Author> Authors => Set<Author>();
        public DbSet<Poem> Poems => Set<Poem>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Poem>().HasOne(p => p.Author).WithMany(b => b.Poems);
            modelBuilder.Entity<Author>().Property(b => b.CreatedAt).HasDefaultValue(DateTimeOffset.UtcNow);
            modelBuilder.Entity<Author>().Property(b => b.UpdatedAt).HasDefaultValue(DateTimeOffset.UtcNow);
            modelBuilder.Entity<Poem>().Property(b => b.CreatedAt).HasDefaultValue(DateTimeOffset.UtcNow);
            modelBuilder.Entity<Poem>().Property(b => b.UpdatedAt).HasDefaultValue(DateTimeOffset.UtcNow);
        }
    }
}