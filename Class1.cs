using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClaimAssignment.Models
{
    public class Class1
    {
        
            public int claimid { get; set; }

            [Display(Name = "Claim Description:")]
            [Required(ErrorMessage = "Enter the description")]
            public string claimdesc { get; set; }

            [Display(Name = "Claim Type:")]
            [Required(ErrorMessage = "Select the Claim Type")]
            public string claimtype { get; set; }

            [Display(Name = "Claim Status:")]
            public string claimstatus { get; set; }

            [Display(Name = "Mobile No:")]
            [Required(ErrorMessage = "Enter the mobile no")]
            [RegularExpression(@"^[0-9]{10}", ErrorMessage = "Enter 10 digit mobile no")]
            public Nullable<long> mobno { get; set; }

            [Display(Name = "Employee Id:")]
            [Required(ErrorMessage = "Enter the employee id")]
            public Nullable<int> empid { get; set; }


        }

    [MetadataType(typeof(Class1))]
    public partial class tblclaim1349205
    {
    }
}

