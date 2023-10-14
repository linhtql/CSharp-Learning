// ex1
// 1 - Write a program that reads a text file and displays the number of words.
var path = @"D:\Workspace\CSharpFundamentals\WorkingWithFiles\Exercise5-File\text.txt";

if(File.Exists(path))
{
    Console.WriteLine(File.ReadAllBytes(path).Length);
}

// ex2
// 2- Write a program that reads a text file and displays the longest word in the file.

if (File.Exists(path))
{
    string[] words = File.ReadAllText(path).Split(' ');
    string longestWord = words[0];

    foreach(string word in words)
    {
        if (word.Length > longestWord.Length) {  longestWord = word; }
    }
    Console.WriteLine("Longest Word: " + longestWord);
}