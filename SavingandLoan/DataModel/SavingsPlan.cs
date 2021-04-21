using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SavingandLoanProject.Data
{
    public class SavingsPlan
    {
        public int SavingsPlanId { get; set; }
        public string Name { get; set; }
        public SavingsProfile SavingsProfile { get; set; }
    }
}
