﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Dominio
{
    public class Articulo
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }
        public string ImagenUrl { get; set; }
        public string Precio { get; set; }


    }
}