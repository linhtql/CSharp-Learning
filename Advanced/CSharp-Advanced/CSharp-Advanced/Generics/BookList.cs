using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced.Generics
{
    public class BookList
    {
        public void Add(Book book) {}

        public Book this[int index]
        {
            get {throw new NotImplementedException(); }
        }
    }

    public class ObjectList
    {
        public void Add(object obj) { }
        public object this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class GenericList<T>
    {
        public void Add(T t) { }
        public T this[int index] {
        get { throw new NotImplementedException(); }}
    }

    public class GenericDictionary<K, V>
    {
        public void Add(K key, V value) { }
    }
}
