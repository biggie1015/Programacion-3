using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Parcial2.Models
{
    public class Usuarios
    {
        public int Id { get; set; }
             
        [StringLength(50)] 
        public string Nombre { get; set; }   
        [StringLength(50)]
        public string Apellido { get; set; }
        
        public DateTime fecha_Nacimiento { get; set; }

        public string Imagen { get; set; }

        public string Comentario { get; set; }


       
    }
}