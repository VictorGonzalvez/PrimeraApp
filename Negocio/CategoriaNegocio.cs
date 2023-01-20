using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;


namespace Negocio
{
    public class CategoriaNegocio
    {
        private AccesoDatos datos = new AccesoDatos();

        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();
            string consulta = "select Id, Descripcion from CATEGORIAS";
            try
            {
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
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
        public List<string> cargarCbo()
        {
            List<string> lista = new List<string>();
            string consulta = "select Descripcion from CATEGORIAS";
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
        public void eliminarCategoria(Categoria seleccionado)
        {
            try
            {
                datos.setearConsulta("Delete from CATEGORIAS where Id = @Id");
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
        public void agregarCategoria(string nuevo)
        {
            try
            {
                datos.setearConsulta("insert into Categorias values (@nuevo)");
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
        public void modificarCategoria(Categoria categoria, string descripcion)
        {
            try
            {
                datos.setearConsulta("Update Categorias set Descripcion = @descripcion where id = @id");
                datos.setearParametro("@id", categoria.Id);
                datos.setearParametro("@descripcion", descripcion);
                datos.ejecutarAccion();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
