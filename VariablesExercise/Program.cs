namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize variables
            string name = "John";
            int age = 31;
            char middleInitial = 'D';
            bool isOver18 = true;
            double currentTemp = 77.9;
            decimal currentPrice = 29.99m;

            // Writing the variables in the console
            Console.WriteLine($"Name:{name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Middle Initial: {middleInitial}");
            Console.WriteLine($"Is Over 18: {isOver18}");
            Console.WriteLine($"curent Temp: {currentTemp}");
            Console.WriteLine($"current Price: {currentPrice}");
        }
    }
}
