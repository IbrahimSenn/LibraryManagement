using LibraryManagement.DataAccessLayer;
using LibraryManagement.EntityLayer.Models;
using System.Drawing;

namespace LibraryManagement.BusinessLayer
{
    public class BookManager
    {
        private readonly BookRepository _bookRepo;

        public BookManager(BookRepository bookRepository)
        {
            _bookRepo = bookRepository;
        }
        public IEnumerable<Book> GetAllBooks()
        {
            return _bookRepo.GetAll();
        }

        public string Add(Book book)
        {
            if (string.IsNullOrWhiteSpace(book.Ad) || string.IsNullOrWhiteSpace(book.Yazar))
            {
                return "Kitap adı ve yazar adı boş olamaz.";
            }

            _bookRepo.Add(book);
            return "Kitap başarıyla eklendi.";
        }

        public string Update(Book book)
        {
           

            _bookRepo.Update(book);
            return "Kitap başarıyla güncellendi.";
        }

        public string Delete(int id)
        {
            if (id <= 0)
            {
                return "Geçersiz kitap ID.";
            }

            _bookRepo.Delete(id);
            return "Kitap başarıyla silindi.";
        }

    }
}
