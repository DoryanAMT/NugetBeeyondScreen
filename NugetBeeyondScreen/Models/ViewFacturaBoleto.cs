using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NugetBeeyondScreen.Models
{
    [Table("V_FACTURA_BOLETO")]
    public class ViewFacturaBoleto
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("USUARIO_ID")]
        public int IdUsuario { get; set; }

        [Column("PELICULA")]
        public string Pelicula { get; set; }

        [Column("CINE")]
        public string Cine { get; set; }

        [Column("HORA_FUNCION")]
        public DateTime HoraFuncion { get; set; }

        [Column("NUMBOLETOS")]
        public int? NumBoletos { get; set; }

        [Column("SALA")]
        public string Sala { get; set; }

        [Column("IDIOMA")]
        public string Idioma { get; set; }

        [Column("ASIENTOS")]
        public string Asientos { get; set; }

        [Column("TOTAL")]
        public int? Total { get; set; }
    }
}
