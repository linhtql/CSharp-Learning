using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced.Generics
{
    // where T : interface
    // where T : class
    // where T : struct
    // where T : new()

    public class Utilities<T> where T : IComparable<T>, new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public T Max(T a, T b) 
        { 
            return a.CompareTo(b) > 0 ? a : b;
        }

        public void DoSomeThing(T t)
        {
            T obj = new T();
        }
    }
}
