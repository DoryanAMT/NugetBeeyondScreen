using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NugetBeeyondScreen.Models
{
    [Table("VERSION")]
    public class Version
    {
        [Key]
        [Column("VERSION_ID")]
        public int IdVersion { get; set; }
        [Column("IDIOMA")]
        public string Idioma { get; set; }

    }
}
