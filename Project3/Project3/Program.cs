using Project3.Entities;

namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            LogFile logFile = new LogFile("in.txt");

            try
            {
                logFile.AddLog(new Log("amanda", DateTime.Parse("2020-08-26T20:45:08Z")));
                logFile.AddLog(new Log("alex86", DateTime.Parse("2020-08-26T21:49:37Z")));
                logFile.AddLog(new Log("bob", DateTime.Parse("2020-08-27T03:19:13Z")));
                logFile.AddLog(new Log("amanda", DateTime.Parse("2020-08-27T08:11:00Z")));
                logFile.AddLog(new Log("jeniffer", DateTime.Parse("2020-08-27T09:19:24Z")));
                logFile.AddLog(new Log("alex86", DateTime.Parse("2020-08-27T22:39:52Z")));
                logFile.AddLog(new Log("amanda", DateTime.Parse("2020-08-27T07:42:19Z")));

                logFile.CreateFile();
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }


            // shows all log records
            foreach (Log log in logFile.Logs)
            {
                Console.WriteLine(log);
            }

            Console.WriteLine();

            // total users
            Console.WriteLine("Total users: " + logFile.Logs.Count);
        }
    }
}