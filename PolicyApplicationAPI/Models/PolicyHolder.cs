using Microsoft.AspNetCore.Identity;
using PolicyApplicationAPI.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PolicyApplicationAPI.Models
{
    public class PolicyHolder 
    {
        [Key]
        public int PolicyHolderId { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(13)")]
        public string? PolicyHolderIdNumber { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(4)")]
        public string? PolicyHolderInitial { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        public string? PolicyHolderSurname { get; set; }

        public DateTime? PolicyHolderDateOfBirth { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(5)")]
        public string? PolicyHolderGender { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string? PolicyHolderPolicyNumber { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string? PolicyHolderPolicyType { get; set; }
        public DateTime? PolicyHolderCommenmentDate { get; set; }
        public double PolicyHolderInstallmentAmount { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string? PolicyHolderEmail { get; set; }

       
        public string? ImageAltDescription { get; set; }
        public string? ImageFileName { get; set; }
        [NotMapped]
        public IFormFile? ImageFile { get; set; }



    }
}
