﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Capa_Entidades
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string TipoDocumento { get; set; }
        public string Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Celular { get; set; }
    }
}
