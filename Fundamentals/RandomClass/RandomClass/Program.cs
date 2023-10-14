namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            const int passwordLength = 10;

            var buffet = new char[passwordLength];

            for (int i = 0; i < buffet.Length; i++)
            {
                buffet[i] = (char)('a' + random.Next(0, 26));
            }

            var password = new string(buffet);

            Console.WriteLine(password);
        }
    }
}
