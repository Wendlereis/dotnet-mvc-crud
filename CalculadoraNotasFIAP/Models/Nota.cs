using System.ComponentModel.DataAnnotations;

namespace CalculadoraNotasFIAP.Models
{
    public class Nota
    {
        [Required]
        [Display(Name = "RM")]
        [MaxLength(5, ErrorMessage = "O Rm deve ter 5 digitos")]
        public string Rm { get; set; }

        [Required]
        [Display(Name = "NAC")]
        [Range(0, 10, ErrorMessage = "A nota deve estar entre 0 e 10")]
        public double Nac { get; set; }

        [Required]
        [Display(Name = "AM")]
        [Range(0, 10, ErrorMessage = "A nota deve estar entre 0 e 10")]
        public double Am { get; set; }

        [Required]
        [Display(Name = "PS")]
        [Range(0, 10, ErrorMessage = "A nota deve estar entre 0 e 10")]
        public double Ps { get; set; }

        
        [Display(Name = "Média")]
        [Range(0, 10, ErrorMessage = "A nota deve estar entre 0 e 10")]
        public double Media { get; set; }
    }
}   