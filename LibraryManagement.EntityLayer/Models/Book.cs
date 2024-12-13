using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.EntityLayer.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Ad { get; set; }
        public string? Yazar { get; set; }
        public string? YayinEvi { get; set; }
        public int SayfaSayisi { get; set; }
        public string? Tur { get; set; }

        public string DisplayInfo => $"{Ad} - {Yazar} - {YayinEvi} - {SayfaSayisi}sayfa - {Tur}";
    }
}
