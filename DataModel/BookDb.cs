using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Internal;
using Bookish.Models;
using Microsoft.EntityFrameworkCore;
namespace Bookish.DataModel
{
    public class BookDb : DbContext
    {
        public BookDb(DbContextOptions<BookDb> options) : base(options)
        {
        }
        public DbSet<Book> BookDbSet { get; set; }

    }
}
