using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MatricuFastWeb.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set;}
        public string Constraseña { get; set; }
        public string Email { get; set; }
        public string AdicionadoPor { get; set; }
        public string FechaAdicion { get; set; }
        public string ModificadoPor { get; set; }
        public string FechaModificacion { get; set; }

  


    }
}