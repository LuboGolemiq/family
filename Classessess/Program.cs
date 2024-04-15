namespace Classessess
{
    internal class Program
    {
        static void Main()
        {
            Dog dog1 = new Dog();
            Dog pumqr4e = new Dog();

            dog1.name = "Sara";
            dog1.breed = "bulldog";
            pumqr4e.name = "Vulcho";
            pumqr4e.breed = "Golden Retriver";
            dog1.age = 2;
            pumqr4e.age = 3;

            dog1.weight= 3.14;
            pumqr4e.weight = 3.18;


            dog1.canBark();
            pumqr4e.canBark();

            Console.WriteLine($"{dog1.name}");
        }
    }
}
