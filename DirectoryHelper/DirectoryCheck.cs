namespace FileSyncSSH.DirectoryHelper
{
    public class DirectoryCheck : IDirectoryCheck
    {
        public string dir { get; set; }

        public DirectoryCheck(string Path)
        {
            if (String.IsNullOrEmpty(Path))
            {
                throw new ArgumentNullException(@"directory", "cannot be null");
            }

            this.dir = Path;

        }

        public bool VerifyPath()
        {
            DirectoryInfo di = new DirectoryInfo(this.dir);

            if (!di.Exists)
            {
                throw new InvalidOperationException("Path does not exist: " + this.dir);
            }

            return true;
        }

        public long GetNumberOfFile()
        {
            DirectoryInfo di = new DirectoryInfo(this.dir);

            return di.GetFiles("*", SearchOption.AllDirectories).Length;
        }

        public void PrintingListFile()
        {
            DirectoryInfo di = new DirectoryInfo(this.dir);
            string dt = DateTime.Now.ToString("yyyy-M-dd");

            using (StreamWriter outputFile = new StreamWriter(Path.Combine("log", $"{dt}.txt")))
            {
                foreach (var file in di.GetFiles())
                {
                    Console.WriteLine(file.FullName);
                    outputFile.WriteLine(file.FullName);
                }
            }
        }
    }
}