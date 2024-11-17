namespace FileSyncSSH.DirectoryHelper
{
    public class DirectoryCheck : IDirectoryCheck
    {
        public string Path { get; set; }

        public DirectoryCheck(string Path)
        {
            if (String.IsNullOrEmpty(Path))
            {
                throw new ArgumentNullException(@"directory", "cannot be null");
            }

            this.Path = Path;

        }

        public bool VerifyPath()
        {
            DirectoryInfo di = new DirectoryInfo(this.Path);

            if (!di.Exists)
            {
                throw new InvalidOperationException("Path does not exist: " + this.Path);
            }

            return true;
        }

        public long GetNumberOfFile()
        {
            return (from file in Directory.EnumerateFiles(this.Path, "*", SearchOption.AllDirectories)
                    select file).Count();
        }
    }
}