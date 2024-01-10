using System.ComponentModel.DataAnnotations;

namespace ModelValidationAssignment.Models
{
    public class Movie
    {
        
        public int MoiveID {  get; set; }
        [Required(ErrorMessage = "Please Enter Movie Name!!")]
       // [RegularExpression("[a-zA-z0-9]",ErrorMessage ="Movie name should be letters and digits")]
        public string MovieName { get; set;}
        [Required(ErrorMessage = "Please Enter Director Name!!")]
        //[RegularExpression("[a-zA-z0-9]", ErrorMessage = "Director name should be letters and digits")]
        public string Director { get; set;}
        
        [Required(ErrorMessage = "Please Enter Actor Name!!")]
       // [RegularExpression("[\\sa-zA-z]{20}", ErrorMessage = "Actor name should be letters and digits")]
        public string Actor { get; set;}
        [Required(ErrorMessage = "Please Enter Release year")]
       // [RegularExpression("[0-9]{4}", ErrorMessage = "Director name should be letters and digits")]

        [Range(1900, 2024)]


        public int YearofRelease { get; set;}
        [Required(ErrorMessage = "Please Language!!")]
        public string Language {  get; set;}
    }
}
