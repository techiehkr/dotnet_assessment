using BookApi.Models;
using Microsoft.EntityFrameworkCore;

public class BooksDbContext : DbContext
{
    public BooksDbContext(DbContextOptions<BooksDbContext> options) : base(options) { }
    public DbSet<Book> Books { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().ToTable("Books");
        modelBuilder.Entity<Book>().HasKey(b => b.Id);
        modelBuilder.Entity<Book>().Property(b => b.Publisher).IsRequired().HasMaxLength(255);
        modelBuilder.Entity<Book>().Property(b => b.Title).IsRequired().HasMaxLength(255);
        modelBuilder.Entity<Book>().Property(b => b.AuthorLastName).IsRequired().HasMaxLength(255);
        modelBuilder.Entity<Book>().Property(b => b.AuthorFirstName).IsRequired().HasMaxLength(255);
        modelBuilder.Entity<Book>().Property(b => b.Price).IsRequired().HasColumnType("double(18,2)");
    }
}
