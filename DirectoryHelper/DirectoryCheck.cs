namespace FileSyncSSH.DirectoryHelper
{
    public class DirectoryCheck
    {
        public string Directory { get; set; }

        private long fileCount { get; set; }

        public DirectoryCheck(string directory)
        {
            if (String.IsNullOrEmpty(directory))
            {
                throw new ArgumentNullException(@"directory", "cannot be null");
            }

            this.Directory = directory;

        }

        bool VerifyDirectory(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            if (!di.Exists)
            {
                throw new InvalidOperationException("Path does not exist: " + path);
            }

            return true;
        }
    }
}