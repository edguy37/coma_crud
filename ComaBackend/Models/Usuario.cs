using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComaBackend.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName ="Varchar(30)")]
        public required string nombre { get; set; }

        [Required]
        [Column(TypeName = "Varchar(30)")]
        public required string apellido { get; set; }

        [Required]
        [Column(TypeName = "Varchar(2)")]
        public required string edad { get; set; }

        [Required]
        [Column(TypeName = "Varchar(30)")]
        public required string correo { get; set; }

        [Required]
        [Column(TypeName = "Varchar(15)")]
        public required string tipo_usuario { get; set; }
    }
}
