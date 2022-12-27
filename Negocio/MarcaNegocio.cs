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
        public List<string> cargarCbo()
        {
            List<string> lista = new List<string>();
            string consulta = "Select Descripcion from Marcas";
            try
            {
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                lista.Add("Todos");
                while (datos.Lector.Read())
                {
                    string aux;
                    aux = (string)datos.Lector["Descripcion"];
                    lista.Add(aux);
                }
                return lista;
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
        public void eliminarMarca(Marca seleccionado)
        {
            try
            {
                datos.setearConsulta("Delete from Marcas where Id = @Id");
                datos.setearParametro("@Id", seleccionado.Id);
                datos.ejecutarAccion();
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
        public void agregarMarca(string nuevo)
        {
            try
            {
                datos.setearConsulta("insert into MARCAS values (@nuevo)");
                datos.setearParametro("@nuevo", nuevo);
                datos.ejecutarAccion();
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
