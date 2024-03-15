using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();
            string animal2 = Console.ReadLine();
            string animal3 = Console.ReadLine();

            switch (animal)
            {
                case "vertebrado":
                    switch (animal2)
                    {
                        case "ave":
                            switch (animal3)
                            {
                                case "carnivoro":
                                    Console.WriteLine("aguia");
                                    break;
                                case "onivoro":
                                    Console.WriteLine("pomba");
                                    break;
                            }
                            break;
                        case "mamifero":
                            switch (animal3)
                            {
                                case "onivoro":
                                    Console.WriteLine("homem");
                                    break;
                                case "herbivoro":
                                    Console.WriteLine("vaca");
                                    break;
                            }
                            break;
                    }
                    break;
                case "invertebrado":
                    switch (animal2)
                    {
                        case "inseto":
                            switch (animal3)
                            {
                                case "hematofago":
                                    Console.WriteLine("pulga");
                                    break;
                                case "herbivoro":
                                    Console.WriteLine("lagarta");
                                    break;
                            }
                            break;
                        case "anelideo":
                            switch (animal3)
                            {
                                case "hematofago":
                                    Console.WriteLine("sanguessuga");
                                    break;
                                case "onivoro":
                                    Console.WriteLine("minhoca");
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }
    }
}