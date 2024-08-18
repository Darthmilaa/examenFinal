using System.ComponentModel.DataAnnotations;

namespace WebAppEstudiantes.Models
{
    public class Estudiante
    {
        [Key]
        public int ID { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Apellido { get; set; }
        
        public int Edad { get; set; }
        
        [Required]
        [EmailAddress]
        public string Correo { get; set; }
    }
}
