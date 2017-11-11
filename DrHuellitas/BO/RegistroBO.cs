﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DrHuellitas.BO
{
    public class RegistroBO
    {
        public int id { get; set; }
        public int idtipo { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public string email { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string telefono { get; set; }
        public DateTime fecharegistro { get; set; }
        public DateTime fechanacimiento { get; set; }
        public int status { get; set; }
        public byte[] qr { get; set; }
        public byte[] foto { get; set; }

        //FALTA AGREGAR FOTO Y QR


    }
}