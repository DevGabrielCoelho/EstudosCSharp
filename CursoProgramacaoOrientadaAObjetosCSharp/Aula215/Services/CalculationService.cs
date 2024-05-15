using Entities;
using System.Collections.Generic;

namespace Services
{
    class CalculationService
    {
        public T Max<T>(List<T> products) where T : IComparable
        {
            if (products.Count == 0) throw new ArgumentException("Error! List is empty!");
            T max = products[0];
            for (int i = 1; i < products.Count; i++)
            {
                if (products[i].CompareTo(max) > 0) max = products[i]; 
            }
            return max;
        }
    }
}
