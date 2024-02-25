
namespace TenthApp
{
    public class ReadFile
    {
        public void Read(string filePath) 
        {
            var textLines = File.ReadAllLines(filePath);
            foreach (var line in textLines)
            {
                Console.WriteLine(line);
            }
        }   
    }
}
