using System.ComponentModel.DataAnnotations;

namespace IT_ELECTIVE_BSIT312E_Cabardo_JaellAndrei.Models
{
    public class MBTIViewModel
    {
        [Required(ErrorMessage = "Please select E or I.")]
        public string Axis1 { get; set; }

        [Required(ErrorMessage = "Please select S or N.")]
        public string Axis2 { get; set; }

        [Required(ErrorMessage = "Please select T or F.")]
        public string Axis3 { get; set; }
        [Required(ErrorMessage = "Please select J or P.")]
        public string Axis4 { get; set; }

        public string? ResultCode { get; set; }
        public string? Description { get; set; }
    }
}