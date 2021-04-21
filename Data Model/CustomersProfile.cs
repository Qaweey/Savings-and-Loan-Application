
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SavingandLoanProject.Data
{
    public class CustomersProfile
    {
        public int CustomersProfileId { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        public string Address { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }
        [Required]
        [StringLength(10)]
        public string BVNNumber { get; set; }
        [StringLength(11)]
        public string PhoneNumber { get; set; }
        public int SavingsId { get; set; }
        public int LoanId { get; set; }

        public List<SavingsProfile> SavingsProfile { get; set; } = new();
        public List<LoansProfile> LoansProfile { get; set; } = new();

    }
}
