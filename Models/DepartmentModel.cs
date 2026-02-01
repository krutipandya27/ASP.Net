using System.ComponentModel.DataAnnotations;
namespace MOM.Models

{
    public class DepartmentModel
    {
        [Key]
        public int DepartmentID { get; set; }
        [Required(ErrorMessage ="Invalid!..Try Agian..")]
        [Display(Name ="Enter Department Name")]
        public string DepartmentName { get; set; }
        
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

    }
}
