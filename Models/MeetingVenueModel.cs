using System.ComponentModel.DataAnnotations;

namespace MOM.Models
{
    public class MeetingVenueModel
    {
        [Key]
        public int MeetingVenueID { get; set; }
        [Required(ErrorMessage ="Invalid! Try Agian..")]
        [StringLength(100)]
        [Display(Name ="Meeting Venue Name")]
        public string MeetingVenueName { get; set; }
        public DateTime Created {  get; set; }  
        public DateTime Modified { get; set; }
    }
}
