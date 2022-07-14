using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FourthTemplateforfoodordering.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage = "*")]
        public string FName { get; set; }
        [Required(ErrorMessage = "*")]
        public string LName { get; set; }
        public string Mobile { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
        [Required(ErrorMessage = "Please enter an valid Email ID")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please enter a valid Email ID")]
        public string Email { get; set; }
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        [NotMapped]
        [Display(Name = "Confirm Password")]
        public string CPassword { get; set; }  // Have to include In Bind of User controller
        public virtual ICollection<OrderMaster> OrderMasters { get; set; }
    }
}
