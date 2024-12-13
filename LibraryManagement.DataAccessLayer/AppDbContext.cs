using LibraryManagement.EntityLayer.Models;
using System.Data.Entity;
using System.Drawing;

namespace LibraryManagement.DataAccessLayer
{
    public class AppDbContext : DbContext   
    {
        public DbSet<Book> Books { get; set; }

        public AppDbContext() : base("KutuphaneDb")
        {

            Database.SetInitializer(new AppDbInitializer());
        }
        public static void Seed(AppDbContext context)
        {
            if (!context.Books.Any())
            {
                context.Books.Add(new Book { Id = 1, Ad = "Kitap 1", Yazar = "Yazar 1", YayinEvi = "2021", Tur = "Korku", SayfaSayisi = 200 });
                context.Books.Add(new Book { Id = 4, Ad = "Kitap 2", Yazar = "Yazar 2", YayinEvi = "2022", Tur = "Korku", SayfaSayisi = 200 });
                context.SaveChanges();
            }
        }
        public class AppDbInitializer : CreateDatabaseIfNotExists<AppDbContext>
        {
            protected override void Seed(AppDbContext context)
            {
                context.Books.Add(new Book { Id = 1, Ad = "Kitap 1", Yazar = "Yazar 1", YayinEvi = "2021", Tur = "Korku", SayfaSayisi = 200 });
                context.Books.Add(new Book { Id = 4, Ad = "Kitap 2", Yazar = "Yazar 2", YayinEvi = "2022", Tur = "Korku", SayfaSayisi = 200 });
                base.Seed(context);
            }
        }
    }
}
