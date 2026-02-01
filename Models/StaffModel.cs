using System.ComponentModel.DataAnnotations;

namespace MOM.Models
{
    public class StaffModel
    {
        [Key]
        public int StaffID { get; set; }

        public int DepartmentID { get; set; }
        [Required(ErrorMessage ="**Required")]
        [StringLength(50)]
        public string StaffName { get; set; }
        [Required(ErrorMessage = "**Required")]
        [StringLength(20)]
        public string MobileNo { get; set; }
        [Required(ErrorMessage = "**Required")]
        [StringLength(50)]
        public string EmailAddress { get; set; }
        public string? Remarks { get; set; }
        public DateTime Created {  get; set; }
        public DateTime Modified { get; set; }

    }
}
