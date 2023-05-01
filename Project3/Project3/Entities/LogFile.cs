namespace Project3.Entities
{
    class LogFile
    {
        public string Name { get; private set; }
        public HashSet<Log> Logs { get; private set; }
        public string LogPath { get; private set; }

        public LogFile(string name)
        {
            Name = name;
            Logs = new HashSet<Log>();
            Init();
        }

        private void Init()
        {
            string currentDirectory = Path.GetDirectoryName(Environment.CurrentDirectory);
            string projectDirectory = Directory.GetParent(currentDirectory).Parent.Parent.FullName;
            LogPath = Path.Combine(projectDirectory, Name);
        }

        public void AddLog(Log log)
        {
            if (log != null)
            {
                Logs.Add(log);
            }
        }

        public void CreateFile()
        {
            if (Logs.Count > 0)
            {
                try
                {
                    File.WriteAllLines(LogPath, Logs.Select(x => x.ToString()));
                }
                catch (IOException e)
                {
                    Console.WriteLine("An error occurred!");
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                throw new ApplicationException("Log data must be added into LogFile class first!");
            }
        }
    }
}
