namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 3, 7, 9, 2, 14, 6 };

            // Length
            Console.WriteLine("Length: " + numbers.Length);

            // IndexOf()
            Console.WriteLine("Index of 9: " + Array.IndexOf(numbers, 9)); // 2

            // Clear()
            // Array.Clear(numbers); -> dua gia tri cua tat ca cac phan tu ve 0

            Array.Clear(numbers,1, 3);  // 3, 0 ,0, 0, 14, 6 -> bat dau tu vi tri nao? do dai bao nhieu
            Console.WriteLine("Effect of Clear()");
            foreach (int i in numbers) Console.WriteLine(i);

            // Copy()
            int[] another = new int[4];
            Array.Copy(numbers, another, 4); // 3 0 0
            Console.WriteLine("Effect of Copy()");
            foreach (int i in another) Console.WriteLine(i);

            // Sort
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort()");
            foreach (int i in numbers) Console.WriteLine(i);

            // Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse()");
            foreach (int i in numbers) Console.WriteLine(i);

        }
    }
}