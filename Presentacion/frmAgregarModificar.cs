using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class frmAgregarModificar : Form
    {
        public frmAgregarModificar()
        {
            InitializeComponent();
            Text = "Agregar";
        }
        private CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
        private MarcaNegocio marcaNegocio = new MarcaNegocio();
        private ArticuloNegocio articuloNegocio = new ArticuloNegocio();
        private void frmAgregarModificar_Load(object sender, EventArgs e)
        {
            cboCategoria.DataSource = categoriaNegocio.listar();
            cboMarca.DataSource = marcaNegocio.listar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo nuevo = new Articulo();
            try
            {
                nuevo.Codigo = txtCodigoArticulo.Text;
                nuevo.Nombre = txtNombre.Text;
                nuevo.Descripcion = txtDescripcion.Text;
                nuevo.Marca = new Marca();
                nuevo.Marca = (Marca)cboMarca.SelectedItem;
                nuevo.Tipo = new Categoria();
                nuevo.Tipo = (Categoria)cboCategoria.SelectedItem;
                nuevo.ImagenUrl = txtImagen.Text;
                nuevo.Precio = txtPrecio.Text;
                articuloNegocio.agregarArticulo(nuevo);
                MessageBox.Show("Agregado exitosamente");
                Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()) ;
            }
        }
    }
}
