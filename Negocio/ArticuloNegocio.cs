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
            string consulta = "select a.Id, Codigo, Nombre, a.Descripcion, M.Descripcion as Marca, C.Descripcion as Categoria, ImagenUrl, Precio, IdCategoria, IdMarca from ARTICULOS A join MARCAS M on a.IdMarca = m.id join CATEGORIAS C on a.IdCategoria = c.id";            
            decimal x;
            try
            {
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    x = (decimal)datos.Lector["Precio"];
                    aux.Precio = x.ToString("0.00") ;
                    aux.Marca = new Marca();
                    aux.Tipo = new Categoria();
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Tipo.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Tipo.Id = (int)datos.Lector["IdCategoria"];
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
        public void agregarArticulo(Articulo nuevo2)
        {
            string consulta = "insert into ARTICULOS (Codigo, Nombre, Descripcion,IdMarca, IdCategoria, ImagenUrl, Precio) values(@Codigo, @Nombre, @Descripcion ,@IdMarca, @IdCategoria, @ImagenUrl, @Precio)";
            try
            {
                datos.setearConsulta(consulta);
                datos.setearParametro("@Codigo", nuevo2.Codigo);
                datos.setearParametro("@Nombre", nuevo2.Nombre);
                datos.setearParametro("@Descripcion",nuevo2.Descripcion);
                datos.setearParametro("@IdMarca",nuevo2.Marca.Id);
                datos.setearParametro("@IdCategoria",nuevo2.Tipo.Id);
                datos.setearParametro("@ImagenUrl",nuevo2.ImagenUrl);
                datos.setearParametro("@Precio",nuevo2.Precio);
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
        public void modificarArticulo(Articulo articuloModificar)
        {
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @cod, Nombre = @nomb, Descripcion = @desc, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @Img, Precio = @Precio where id = @Id");
                datos.setearParametro("@cod", articuloModificar.Codigo);
                datos.setearParametro("@nomb", articuloModificar.Nombre);
                datos.setearParametro("@desc", articuloModificar.Descripcion);
                datos.setearParametro("@IdMarca", articuloModificar.Marca.Id);
                datos.setearParametro("@IdCategoria", articuloModificar.Tipo.Id);
                datos.setearParametro("@img", articuloModificar.ImagenUrl);
                datos.setearParametro("@Precio", articuloModificar.Precio);
                datos.setearParametro("@Id", articuloModificar.Id);
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
        public void eliminarArticulo(int id)
        {
            try
            {
                datos.setearConsulta("delete from ARTICULOS where id = " + id);
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
        public List<Articulo> listarAvanzado(string categoria, string marca, string orden)
        {
            List<Articulo> lista = new List<Articulo>();
            string consulta = "select a.Id, Codigo, Nombre, a.Descripcion, M.Descripcion as Marca, C.Descripcion as Categoria, ImagenUrl, Precio, IdCategoria, IdMarca from ARTICULOS A join MARCAS M on a.IdMarca = m.id join CATEGORIAS C on a.IdCategoria = c.id";

            if (categoria != "Todos" || marca != "Todos")
            {
                consulta += " Where ";
                if (categoria != "Todos" && marca != "Todos")
                    consulta += " c.Descripcion = '" + categoria + "' and m.descripcion = '" + marca + "'";

                else            
                    if(categoria != "Todos")                
                        consulta += " c.descripcion = '" + categoria + "'";                
                    else                
                        consulta += "m.descripcion = '" + marca + "'";

            }
            switch (orden)
            {
                case "Nombre A-Z":
                    consulta += " order by Nombre asc";
                    break;
                case "Nombre Z-A":
                    consulta += " order by Nombre Desc";
                    break;
                case "Precio Menor a Mayor":
                    consulta += " order by Precio asc ";
                    break;
                default:
                    consulta += " order by Precio desc";
                    break;
            }
            decimal x;
            try
            {
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    x = (decimal)datos.Lector["Precio"];
                    aux.Precio = x.ToString("0.00");
                    aux.Marca = new Marca();
                    aux.Tipo = new Categoria();
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Tipo.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Tipo.Id = (int)datos.Lector["IdCategoria"];
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
