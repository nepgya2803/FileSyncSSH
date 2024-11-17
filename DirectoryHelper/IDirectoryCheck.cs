namespace FileSyncSSH.DirectoryHelper
{
    public interface IDirectoryCheck
    {
        long GetNumberOfFile();

        bool VerifyPath();
    }
}