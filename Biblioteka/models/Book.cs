using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka.models
{
    
    public class Book
    {
        public string Tytul { get; }
        public string Kategoria { get; set; }
        public string Autor {  get; set; }
        public int Datawydania { get; set; }

        public Book( string tytul, string kategoria, string autor, int datawydania)
        {
            
            Tytul = tytul;
            Kategoria = kategoria;
            Autor = autor;
            Datawydania = datawydania;
        }
        // to_String()
        public override string ToString()
        {
            return $"tytul{Tytul}(autor{Autor},rok wydania{Datawydania})";
        }
    }
}
