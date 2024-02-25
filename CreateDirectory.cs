
namespace TenthApp
{
    public class CreateDirectory
    {
        public void Create(string path, string subPath)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
            directoryInfo.CreateSubdirectory(subPath);
        }
    }
}
