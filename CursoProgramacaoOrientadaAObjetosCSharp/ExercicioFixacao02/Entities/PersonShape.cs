namespace ExercicioFixacao02.Entities
{
    abstract class PersonShape
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        protected PersonShape(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double IncomeTax();
    }
}
