using CSharp_Advanced.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced.LambdaExpressions
{
    public class BookRepository
    {
        public static List<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book(5, "Title 1"),
                new Book(7, "Titlte 2"),
                new Book(17, "Title 3")
            };
        }

        public static List<Book> FindAll(Predicate<Book> predicate)
        {
            List<Book> result = new List<Book>();

            foreach(Book book in GetBooks())
            {
                if (predicate(book))
                {
                    result.Add(book);
                }
            }
            return result;
        }
    }
}
