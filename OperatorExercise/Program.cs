using System.Reflection.Metadata;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;

            //Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}.");

            Console.WriteLine("Enter the radius of you circle:");

            var userInPut = Console.ReadLine();
            
            var radius = double.Parse(userInPut);
            
            Console.WriteLine(AreaOfCircle(radius));

        }

        private static double AreaOfCircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);

            return area;
        }
        
    }
    
}
         