namespace ExercicioVetores
{
    class Quartos
    {
        public string Nome { get; set; }
        public string Email { get; set;}

        public static void Abiaba(Quartos[] quartos)
        {
            for (int i = 0; i < quartos.Length; i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine($"\n{i}: {quartos[i].Nome}, {quartos[i].Email}");
                }
            }
        }
    }
}
