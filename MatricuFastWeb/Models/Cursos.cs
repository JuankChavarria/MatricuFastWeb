using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MatricuFastWeb.Models
{
    public class Cursos
    {
        public int CursoId { get; set; }
        public string NombreCurso { get; set; }
        public int Creditos { get; set; }
        public DateTime Horas { get; set; }
        public string AdicionadoPor { get; set; }
        public DateTime FechaAdicion { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime FechaModificacion { get; set; }


    }
}