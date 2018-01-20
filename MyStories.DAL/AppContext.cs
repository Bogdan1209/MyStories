using System;
using Microsoft.EntityFrameworkCore;

namespace MyStories.DAL
{
    public class AppContext: DbContext
    {
        public AppContext(){
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MyStories;uid=SA;pwd=Osinovka1;Trusted_Connection=True;");
        }
    }
}
