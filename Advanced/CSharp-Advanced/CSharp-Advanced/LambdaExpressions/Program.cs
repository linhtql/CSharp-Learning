using CSharp_Advanced.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced.LambdaExpressions
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = BookRepository.GetBooks();
            //List<Book> cheapBook = BookRepository.FindAll(IsCheperThan10Dollars);
            List<Book> cheapBook = BookRepository.FindAll(book =>  book.Price < 10 );

            foreach (Book book in books) { Console.WriteLine(book); } 
        }

        static bool IsCheperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
    }
}
