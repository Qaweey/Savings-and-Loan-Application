using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SavingandLoanProject.Data
{
    public class LoansProfile
    {
        public int LoansProfileId { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amountborrowed { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal AmountToPayBack { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TargetAmountToPayBack { get; set; }

        public int CustomersProfileId { get; set; }


        //Navigational property
        public CustomersProfile CustomersProfile { get; set; }

      


    }
}
