using FileSyncSSH.DirectoryHelper;

namespace FileSyncSSH;

class Program
{
    static void Main(string[] args)
    {
        IDirectoryCheck dc = new DirectoryCheck("D:\\Azurlane");
        if (dc.VerifyPath())
        {
            var count = dc.GetNumberOfFile();
            Console.WriteLine(count);
        }
    }
}