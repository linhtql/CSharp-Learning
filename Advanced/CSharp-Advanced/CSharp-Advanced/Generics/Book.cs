using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced.Generics
{
    public class Book : Product
    {
        public int Isbn { get; set; }

        public Book(float Price, string Title)
        {
            this.Isbn = Isbn;
            this.Price = Price;
        }
    }
}
