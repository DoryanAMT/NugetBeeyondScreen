using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NugetBeeyondScreen.Models
{
    [Table("BOLETO")]
    public class Boleto
    {
        [Key]
        [Column("BOLETO_ID")]
        public int IdBoleto { get; set; }
        [Column("USUARIO_ID")]
        public int IdUsuario { get; set; }
        [Column("ASIENTO_ID")]
        public int IdAsiento { get; set; }
        [Column("HORARIO_ID")]
        public int IdHorario { get; set; }
        [Column("FECHA_COMPRA")]
        public DateTime FechaCompra { get; set; }
        [Column("ESTADO")]
        public string Estado { get; set; }
    }
}
