namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1

            //-------------------------------

            Console.WriteLine(5 + 2);
            Console.WriteLine(5 - 2);
            Console.WriteLine(6 / 2);
            Console.WriteLine(5 * 2);

            int a = 17;
            int b = 4;
            int quotient = a % b;
            Console.WriteLine($" The remainder of {a}/{b} is {quotient}.");

            //-------------------------------

            //Exercise 2

            //-------------------------------

            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine(AreaOfCircle.Calculate(radius));

        }
    }
}
