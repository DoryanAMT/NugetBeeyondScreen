using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NugetBeeyondScreen.Models
{
    [Table("USUARIO")]
    public class Usuario
    {
        [Key]
        [Column("USUARIO_ID")]
        public int IdUsuario { get; set; }
        [Column("NOMBRE")]
        public string Nombre { get; set; }
        [Column("EMAIL")]
        public string Email { get; set; }
        [Column("IMAGEN")]
        public string? Imagen { get; set; }
        [Column("SALT")]
        public string Salt { get; set; }
        [Column("PASS")]
        public byte[] Pass { get; set; }
        [Column("FECHA_CREACION")]
        public DateTime FechaCreacion { get; set; }
    }
}
