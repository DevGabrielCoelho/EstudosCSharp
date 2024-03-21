namespace ExercicioStatic1
{
    class Calc
    {
        public static double Calcular(double dollar, double quantidade) 
        {
            return (dollar + (dollar/100.0*6.0)) * quantidade;
        }
    }
}
