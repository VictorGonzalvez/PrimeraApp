using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        private AccesoDatos datos = new AccesoDatos();
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            string consulta = "select Codigo, Nombre, a.Descripcion, M.Descripcion as Marca, C.Descripcion as Categoria, ImagenUrl, Precio from ARTICULOS A join MARCAS M on a.IdMarca = m.id join CATEGORIAS C on a.IdCategoria = c.id";
            ;
            decimal x;
            try
            {
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();


                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    x = (decimal)datos.Lector["Precio"];
                    aux.Precio = x.ToString("0.00") ;
                    aux.Marca = new Marca();
                    aux.Tipo = new Categoria();
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Tipo.Descripcion = (string)datos.Lector["Categoria"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    

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
    }
}
