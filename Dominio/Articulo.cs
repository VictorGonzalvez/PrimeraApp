using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Dominio
{
    public class Articulo
    {
        [DisplayName("Código")]
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Categoria Tipo { get; set; }

        public string ImagenUrl { get; set; }
        public string Precio { get; set; }
        public int Id { get; set; }


    }
}
