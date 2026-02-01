using System.ComponentModel.DataAnnotations;

namespace MOM.Models
{
    public class MeetingTypeModel
    {
        [Key]
        public int MeetingTypeID { get; set; }
        [Required(ErrorMessage ="Invalid! Try agian!!")]
        [StringLength(100)]
        [Display(Name ="Enter Meeting Type Name")]
        public string MeetingTypeName { get; set; }
        [StringLength(100)]
        public string Remarks { get; set; }
        public DateTime Created {  get; set; }
        public DateTime Modified { get; set; }
    }
}
