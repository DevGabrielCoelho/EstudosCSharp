using System;

namespace ExercicioClassObj3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            aluno.PrimeiraNota = double.Parse(Console.ReadLine());
            aluno.SegundaNota = double.Parse(Console.ReadLine());
            aluno.TerceiraNota = double.Parse(Console.ReadLine());

            Console.WriteLine("NOTA = " + aluno);
        }
    }
}