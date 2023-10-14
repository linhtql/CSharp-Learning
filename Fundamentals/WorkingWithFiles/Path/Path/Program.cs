var path = @"D:\Workspace\CSharpFundamentals\HelloWorld\HelloWorld.sln";

Console.WriteLine("Extension: " + Path.GetExtension(path));
Console.WriteLine("File Name: " + Path.GetFileName(path));
Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path));
Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));