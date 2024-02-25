namespace TenthApp
{
    internal class Program
    {
        static void Main()
        {
            var path = @"C:\Otus\";
            var TestDir1 = @"TestDir1";
            var TestDir2 = @"TestDir2";

            var dirForFile1 = @"C:\Otus\TestDir1";
            var dirForFile2 = @"C:\Otus\TestDir2";

            var fileName1 = "File1.txt";
            var fileName5 = "File5.txt";
            var fileName10 = "File10.txt";

            var createDirectory = new CreateDirectory();
            createDirectory.Create(path, TestDir1);
            createDirectory.Create(path, TestDir2);

            var addFile = new AddFile();
            var filePath1 = addFile.Add(dirForFile1, fileName1);
            var filePath2 = addFile.Add(dirForFile1, fileName5);
            var filePath3 = addFile.Add(dirForFile1, fileName10);
            var filePath4 = addFile.Add(dirForFile2, fileName1);
            var filePath5 = addFile.Add(dirForFile2, fileName5);
            var filePath6 = addFile.Add(dirForFile2, fileName10);

            var readFile = new ReadFile();
            readFile.Read(filePath1);
            readFile.Read(filePath2);
            readFile.Read(filePath3);
            readFile.Read(filePath4);
            readFile.Read(filePath5);
            readFile.Read(filePath6);

        }
    }
}