using System.Text;

var sb = new StringBuilder("Hello World");
sb
    .Append('-', 10)
    .AppendLine()
    .Append("Header")
    .AppendLine()
    .Append('-', 10)
    .Replace('-', '+')
    .Remove(0, 10);

Console.WriteLine(sb.ToString());