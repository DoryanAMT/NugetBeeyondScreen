using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NugetBeeyondScreen.Models
{
    #region
    //-- Tabla de Películas
    //CREATE TABLE PELICULA(
    //    ID_PELICULA INT PRIMARY KEY,
    //    TITULO NVARCHAR(255) NOT NULL,
    //    FECHA_LANZAMIENTO DATETIME,
    //    DURACION_MINUTOS INT,
    //    TITULO_ETIQUETA NVARCHAR(255),
    //    SINOPSIS NVARCHAR(MAX),
    //    IMG_FONDO NVARCHAR(255),
    //    IMG_POSTER NVARCHAR(255),
    //);
    #endregion
    [Table("PELICULA")]
    public class Pelicula
    {
        [Key]
        [Column("PELICULA_ID")]
        public int IdPelicula { get; set; }
        [Column("TITULO")]
        public string Titulo { get; set; }
        [Column("FECHA_LANZAMIENTO")]
        public DateOnly FechaLanzamiento { get; set; }
        [Column("DURACION_MINUTOS")]
        public int DuracionMinutos { get; set; }
        [Column("TITULO_ETIQUETA")]
        public string TituloEtiqueta { get; set; }
        [Column("SINOPSIS")]
        public string Sinopsis { get; set; }
        [Column("IMG_FONDO")]
        public string ImgFondo { get; set; }
        [Column("IMG_POSTER")]
        public string ImgPoster { get; set; }

    }
}   
