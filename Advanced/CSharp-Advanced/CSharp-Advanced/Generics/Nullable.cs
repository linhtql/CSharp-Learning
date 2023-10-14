namespace CSharp_Advanced.Generics
{
    public class Nullable<T> where T : struct
    {
        private object value;
        public Nullable(T value)
        {
            this.value = value;
        }

        public bool HasValue
        {
            get { return value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
            {
                return (T)this.value;
            }
            return default(T);
        }

    }
}
