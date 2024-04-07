using Aula128.Entities.Enums;

namespace Aula128.Entities
{
    class Worker
    {
        public string Name { get; private set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; } = new Departament();
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income(int year, int mounth)
        {
            double contractValue = BaseSalary;

            for (int i = 0;  i < Contracts.Count; i++)
            {
                if (Contracts[i].Date.Year == year && Contracts[i].Date.Month == mounth)
                {
                    contractValue += Contracts[i].TotalValue();
                }
            }
            return contractValue;
        }
    }
}
