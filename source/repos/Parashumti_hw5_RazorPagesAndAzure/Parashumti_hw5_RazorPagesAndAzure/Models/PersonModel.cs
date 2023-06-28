using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parashumti_hw5_RazorPagesAndAzure.Models
{
    public class PersonModel
    {
        public int ID { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 2)]
        [DisplayName("First Name")]
        public String FirstName { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 4)]
        [DisplayName("Last Name")]
        public String LastName { get; set; }
        [Required]
        [StringLength(3, MinimumLength = 1)]
        public String Age { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5)]
        public String Email { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 7)]
        [DisplayName("Phone Number")]
        public String PhoneNumber { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 8)]
        public String Date { get; set; }

    }
}
