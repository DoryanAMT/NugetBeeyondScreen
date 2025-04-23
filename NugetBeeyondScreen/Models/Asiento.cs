using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NugetBeeyondScreen.Models
{
    [Table("ASIENTO")]
    public class Asiento
    {
        [Key]
        [Column("ASIENTO_ID")]
        public int IdAsiento { get; set; }
        [Column("SALA_ID")]
        public int IdSala { get; set; }
        [Column("HORARIO_ID")]
        public int IdHorario { get; set; }
        [Column("NUMERO")]
        public string Numero { get; set; }
        [Column("FILA")]
        public string Fila { get; set; }
        [Column("DISPONIBLE")]
        public Boolean Disponible { get; set; }
        
    }
}
