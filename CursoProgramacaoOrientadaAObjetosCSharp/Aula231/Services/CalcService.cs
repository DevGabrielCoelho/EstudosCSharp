namespace Aula231.Services
{
    internal class CalcService
    {
        public static void Max(double x, double y)
        {
            Console.WriteLine((x > y) ? x : y);
        }

        public static void Sum(double x, double y)
        {
            Console.WriteLine(x + y);
        }

        public static void Pow(double x)
        {
            Console.WriteLine(x * x);
        }
        
        public static void Sqrt(double x)
        {
            Console.WriteLine(Math.Sqrt(x));
        }
    }
}
