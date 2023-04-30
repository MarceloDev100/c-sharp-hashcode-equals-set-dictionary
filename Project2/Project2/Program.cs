using Project2.Entities;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Predefined types already have Equals and HashCode implemented.
            HashSet<string> set = new HashSet<string>();

            set.Add("Maria");
            set.Add("Alex");

            // The content is compared.
            // Console.WriteLine(set.Contains("Maria"));

            /*
              How hash collections test equality?
              - if GetHashCode and Equals are implemented: 
                First HashCode. If it's the same, it is confirmed with Equals method
              
              - if GetHashCode and Equals are NOT implemented: 
                Reference types: object references are compared. 
                Value types : attributes values are compared.
            */

            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.00));
            a.Add(new Product("Notebook", 1200.00));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.00);
            Console.WriteLine(a.Contains(prod));

            Point p = new Point(5, 10);
            Console.WriteLine(b.Contains(p));
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach(T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}