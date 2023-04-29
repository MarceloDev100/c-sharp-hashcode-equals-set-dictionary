namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Maria";
            string b = "Alex";

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

            Console.WriteLine("----------------------------");

            string c = "Maria";
            Console.WriteLine(a.Equals(c));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(c.GetHashCode());
        }
    }
}