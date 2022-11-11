using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Backend_BD.Models
{
    public class Maestros
    {
        [Key]
        public int Matricula { get; set; }
        public string Nombre { get; set; }
        public string apellidos { get; set; }
        public string Correo { get; set; }
        public int Edad { get; set; }



    }
}