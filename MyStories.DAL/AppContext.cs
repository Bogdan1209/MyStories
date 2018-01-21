using System;
using Microsoft.EntityFrameworkCore;
using MyStories.DAL.Entities;

namespace MyStories.DAL
{
    public class AppContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Listener> Listeners { get; set; }
        public DbSet<Story> Stories { get; set; }
        public DbSet<StoryListener> StoryListeners { get; set; }
        public AppContext(){
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<StoryListener>()
                .HasKey(t => new { t.StoryId, t.ListenerId});

            modelBuilder.Entity<StoryListener>()
                .HasOne(sl => sl.Story)
                .WithMany(s => s.StoryListeners)
                .HasForeignKey(sl => sl.StoryId);

            modelBuilder.Entity<StoryListener>()
                .HasOne(sl => sl.Listener)
                .WithMany(s => s.StoryListeners)
                .HasForeignKey(sl => sl.ListenerId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MyStories;uid=SA;pwd=Osinovka1;Trusted_Connection=True;");
        }
    }
}
