using Aula128.Entities.Enums;
using Aula128.Entities;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Aula128.Entities
{
    class Worker
    {
        public string Name { get; private set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; } = new Departament();
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker(string name, WorkerLevel level, double baseSalary, string departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament.Name = departament;
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
            double contractValue = 0;

            for (int i = 0; i < Contracts.Count; i++)
            {
                if (Contracts[i].Date.Month != mounth || Contracts[i].Date.Year != year)
                {
                    HourContract contractRemove = Contracts[i];
                    Contracts.Remove(contractRemove);
                }
            }
             
            for (int i = 0;  i < Contracts.Count; i++)
            {
                HourContract contractCount = Contracts[i];
                contractValue += contractCount.TotalValue();
            }
            return contractValue + BaseSalary;


        }
    }
}
