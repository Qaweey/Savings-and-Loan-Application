using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SavingandLoanProject.Data
{
    public class SavingsProfile
    {
        public int SavingsProfileId { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal AmountSaved { get; set; }
        [Required]
        public int NumberOfMonth { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmountToWithdraw { get; set; }
        public int CustomersProfileId { get; set; }
        public int SavingsPlanId { get; set; }


        //Navigational property
        public CustomersProfile CustomersProfile { get; set; }
        public SavingsPlan SavingsPlan{ get; set; }

    }
}
