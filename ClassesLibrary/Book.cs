using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int NbrOfPages { get; set; }

        public Book()
        {

        }

        public Book(string title, string author, int nbrOfPages)
        {
            Title = title;
            Author = author;
            NbrOfPages = nbrOfPages;
        }

        public override string ToString()
        {
            return string.Format("\n===== BOOK =====\n\nTitle: {0}\nAuthor: {1}\nNumber of Pages: {2}\n",
                Title,
                Author,
                NbrOfPages);
        }
    }
}
