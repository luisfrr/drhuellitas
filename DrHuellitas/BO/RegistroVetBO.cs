﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DrHuellitas.BO
{
    public class RegistroVetBO
    {
        public int id { get; set; }
        public int idtipo { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public string email { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string telefono { get; set; }
        public DateTime fechanacimeinto { get; set; }
        public DateTime fecharegistro { get; set; }
        public int status { get; set; }
        public byte[] qr { get; set; }
        public byte[] foto { get; set; }

        public int idempresa { get; set; }
        public string nombreempresa { get; set; }
        public bool veteteirnaria { get; set; }
        public bool estetica { get; set; }
        public bool venderproducto { get; set; }

    }
}