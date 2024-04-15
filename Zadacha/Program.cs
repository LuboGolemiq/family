namespace Zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Rectangle n = new Rectangle();

            n.side1 = int.Parse(Console.ReadLine());
            n.side2 = int.Parse(Console.ReadLine());
            n.side3 = int.Parse(Console.ReadLine());
            n.side4 = int.Parse(Console.ReadLine());
            
            
          int A = n.side1 + n.side2 + n.side3 + n.side4;

            Console.WriteLine($"tgovor:{A}");
        }
    }
}
