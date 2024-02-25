
namespace TenthApp
{
    public class AddFile
    {
        public string Add(string path, string fileName)
        {
            var filePath = Path.Combine(path, fileName);
            var stream1 = File.CreateText(filePath);

            stream1.WriteLine($"{DateTime.Now}");
            stream1.Flush();
            stream1.Close();

            return filePath;
        }
    }
}
