using LibraryManagement.EntityLayer.Models;
using System.Data.Entity;

namespace LibraryManagement.DataAccessLayer
{
    public class BookRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly DbSet<Book> _dbSet;
        public BookRepository(AppDbContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<Book>();
        }

        public IEnumerable<Book> GetAll()
        {
            return _dbSet.ToList();
        }

        public Book GetById(int id)
        {
            return _dbSet.Find(id);
        }
        public void Add(Book book)
        {
            _dbSet.Add(book);
            _dbContext.SaveChanges();
        }
        public void Update(Book book)

        {
            
            _dbContext.SaveChanges(); 

        }
        public void Delete(int id)
        {
            _dbSet.Remove(GetById(id));
            _dbContext.SaveChanges();

        }
        

    }
}
