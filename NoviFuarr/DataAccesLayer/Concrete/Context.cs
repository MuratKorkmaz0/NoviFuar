using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;


namespace DataAccesLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433\\Catalog=Default;Database=NoviFuar; User=SA; Password=hkFkeh-divzuf-9fovrz-Zxpnr;");
            //Server/"Data Source =192.168.3.101\SQLEXPRESS;Initiall Catalog = NoviFuarDB; User=sa; Password= hkFkeh-divzuf-9fovrz-Zxpnr;"

            
        }

        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Visitors>().HasKey(x => new { x.VisitorID });
        }
        */

        public DbSet<PersonalManagement> UserManagements { get; set; }

        public DbSet<Visitors> Visitors { get; set; }

        public object PersonalManagement { get; internal set; }

        public object Visitor { get; set; }
    }
}
