namespace GreetingApp
{
    internal class GreetingProgram
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            String name = Console.ReadLine();
            Console.Write("Enter the total number of your enrolled courses: ");
            int courses = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the price of your favorite book: ");
            double fbook_Price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Total enrolled courses: " + courses);
            Console.WriteLine("Price of my favorite book: " + fbook_Price);
            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}