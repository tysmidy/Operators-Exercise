namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int twoNums = a + b;
            int multiNums = a * b;
            int subNums = a - b;
            int quotient = a / b;
            int remainder = a % b;

            //Use Console.WriteLine(); and string interpolation to write out the results in the following format for each operation:
            Console.WriteLine($"{a} + {b} is equal to {twoNums}");
            Console.WriteLine($"{a} - {b} is equal to {multiNums}");
            Console.WriteLine($"{a} * {b} is equal to {subNums}");
            Console.WriteLine($"{a} / {b} is equal to {quotient} with a remainder of {remainder}");


            //Exercise 2:
            //Create a method that will Calculate the area of a circle based on its radius


            Console.WriteLine("Please enter the radius of your circle");

            var userInput = Console.ReadLine();

            double radius = double.Parse(userInput);
            Console.WriteLine(AreaOfCircle(radius));
            
            

        }

        public static double AreaOfCircle(double radius)
        {
            //Console.WriteLine("Enter in a raidus of a circle.");
            //Console.ReadLine();
            //radius = double.Parse(Console.ReadLine());
            var area = Math.PI * Math.Pow(radius, 2);
            return area;


        }
    }
}
