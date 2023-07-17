using System.Data.Entity;
using WedkoApp.Models;

namespace WedkoApp
{
    public class YourDatabaseContext : DbContext
    {
        public YourDatabaseContext() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\testo.mdf;Integrated Security=True")
        {
        }

        public DbSet<Product>? Products { get; set; }

        // Dodaj DbSet dla innych tabel w bazie danych

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Dodaj konfiguracje Fluent API lub atrybuty dla mapowania relacji między tabelami
        }
    }
}
