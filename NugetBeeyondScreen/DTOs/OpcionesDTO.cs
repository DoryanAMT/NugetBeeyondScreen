using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NugetBeeyondScreen.Models;

namespace NugetBeeyondScreen.DTOs
{
    public class OpcionesDTO
    {
        public List<ComboPeliculas> Peliculas { get; set; }
        public List<ComboSalas> Salas { get; set; }
        public List<ComboVersiones> Versiones { get; set; }
        public List<Evento> Eventos { get; set; }
    }
}
