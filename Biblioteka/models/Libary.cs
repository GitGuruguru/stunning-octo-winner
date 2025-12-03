using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka.models
{
    internal class Libary
    {

        private readonly List<Book> books = new List<Book>();

        public IReadOnlyList<Book> Books => books;
        //Dodawania książki do biblioteki
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        // funkcja ktora szuka książki
        public  IEnumerable<Book> SearchBook(string fraza)
        {
            if(string.IsNullOrEmpty(fraza)) return books;
            else return books.Where(b => b.Tytul.Contains(fraza,System.StringComparison.OrdinalIgnoreCase));
        }
    }
}
