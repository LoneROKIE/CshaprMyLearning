﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set;}
        public string Apellido2 { get; set; }
        public string Direccion { get; set; }


    }
}
