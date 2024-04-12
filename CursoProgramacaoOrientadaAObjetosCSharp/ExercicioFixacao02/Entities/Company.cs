namespace ExercicioFixacao02.Entities
{
    sealed class Company : PersonShape
    {
        public int EmployeesQuantity { get; set; }

        public Company(string name, double annualIncome, int employeesQuantity) : base(name, annualIncome)
        {
            EmployeesQuantity = employeesQuantity;
        }

        sealed public override double IncomeTax()
        {
            double tax = 0.0;
            if (EmployeesQuantity > 10) tax += ((double)AnnualIncome * 0.14);
            else tax += ((double)AnnualIncome * 0.16);
            return tax;
        }
    }
}
