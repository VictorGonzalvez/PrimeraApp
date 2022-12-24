using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class MarcaNegocio
    {
        private AccesoDatos datos = new AccesoDatos();

        public List<Marca> listar()
        {
            List<Marca> listaMarca = new List<Marca>();
            string consulta = "Select Descripcion, Id from Marcas";
            try
            {
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while(datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    listaMarca.Add(aux);
                }

                return listaMarca;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        
    }
}
