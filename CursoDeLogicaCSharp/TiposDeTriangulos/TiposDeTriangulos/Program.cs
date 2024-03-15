using System;
using System.Globalization;

namespace TiposDeTriangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, n1, n2, n3;
            string[] x = Console.ReadLine().Split(' ');
            n1 = double.Parse(x[0], CultureInfo.InvariantCulture);
            n2 = double.Parse(x[1], CultureInfo.InvariantCulture);
            n3 = double.Parse(x[2], CultureInfo.InvariantCulture);
            a = 0;
            b = 0;
            c = 0;

            if (n1 >= n2 && n1 >= n3)
            {
                a = n1;
                if (n2 >= n3)
                {
                    b = n2;
                    c = n3;
                }
                else
                {
                    b = n3;
                    c = n2;
                }

            }

            else if(n2 >= n1 && n2 >= n3)
            {
                a = n2;
                if (n1 >= n3)
                {
                    b = n1;
                    c = n3;
                }
                else
                {
                    b = n3;
                    c = n1;
                }
            }   

            else if(n3 >= n1 && n3 >= n2)
            {
                a = n3;
                if (n1 >= n2)
                {
                    b = n1;
                    c = n2;
                }
                else
                {
                    b = n2;
                    c = n1;
                }
            }




            if ((a >= (b + c)))
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }


            else
            {
                if ((a*a) == ((b*b) + (c*c)))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if ((a * a) > ((b * b) + (c * c)))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

                if ((a == b) && (a == c) && (b == c))
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if ((a == b && a != c) || (c == b && a != c))
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }





        }
    }
}