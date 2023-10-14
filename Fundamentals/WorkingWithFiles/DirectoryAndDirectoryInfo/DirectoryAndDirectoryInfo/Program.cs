// create directory 
Directory.CreateDirectory(@"d:\temp\folder1");

var files = Directory.GetFiles(@"D:\file-CSharp", "*.*", SearchOption.AllDirectories);
foreach(var file in files)
{
    Console.WriteLine(file);
}

Directory.Exists("...");
var directoryInfor = new DirectoryInfo("...");
directoryInfor.GetFiles();
directoryInfor.GetDirectories();

