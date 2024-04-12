namespace ExercicioFixacao02.Entities
{
    sealed class Individual : PersonShape
    {
        public double HealthCost { get; set; }

        public Individual(string name, double annualIncome, double healthCost) : base(name, annualIncome)
        {
            HealthCost = healthCost;
        }
        sealed public override double IncomeTax()
        {
            double tax = 0.0;
            if (AnnualIncome < 20000)
            {
                tax += AnnualIncome * 0.15;
            }
            else tax += AnnualIncome * 0.25;
            if (HealthCost > 0) tax -= HealthCost * 0.50;
            return tax;
        }
    }
}
