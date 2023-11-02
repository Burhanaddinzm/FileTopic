string Path = "/Users/Burhan/Desktop/Test.txt";
//File.Create(Path);
File.WriteAllText(Path, "Test123");
Console.WriteLine(File.ReadAllText(Path)); 
