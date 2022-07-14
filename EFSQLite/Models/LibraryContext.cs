using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace EFSQLite.Models
{
    internal class LibraryContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /*Assembly? assembly = Assembly.GetEntryAssembly();
            ArgumentNullException.ThrowIfNull(assembly);
            string? directoryName = Path.GetDirectoryName(assembly.Location);
            ArgumentNullException.ThrowIfNull(directoryName);
            */
            optionsBuilder.UseSqlite($"Data Source={Path.Combine("path", "database.db")}");
        }
    }
}
