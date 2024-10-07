using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MatricuFastWeb.Models
{
    public class Estiduantes
    {
        public int EstudianteId { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Carrera { get; set; }
        public DateTime AñoIngreso { get; set; }
        public string AdicionadoPor { get; set; }
        public DateTime FechaAdicion { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}