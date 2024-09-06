using Microsoft.EntityFrameworkCore;

namespace RRTest.API.Models;

public class BookContext : DbContext
{
    public BookContext(DbContextOptions<BookContext> options) : base(options) { }

    public DbSet<Book> Books { get; set; }
    public DbSet<Quote> Quotes { get; set; }
}
