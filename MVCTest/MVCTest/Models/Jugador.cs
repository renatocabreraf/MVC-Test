﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTest.Models
{
    public class Jugador
    {
        public int ID {get; set;}
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Posición { get; set; }
        public decimal Salario { get; set; }
        public string Club { get; set; }
    }
}