
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace NugetBeeyondScreen.Models
{
    #region
    //CREATE TABLE HORARIO_PELICULA(
    //HORARIO_ID INT PRIMARY KEY,
    //PELICULA_ID INT NOT NULL,
    //SALA_ID INT NOT NULL,
    //VERSION_ID INT NOT NULL,
    //HORA_FUNCION DATETIME NOT NULL,
    //ASIENTOS_DISPONIBLES INT NOT NULL,
    //CONSTRAINT FK_HORARIO_PELICULA FOREIGN KEY (PELICULA_ID) REFERENCES PELICULA(PELICULA_ID),
    //CONSTRAINT FK_HORARIO_SALA FOREIGN KEY (SALA_ID) REFERENCES SALA(SALA_ID),
    //CONSTRAINT FK_HORARIO_VERSION FOREIGN KEY (VERSION_ID) REFERENCES VERSION(VERSION_ID)
    //);
    #endregion
    [Table("HORARIO_PELICULA")]
    public class HorarioPelicula
    {
        [Key]
        [Column("HORARIO_ID")]
        public int IdHorario { get; set; }
        [Column("PELICULA_ID")]
        public int IdPelicula { get; set; }
        [Column("SALA_ID")]
        public int IdSala{ get; set; }
        [Column("VERSION_ID")]
        public int IdVersion{ get; set; }
        [Column("HORA_FUNCION")]
        public DateTime HoraFuncion { get; set; }
        [Column("ASIENTOS_DISPONIBLES")]
        public int AsientosDisponibles { get; set; }
        [Column("ESTADO")]
        public char Estado { get; set; }
    }
}
