using BookApp.Data.Configurations;
using BookApp.Data.Utils;
using BookApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BookStore.Data
{
    public class BookAppContext : DbContext
    {       

        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Review> Reviews { get; set; } = null!;
        public DbSet<Author> Authors { get; set; } = null!;
        public DbSet<PriceOffer> PriceOffers { get; set; } = null!;
        public DbSet<Tag> Tags { get; set; } = null!;
        public DbSet<Order> Ordes { get; set; } = null!;
        public DbSet<Item> Items { get; set; } = null!;
        public DbSet<Customer> Customers { get; set; } = null!;

        public BookAppContext(DbContextOptions<BookAppContext> options) : base(options)
        {

        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuthorModelConfig());
            modelBuilder.ApplyConfiguration(new BookModelConfigs());
            modelBuilder.ApplyConfiguration(new ReviewModelConfig());
            modelBuilder.ApplyConfiguration(new CustomerModelConfigs());
            modelBuilder.ApplyConfiguration(new TagModelConfigs());
            modelBuilder.ApplyConfiguration(new BookAuthorModelConfigs());
            modelBuilder.ApplyConfiguration(new BookTagModelConfigs());
            modelBuilder.ApplyConfiguration(new OrderModelConfigs());
            modelBuilder.ApplyConfiguration(new OrderStatusModelConfigs());
            modelBuilder.ApplyConfiguration(new ItemModelConfigs());

            modelBuilder.HasDbFunction(() => Methods.AverageVotes(default(int)));
            modelBuilder.HasDbFunction(() => Methods.TotalOrderPrice(default(int)));
            base.OnModelCreating(modelBuilder);
        }
    }
}
