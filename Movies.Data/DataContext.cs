using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Movies.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Data
{
     public class DataContext : IdentityDbContext<IdentityUser>
    {
        public DataContext(DbContextOptions options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<FilmDirector> FilmDirectors { get; set; }
        public DbSet<Writter> Writters { get; set; }
        public DbSet<ProductionCompany> ProductionCompanies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<WishList> WishLists { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
      

    // have to tell the datacontext class about our models...
   
}
