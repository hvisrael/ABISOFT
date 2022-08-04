using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABISOFT.Models
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string FullName { get; set; }
        [Column(TypeName = "integer")]
        public int Age { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string DOB { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string InscriptionDate { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal Cost { get; set; }

    }
}


/*-Nombre completo
2-Edad
3-Fecha de nacimiento
4-Fecha de inscripcion
5-Costo

 
 1-La fecha de inscripcion sea mayor que la de nacimiento
2-Que la persona tenga mas de 18 años
3-Que la edad coincida con la fecha de nacimiento
4-Que el costo sea proporcional a la fecha de inscripcion, 100 dolares por cada año transcurrido
5-Que se ingrese almenos dos nombres (nombre apellido) con 4 caracteres cada uno

 */