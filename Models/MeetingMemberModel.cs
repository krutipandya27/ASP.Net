using System.ComponentModel.DataAnnotations;
namespace MOM.Models
{
    public class MeetingMemberModel
    {
        [Key]
        public int MeetingMemberID { get; set; }
        public int MeetingID { get; set; }
        public int StaffID { get; set; }
        [Required]
        public bool IsPresent { get; set; }
        public string? Remarks { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

    }
}
