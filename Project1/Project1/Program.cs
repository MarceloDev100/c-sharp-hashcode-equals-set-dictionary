using Project1.Entities;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client b = new Client { Name = "Alex", Email = "alex@gmail.com" };
            Client c = new Client { Name = "Maria Silva", Email = "maria@gmail.com" };

            // Compares the content
            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.Equals(c));

            // HashCode of each object
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

            Console.WriteLine("---------------------------");
            // Compares the object's reference
            Console.WriteLine(a == b);
            Console.WriteLine(a == c);
        }
    }
}