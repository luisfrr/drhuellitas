﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DrHuellitas.BO
{
    public class ComercioBO
    {
        public int idempresa { get; set; }
        public string nombreComercial { get; set; }
        public int idUsuario { get; set; }
        public bool veteteirnaria { get; set; }
        public bool estetica { get; set; }
        public bool venderproducto { get; set; }
        public string nombreFiscal { get; set; }
        public string rfc { get; set; }
        public string telefono1 { get; set; }
        public string telefono2 { get; set; }
        public string emal { get; set; }
    }
}